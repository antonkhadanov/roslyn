﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.18326
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On

Imports System

Namespace TestResources.SymbolsTests
    
    'This class was auto-generated by the StronglyTypedResourceBuilder
    'class via a tool like ResGen or Visual Studio.
    'To add or remove a member, edit your .ResX file then rerun ResGen
    'with the /str option, or rebuild your VS project.
    '''<summary>
    '''  A strongly-typed resource class, for looking up localized strings, etc.
    '''</summary>
    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0"),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute()>  _
    Public Class V1
        
        Private Shared resourceMan As Global.System.Resources.ResourceManager
        
        Private Shared resourceCulture As Global.System.Globalization.CultureInfo
        
        <Global.System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")>  _
        Friend Sub New()
            MyBase.New
        End Sub
        
        '''<summary>
        '''  Returns the cached ResourceManager instance used by this class.
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Public Shared ReadOnly Property ResourceManager() As Global.System.Resources.ResourceManager
            Get
                If Object.ReferenceEquals(resourceMan, Nothing) Then
                    Dim temp As Global.System.Resources.ResourceManager = New Global.System.Resources.ResourceManager("V1", GetType(V1).Assembly)
                    resourceMan = temp
                End If
                Return resourceMan
            End Get
        End Property
        
        '''<summary>
        '''  Overrides the current thread's CurrentUICulture property for all
        '''  resource lookups using this strongly typed resource class.
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Public Shared Property Culture() As Global.System.Globalization.CultureInfo
            Get
                Return resourceCulture
            End Get
            Set
                resourceCulture = value
            End Set
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Byte[].
        '''</summary>
        Public Shared ReadOnly Property MTTestLib1() As Byte()
            Get
                Dim obj As Object = ResourceManager.GetObject("MTTestLib1", resourceCulture)
                Return CType(obj,Byte())
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to &apos;vbc /t:library /out:MTTestLib1.Dll MTTestLib1_V1.vb 
        '''&apos;vbc /t:module /out:MTTestModule1.netmodule MTTestLib1_V1.vb
        '''
        '''&lt;Assembly: System.Reflection.AssemblyVersion(&quot;1.0.0.0&quot;)&gt; 
        '''&lt;Assembly: System.Reflection.AssemblyFileVersion(&quot;1.0.0.0&quot;)&gt; 
        '''
        '''Public Class Class1
        '''
        '''End Class
        '''
        '''Public Delegate Sub Delegate1()
        '''
        '''Public Interface Interface1
        '''    Sub Method1() &apos; same in V2
        '''    Sub Method2() &apos; gone in V2
        '''    Sub Method3(x As Boolean) &apos; different param type in V2
        '''    Sub Method4(x As Class1) &apos; new version of [rest of string was truncated]&quot;;.
        '''</summary>
        Public Shared ReadOnly Property MTTestLib1_V1() As String
            Get
                Return ResourceManager.GetString("MTTestLib1_V1", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Byte[].
        '''</summary>
        Public Shared ReadOnly Property MTTestLib2() As Byte()
            Get
                Dim obj As Object = ResourceManager.GetObject("MTTestLib2", resourceCulture)
                Return CType(obj,Byte())
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to &apos; vbc /t:Library /out:MTTestLib2.Dll MTTestLib2_V1.vb /r:MTTestLib1.Dll
        '''&apos; vbc /t:module /out:MTTestModule2.netmodule MTTestLib2_V1.vb /r:MTTestLib1.Dll
        '''
        '''Public Class Class4
        '''    Function Foo() As Class1
        '''        Return Nothing
        '''    End Function
        '''
        '''    Public Bar As Class1
        '''
        '''    Public Class Class4_1
        '''
        '''    End Class
        '''End Class.
        '''</summary>
        Public Shared ReadOnly Property MTTestLib2_V1() As String
            Get
                Return ResourceManager.GetString("MTTestLib2_V1", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Byte[].
        '''</summary>
        Public Shared ReadOnly Property MTTestModule1() As Byte()
            Get
                Dim obj As Object = ResourceManager.GetObject("MTTestModule1", resourceCulture)
                Return CType(obj,Byte())
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Byte[].
        '''</summary>
        Public Shared ReadOnly Property MTTestModule2() As Byte()
            Get
                Dim obj As Object = ResourceManager.GetObject("MTTestModule2", resourceCulture)
                Return CType(obj,Byte())
            End Get
        End Property
    End Class
End Namespace
