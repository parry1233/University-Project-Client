﻿#pragma checksum "..\..\VerifyCode.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "EAD5A8CF6EE2B82220E935C322EDDFDD577BEEDC04C1979C8D7A74E9F6CB4194"
//------------------------------------------------------------------------------
// <auto-generated>
//     這段程式碼是由工具產生的。
//     執行階段版本:4.0.30319.42000
//
//     對這個檔案所做的變更可能會造成錯誤的行為，而且如果重新產生程式碼，
//     變更將會遺失。
// </auto-generated>
//------------------------------------------------------------------------------

using CCUiGO2;
using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Converters;
using MaterialDesignThemes.Wpf.Transitions;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace CCUiGO2 {
    
    
    /// <summary>
    /// VerifyCode
    /// </summary>
    public partial class VerifyCode : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 54 "..\..\VerifyCode.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox verify_code_text;
        
        #line default
        #line hidden
        
        
        #line 62 "..\..\VerifyCode.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label back;
        
        #line default
        #line hidden
        
        
        #line 65 "..\..\VerifyCode.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label next;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/CCUiGO2;component/verifycode.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\VerifyCode.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 11 "..\..\VerifyCode.xaml"
            ((CCUiGO2.VerifyCode)(target)).MouseMove += new System.Windows.Input.MouseEventHandler(this.Drag_MouseMove);
            
            #line default
            #line hidden
            return;
            case 2:
            this.verify_code_text = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.back = ((System.Windows.Controls.Label)(target));
            
            #line 62 "..\..\VerifyCode.xaml"
            this.back.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.back_MouseDown);
            
            #line default
            #line hidden
            return;
            case 4:
            this.next = ((System.Windows.Controls.Label)(target));
            
            #line 65 "..\..\VerifyCode.xaml"
            this.next.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Label_MouseDown_1);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
