﻿// Copyright (c) Microsoft.  All Rights Reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.

using System.Collections.Generic;
using System.Collections.Immutable;
using Analyzer.Utilities;
using Analyzer.Utilities.Extensions;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.Diagnostics;
using Microsoft.CodeAnalysis.Operations;

namespace Microsoft.CodeQuality.Analyzers.Maintainability
{
    /// <summary>
    /// CA1507 Use nameof to express symbol names
    /// </summary>
    [DiagnosticAnalyzer(LanguageNames.CSharp, LanguageNames.VisualBasic)]
    public sealed class UseNameofInPlaceOfStringAnalyzer : DiagnosticAnalyzer
    {
        internal const string RuleId = "CA1507";
        private const string ParamName = "paramName";
        private const string PropertyName = "propertyName";
        internal const string StringText = "StringText";

        private static readonly LocalizableString s_localizableTitle = new LocalizableResourceString(nameof(MicrosoftMaintainabilityAnalyzersResources.UseNameOfInPlaceOfStringTitle), MicrosoftMaintainabilityAnalyzersResources.ResourceManager, typeof(MicrosoftMaintainabilityAnalyzersResources));
        private static readonly LocalizableString s_localizableMessage = new LocalizableResourceString(nameof(MicrosoftMaintainabilityAnalyzersResources.UseNameOfInPlaceOfStringMessage), MicrosoftMaintainabilityAnalyzersResources.ResourceManager, typeof(MicrosoftMaintainabilityAnalyzersResources));
        private static readonly LocalizableString s_localizableDescription = new LocalizableResourceString(nameof(MicrosoftMaintainabilityAnalyzersResources.UseNameOfInPlaceOfStringDescription), MicrosoftMaintainabilityAnalyzersResources.ResourceManager, typeof(MicrosoftMaintainabilityAnalyzersResources));

        internal static DiagnosticDescriptor RuleWithSuggestion = new DiagnosticDescriptor(RuleId,
                                                                         s_localizableTitle,
                                                                         s_localizableMessage,
                                                                         DiagnosticCategory.Maintainability,
                                                                         DiagnosticHelpers.DefaultDiagnosticSeverity,
                                                                         isEnabledByDefault: true,
                                                                         description: s_localizableDescription,
                                                                         helpLinkUri: "https://github.com/dotnet/roslyn-analyzers/blob/master/src/Microsoft.CodeQuality.Analyzers/Microsoft.CodeQuality.Analyzers.md#maintainability",
                                                                         customTags: WellKnownDiagnosticTags.Telemetry);

        public override ImmutableArray<DiagnosticDescriptor> SupportedDiagnostics => ImmutableArray.Create(RuleWithSuggestion);

        public override void Initialize(AnalysisContext analysisContext)
        {
            analysisContext.EnableConcurrentExecution();
            analysisContext.ConfigureGeneratedCodeAnalysis(GeneratedCodeAnalysisFlags.None);

            analysisContext.RegisterOperationAction(AnalyzeArgument, OperationKind.Argument);
        }

        private void AnalyzeArgument(OperationAnalysisContext context)
        {
            var argument = (IArgumentOperation)context.Operation;
            if ((argument.Value.Kind != OperationKind.Literal 
                || argument.ArgumentKind != ArgumentKind.Explicit
                || argument.Value.Type.SpecialType != SpecialType.System_String))
            {
                return;
            }

            if (argument.Parameter == null)
            {
                return;
            }

            var stringText = (string)argument.Value.ConstantValue.Value;

            var matchingParameter = argument.Parameter;

            switch (matchingParameter.Name)
            {
                case ParamName:
                    var parametersInScope = GetParametersInScope(context);
                    if (HasAMatchInScope(stringText, parametersInScope))
                    {
                        context.ReportDiagnostic(Diagnostic.Create(
                            RuleWithSuggestion, argument.Value.Syntax.GetLocation(), stringText ));
                    }
                    return;
                case PropertyName:
                    var propertiesInScope = GetPropertiesInScope(context);
                    if (HasAMatchInScope(stringText, propertiesInScope))
                    {
                        context.ReportDiagnostic(Diagnostic.Create(
                            RuleWithSuggestion, argument.Value.Syntax.GetLocation(), stringText));
                    }
                    return;
                default:
                    return;
            }
        }

        private IEnumerable<string> GetPropertiesInScope(OperationAnalysisContext context)
        {
            var containingType = context.ContainingSymbol.ContainingType;
            // look for all of the properties in the containing type and return the property names
            if (containingType != null)
            {
                foreach (var property in containingType.GetMembers().OfType<IPropertySymbol>())
                {
                    yield return property.Name;
                }
            }
        }

        internal IEnumerable<string> GetParametersInScope(OperationAnalysisContext context)
        {
            // get the parameters for the containing method
            foreach (var parameter in context.ContainingSymbol.GetParameters())
            {
                yield return parameter.Name;
            }

            // and loop through the ancestors to find parameters of anonymous functions and local functions
            var parentOperation = context.Operation.Parent;
            while (parentOperation != null)
            {
                if (parentOperation.Kind == OperationKind.AnonymousFunction)
                {
                    var lambdaSymbol = ((IAnonymousFunctionOperation)parentOperation).Symbol;
                    if (lambdaSymbol != null)
                    {
                        foreach (var lambdaParameter in lambdaSymbol.Parameters)
                        {
                            yield return lambdaParameter.Name;
                        }
                    }
                }
                else if (parentOperation.Kind == OperationKind.LocalFunction)
                {
                    var localFunction = ((ILocalFunctionOperation)parentOperation).Symbol;
                    foreach (var localFunctionParameter in localFunction.Parameters)
                    {
                        yield return localFunctionParameter.Name;
                    }
                }

                parentOperation = parentOperation.Parent;
            }
        }

        private static bool HasAMatchInScope(string stringText, IEnumerable<string> searchCollection)
        {
            foreach (var name in searchCollection)
            {
                if (stringText == name)
                {
                    return true;
                }
            }

            return false;
        }
    }
}