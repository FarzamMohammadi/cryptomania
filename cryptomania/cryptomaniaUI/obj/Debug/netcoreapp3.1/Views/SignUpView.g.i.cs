// Updated by XamlIntelliSenseFileGenerator 11/28/2021 2:13:35 AM
#pragma checksum "..\..\..\..\Views\SignUpView.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "F1AD1854AA079B9E3B0B60118E949A5D849B0767"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
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
using cryptomaniaUI.Views;


namespace cryptomaniaUI.Views
{


    /// <summary>
    /// SignUpView
    /// </summary>
    public partial class SignUpView : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector
    {


#line 18 "..\..\..\..\Views\SignUpView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox FNameTBox;

#line default
#line hidden


#line 19 "..\..\..\..\Views\SignUpView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox LNameTBox;

#line default
#line hidden


#line 20 "..\..\..\..\Views\SignUpView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox emailTBox;

#line default
#line hidden


#line 23 "..\..\..\..\Views\SignUpView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox rePassTBox;

#line default
#line hidden


#line 24 "..\..\..\..\Views\SignUpView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox passTBox;

#line default
#line hidden

        private bool _contentLoaded;

        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.0.0")]
        public void InitializeComponent()
        {
            if (_contentLoaded)
            {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/cryptomaniaUI;V1.0.0.0;component/views/signupview.xaml", System.UriKind.Relative);

#line 1 "..\..\..\..\Views\SignUpView.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);

#line default
#line hidden
        }

        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
        {
            switch (connectionId)
            {
                case 1:

#line 11 "..\..\..\..\Views\SignUpView.xaml"
                    ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Login_btn_Click);

#line default
#line hidden
                    return;
                case 2:
                    this.FNameTBox = ((System.Windows.Controls.TextBox)(target));
                    return;
                case 3:
                    this.LNameTBox = ((System.Windows.Controls.TextBox)(target));
                    return;
                case 4:
                    this.emailTBox = ((System.Windows.Controls.TextBox)(target));
                    return;
                case 5:

#line 22 "..\..\..\..\Views\SignUpView.xaml"
                    ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Main_btn_Click);

#line default
#line hidden
                    return;
                case 6:
                    this.rePassTBox = ((System.Windows.Controls.PasswordBox)(target));
                    return;
                case 7:
                    this.passTBox = ((System.Windows.Controls.PasswordBox)(target));
                    return;
            }
            this._contentLoaded = true;
        }

        internal System.Windows.Controls.Button btnClear;
        internal System.Windows.Controls.Button btnRegister;
    }
}
