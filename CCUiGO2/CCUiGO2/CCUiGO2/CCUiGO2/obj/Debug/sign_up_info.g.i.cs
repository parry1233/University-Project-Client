﻿#pragma checksum "..\..\sign_up_info.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "B6F9473AE8467179BC146D59DC2185FF79E85DA6F6D5D6932A5EA8BB8FEF1005"
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
    /// sign_up_info
    /// </summary>
    public partial class sign_up_info : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 140 "..\..\sign_up_info.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView Title;
        
        #line default
        #line hidden
        
        
        #line 146 "..\..\sign_up_info.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListViewItem ZoomIn;
        
        #line default
        #line hidden
        
        
        #line 149 "..\..\sign_up_info.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListViewItem Close;
        
        #line default
        #line hidden
        
        
        #line 164 "..\..\sign_up_info.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox nickname;
        
        #line default
        #line hidden
        
        
        #line 170 "..\..\sign_up_info.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox email;
        
        #line default
        #line hidden
        
        
        #line 176 "..\..\sign_up_info.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox department;
        
        #line default
        #line hidden
        
        
        #line 226 "..\..\sign_up_info.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox grade;
        
        #line default
        #line hidden
        
        
        #line 237 "..\..\sign_up_info.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton male;
        
        #line default
        #line hidden
        
        
        #line 239 "..\..\sign_up_info.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton female;
        
        #line default
        #line hidden
        
        
        #line 244 "..\..\sign_up_info.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button next;
        
        #line default
        #line hidden
        
        
        #line 245 "..\..\sign_up_info.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button back;
        
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
            System.Uri resourceLocater = new System.Uri("/CCUiGO2;component/sign_up_info.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\sign_up_info.xaml"
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
            
            #line 138 "..\..\sign_up_info.xaml"
            ((System.Windows.Controls.Grid)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.WindowDrag);
            
            #line default
            #line hidden
            return;
            case 2:
            this.Title = ((System.Windows.Controls.ListView)(target));
            
            #line 140 "..\..\sign_up_info.xaml"
            this.Title.PreviewMouseLeftButtonUp += new System.Windows.Input.MouseButtonEventHandler(this.TitleClick);
            
            #line default
            #line hidden
            return;
            case 3:
            this.ZoomIn = ((System.Windows.Controls.ListViewItem)(target));
            return;
            case 4:
            this.Close = ((System.Windows.Controls.ListViewItem)(target));
            return;
            case 5:
            this.nickname = ((System.Windows.Controls.TextBox)(target));
            
            #line 165 "..\..\sign_up_info.xaml"
            this.nickname.GotFocus += new System.Windows.RoutedEventHandler(this.nickname_GotFocus_1);
            
            #line default
            #line hidden
            
            #line 165 "..\..\sign_up_info.xaml"
            this.nickname.LostFocus += new System.Windows.RoutedEventHandler(this.nickname_LostFocus_1);
            
            #line default
            #line hidden
            return;
            case 6:
            this.email = ((System.Windows.Controls.TextBox)(target));
            
            #line 171 "..\..\sign_up_info.xaml"
            this.email.GotFocus += new System.Windows.RoutedEventHandler(this.email_GotFocus_1);
            
            #line default
            #line hidden
            
            #line 171 "..\..\sign_up_info.xaml"
            this.email.LostFocus += new System.Windows.RoutedEventHandler(this.email_LostFocus_1);
            
            #line default
            #line hidden
            return;
            case 7:
            this.department = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 8:
            this.grade = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 9:
            this.male = ((System.Windows.Controls.RadioButton)(target));
            return;
            case 10:
            this.female = ((System.Windows.Controls.RadioButton)(target));
            return;
            case 11:
            this.next = ((System.Windows.Controls.Button)(target));
            
            #line 244 "..\..\sign_up_info.xaml"
            this.next.Click += new System.Windows.RoutedEventHandler(this.Next_Click);
            
            #line default
            #line hidden
            return;
            case 12:
            this.back = ((System.Windows.Controls.Button)(target));
            
            #line 245 "..\..\sign_up_info.xaml"
            this.back.Click += new System.Windows.RoutedEventHandler(this.Back_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

