﻿#pragma checksum "..\..\SignIn_Page.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "570A5216848468A47BCC655E8EBA0AD6345622B22316B1154B6D59851CA46909"
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
using XamlAnimatedGif;


namespace CCUiGO2 {
    
    
    /// <summary>
    /// SignIn_Page
    /// </summary>
    public partial class SignIn_Page : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 108 "..\..\SignIn_Page.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label Sign_in_line;
        
        #line default
        #line hidden
        
        
        #line 113 "..\..\SignIn_Page.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label Sign_up_Box;
        
        #line default
        #line hidden
        
        
        #line 114 "..\..\SignIn_Page.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label Sign_up_line;
        
        #line default
        #line hidden
        
        
        #line 121 "..\..\SignIn_Page.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox id_inputbox;
        
        #line default
        #line hidden
        
        
        #line 125 "..\..\SignIn_Page.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox pw_inputbox;
        
        #line default
        #line hidden
        
        
        #line 127 "..\..\SignIn_Page.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox rememberIDcheck;
        
        #line default
        #line hidden
        
        
        #line 131 "..\..\SignIn_Page.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button igoBTN;
        
        #line default
        #line hidden
        
        
        #line 132 "..\..\SignIn_Page.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button loadingBTN;
        
        #line default
        #line hidden
        
        
        #line 137 "..\..\SignIn_Page.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label forgetpw;
        
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
            System.Uri resourceLocater = new System.Uri("/CCUiGO2;component/signin_page.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\SignIn_Page.xaml"
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
            this.Sign_in_line = ((System.Windows.Controls.Label)(target));
            return;
            case 2:
            this.Sign_up_Box = ((System.Windows.Controls.Label)(target));
            return;
            case 3:
            this.Sign_up_line = ((System.Windows.Controls.Label)(target));
            return;
            case 4:
            this.id_inputbox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.pw_inputbox = ((System.Windows.Controls.PasswordBox)(target));
            return;
            case 6:
            this.rememberIDcheck = ((System.Windows.Controls.CheckBox)(target));
            return;
            case 7:
            this.igoBTN = ((System.Windows.Controls.Button)(target));
            return;
            case 8:
            this.loadingBTN = ((System.Windows.Controls.Button)(target));
            return;
            case 9:
            this.forgetpw = ((System.Windows.Controls.Label)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
