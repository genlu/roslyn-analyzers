﻿// Copyright (c) Microsoft.  All Rights Reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.

using System.Threading.Tasks;
using Analyzer.Utilities;
using Microsoft.CodeAnalysis.Testing;
using Xunit;
using VerifyCS = Test.Utilities.CSharpCodeFixVerifier<Microsoft.CodeAnalysis.CSharp.Analyzers.MetaAnalyzers.CSharpRegisterActionAnalyzer, Microsoft.CodeAnalysis.Testing.EmptyCodeFixProvider>;
using VerifyVB = Test.Utilities.VisualBasicCodeFixVerifier<Microsoft.CodeAnalysis.VisualBasic.Analyzers.MetaAnalyzers.BasicRegisterActionAnalyzer, Microsoft.CodeAnalysis.Testing.EmptyCodeFixProvider>;

namespace Microsoft.CodeAnalysis.Analyzers.UnitTests.MetaAnalyzers
{
    public class UnsupportedSymbolKindArgumentRuleTests
    {
        [Fact]
        public async Task CSharp_VerifyDiagnostic()
        {
            var source = @"
using System;
using System.Collections.Immutable;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.Diagnostics;

[DiagnosticAnalyzer(LanguageNames.CSharp)]
class MyAnalyzer : DiagnosticAnalyzer
{
    public override ImmutableArray<DiagnosticDescriptor> SupportedDiagnostics
    {
        get
        {
            throw new NotImplementedException();
        }
    }

    public override void Initialize(AnalysisContext context)
    {
        context.RegisterSymbolAction(AnalyzeSymbol,
            SymbolKind.Alias,
            SymbolKind.ArrayType,
            SymbolKind.Assembly,
            SymbolKind.Discard,
            SymbolKind.DynamicType,
            SymbolKind.ErrorType,
            SymbolKind.Event,
            SymbolKind.Field,
            SymbolKind.Label,
            SymbolKind.Local,
            SymbolKind.Method,
            SymbolKind.NetModule,
            SymbolKind.NamedType,
            SymbolKind.Namespace,
            SymbolKind.Parameter,
            SymbolKind.PointerType,
            SymbolKind.Property,
            SymbolKind.Preprocessing,
            SymbolKind.RangeVariable,
            SymbolKind.TypeParameter);
    }

    private static void AnalyzeSymbol(SymbolAnalysisContext context)
    {
    }
}";
            DiagnosticResult[] expected = new[]
            {
                GetCSharpExpectedDiagnostic(21, 13, unsupportedSymbolKind: SymbolKind.Alias),
                GetCSharpExpectedDiagnostic(22, 13, unsupportedSymbolKind: SymbolKind.ArrayType),
                GetCSharpExpectedDiagnostic(23, 13, unsupportedSymbolKind: SymbolKind.Assembly),
                GetCSharpExpectedDiagnostic(24, 13, unsupportedSymbolKind: SymbolKind.Discard),
                GetCSharpExpectedDiagnostic(25, 13, unsupportedSymbolKind: SymbolKind.DynamicType),
                GetCSharpExpectedDiagnostic(26, 13, unsupportedSymbolKind: SymbolKind.ErrorType),
                GetCSharpExpectedDiagnostic(29, 13, unsupportedSymbolKind: SymbolKind.Label),
                GetCSharpExpectedDiagnostic(30, 13, unsupportedSymbolKind: SymbolKind.Local),
                GetCSharpExpectedDiagnostic(32, 13, unsupportedSymbolKind: SymbolKind.NetModule),
                GetCSharpExpectedDiagnostic(36, 13, unsupportedSymbolKind: SymbolKind.PointerType),
                GetCSharpExpectedDiagnostic(38, 13, unsupportedSymbolKind: SymbolKind.Preprocessing),
                GetCSharpExpectedDiagnostic(39, 13, unsupportedSymbolKind: SymbolKind.RangeVariable),
                GetCSharpExpectedDiagnostic(40, 13, unsupportedSymbolKind: SymbolKind.TypeParameter),
            };

            await VerifyCS.VerifyAnalyzerAsync(source, expected);
        }

        [Fact]
        public async Task VisualBasic_VerifyRegisterSymbolActionDiagnostic()
        {
            var source = @"
Imports System
Imports System.Collections.Immutable
Imports Microsoft.CodeAnalysis
Imports Microsoft.CodeAnalysis.Diagnostics

<DiagnosticAnalyzer(LanguageNames.CSharp)>
Class MyAnalyzer
    Inherits DiagnosticAnalyzer
    Public Overrides ReadOnly Property SupportedDiagnostics() As ImmutableArray(Of DiagnosticDescriptor)
        Get
            Throw New NotImplementedException()
        End Get
    End Property

    Public Overrides Sub Initialize(context As AnalysisContext)
        context.RegisterSymbolAction(AddressOf AnalyzeSymbol,
            SymbolKind.Alias,
            SymbolKind.ArrayType,
            SymbolKind.Assembly,
            SymbolKind.Discard,
            SymbolKind.DynamicType,
            SymbolKind.ErrorType,
            SymbolKind.Event,
            SymbolKind.Field,
            SymbolKind.Label,
            SymbolKind.Local,
            SymbolKind.Method,
            SymbolKind.NetModule,
            SymbolKind.NamedType,
            SymbolKind.Namespace,
            SymbolKind.Parameter,
            SymbolKind.PointerType,
            SymbolKind.Property,
            SymbolKind.Preprocessing,
            SymbolKind.RangeVariable,
            SymbolKind.TypeParameter)
    End Sub

    Private Shared Sub AnalyzeSymbol(context As SymbolAnalysisContext)
    End Sub
End Class
";
            DiagnosticResult[] expected = new[]
            {
                GetBasicExpectedDiagnostic(18, 13, unsupportedSymbolKind: SymbolKind.Alias),
                GetBasicExpectedDiagnostic(19, 13, unsupportedSymbolKind: SymbolKind.ArrayType),
                GetBasicExpectedDiagnostic(20, 13, unsupportedSymbolKind: SymbolKind.Assembly),
                GetBasicExpectedDiagnostic(21, 13, unsupportedSymbolKind: SymbolKind.Discard),
                GetBasicExpectedDiagnostic(22, 13, unsupportedSymbolKind: SymbolKind.DynamicType),
                GetBasicExpectedDiagnostic(23, 13, unsupportedSymbolKind: SymbolKind.ErrorType),
                GetBasicExpectedDiagnostic(26, 13, unsupportedSymbolKind: SymbolKind.Label),
                GetBasicExpectedDiagnostic(27, 13, unsupportedSymbolKind: SymbolKind.Local),
                GetBasicExpectedDiagnostic(29, 13, unsupportedSymbolKind: SymbolKind.NetModule),
                GetBasicExpectedDiagnostic(33, 13, unsupportedSymbolKind: SymbolKind.PointerType),
                GetBasicExpectedDiagnostic(35, 13, unsupportedSymbolKind: SymbolKind.Preprocessing),
                GetBasicExpectedDiagnostic(36, 13, unsupportedSymbolKind: SymbolKind.RangeVariable),
                GetBasicExpectedDiagnostic(37, 13, unsupportedSymbolKind: SymbolKind.TypeParameter),
            };

            await VerifyVB.VerifyAnalyzerAsync(source, expected);
        }

        [Fact]
        public async Task CSharp_NoDiagnosticCases()
        {
            var source = @"
using System;
using System.Collections.Immutable;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.Diagnostics;

[DiagnosticAnalyzer(LanguageNames.CSharp)]
class MyAnalyzer : DiagnosticAnalyzer
{
    public override ImmutableArray<DiagnosticDescriptor> SupportedDiagnostics
    {
        get
        {
            throw new NotImplementedException();
        }
    }

    public override void Initialize(AnalysisContext context)
    {
        // Valid symbol kinds.
        context.RegisterSymbolAction(AnalyzeSymbol,
            SymbolKind.Event,
            SymbolKind.Field,
            SymbolKind.Method,
            SymbolKind.NamedType,
            SymbolKind.Namespace,
            SymbolKind.Property);

        // Overload resolution failure
        context.RegisterSymbolAction({|CS1503:AnalyzeSyntax|},
            SymbolKind.Event,
            SymbolKind.Field,
            SymbolKind.Method,
            SymbolKind.NamedType,
            SymbolKind.Namespace,
            SymbolKind.Property);
    }

    private static void AnalyzeSymbol(SymbolAnalysisContext context)
    {
    }

    private static void AnalyzeSyntax(SyntaxNodeAnalysisContext context)
    {
    }
}";

            await VerifyCS.VerifyAnalyzerAsync(source);
        }

        [Fact]
        public async Task VisualBasic_NoDiagnosticCases()
        {
            var source = @"
Imports System
Imports System.Collections.Immutable
Imports Microsoft.CodeAnalysis
Imports Microsoft.CodeAnalysis.Diagnostics

<DiagnosticAnalyzer(LanguageNames.CSharp)>
Class MyAnalyzer
    Inherits DiagnosticAnalyzer
    Public Overrides ReadOnly Property SupportedDiagnostics() As ImmutableArray(Of DiagnosticDescriptor)
        Get
            Throw New NotImplementedException()
        End Get
    End Property

    Public Overrides Sub Initialize(context As AnalysisContext)
        
        ' Valid symbol kinds
        context.RegisterSymbolAction(AddressOf AnalyzeSymbol,
            SymbolKind.Event,
            SymbolKind.Field,
            SymbolKind.Method,
            SymbolKind.NamedType,
            SymbolKind.Namespace,
            SymbolKind.Property)

        ' Overload resolution failure
        context.{|BC30518:RegisterSymbolAction|}(AddressOf AnalyzeSyntax,
            SymbolKind.Alias)
    End Sub

    Private Shared Sub AnalyzeSymbol(context As SymbolAnalysisContext)
    End Sub

    Private Shared Sub AnalyzeSyntax(context As SyntaxNodeAnalysisContext)
    End Sub
End Class
";

            await VerifyVB.VerifyAnalyzerAsync(source);
        }

        private static DiagnosticResult GetCSharpExpectedDiagnostic(int line, int column, SymbolKind unsupportedSymbolKind)
        {
            return GetExpectedDiagnostic(line, column, unsupportedSymbolKind);
        }

        private static DiagnosticResult GetBasicExpectedDiagnostic(int line, int column, SymbolKind unsupportedSymbolKind)
        {
            return GetExpectedDiagnostic(line, column, unsupportedSymbolKind);
        }

        private static DiagnosticResult GetExpectedDiagnostic(int line, int column, SymbolKind unsupportedSymbolKind)
        {
            return new DiagnosticResult(DiagnosticIds.UnsupportedSymbolKindArgumentRuleId, DiagnosticHelpers.DefaultDiagnosticSeverity)
                .WithLocation(line, column)
                .WithMessageFormat(CodeAnalysisDiagnosticsResources.UnsupportedSymbolKindArgumentToRegisterActionMessage)
                .WithArguments(unsupportedSymbolKind.ToString());
        }
    }
}
