#pragma checksum "..\..\UserSettings.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "E3BE45DE67DF2418D1A18E2A6BD521FF1B877E5E45B7E8A5C4802769FEBD4A5C"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using CaloriesCalculator;
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


namespace CaloriesCalculator {
    
    
    /// <summary>
    /// UserSettings
    /// </summary>
    public partial class UserSettings : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 11 "..\..\UserSettings.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Age;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\UserSettings.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Height;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\UserSettings.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox Status;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\UserSettings.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Weight;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\UserSettings.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Update;
        
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
            System.Uri resourceLocater = new System.Uri("/CaloriesCalculator;component/usersettings.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\UserSettings.xaml"
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
            this.Age = ((System.Windows.Controls.TextBox)(target));
            
            #line 11 "..\..\UserSettings.xaml"
            this.Age.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.Weight_PreviewTextInput);
            
            #line default
            #line hidden
            return;
            case 2:
            this.Height = ((System.Windows.Controls.TextBox)(target));
            
            #line 13 "..\..\UserSettings.xaml"
            this.Height.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.Weight_PreviewTextInput);
            
            #line default
            #line hidden
            return;
            case 3:
            this.Status = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 4:
            this.Weight = ((System.Windows.Controls.TextBox)(target));
            
            #line 17 "..\..\UserSettings.xaml"
            this.Weight.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.Weight_PreviewTextInput);
            
            #line default
            #line hidden
            return;
            case 5:
            this.Update = ((System.Windows.Controls.Button)(target));
            
            #line 18 "..\..\UserSettings.xaml"
            this.Update.Click += new System.Windows.RoutedEventHandler(this.Update_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

