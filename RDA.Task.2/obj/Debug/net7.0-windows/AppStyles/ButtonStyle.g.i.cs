#pragma checksum "..\..\..\..\AppStyles\ButtonStyle.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "97D494593AB824D005FAB5E4DCA2955EEC03FE8D"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Converters;
using MaterialDesignThemes.Wpf.Transitions;
using RDA.Task._2;
using RDA.Task._2.AppStyles;
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


namespace RDA.Task._2.AppStyles {
    
    
    /// <summary>
    /// ButtonStyle
    /// </summary>
    public partial class ButtonStyle : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 18 "..\..\..\..\AppStyles\ButtonStyle.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnTask1;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\..\AppStyles\ButtonStyle.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnTask3;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\..\AppStyles\ButtonStyle.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnTask2;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.3.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/RDA.Task.2;V1.0.0.0;component/appstyles/buttonstyle.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\AppStyles\ButtonStyle.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.3.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.BtnTask1 = ((System.Windows.Controls.Button)(target));
            
            #line 19 "..\..\..\..\AppStyles\ButtonStyle.xaml"
            this.BtnTask1.Click += new System.Windows.RoutedEventHandler(this.BtnTask1_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.BtnTask3 = ((System.Windows.Controls.Button)(target));
            
            #line 30 "..\..\..\..\AppStyles\ButtonStyle.xaml"
            this.BtnTask3.Click += new System.Windows.RoutedEventHandler(this.BtnTask3_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.BtnTask2 = ((System.Windows.Controls.Button)(target));
            
            #line 40 "..\..\..\..\AppStyles\ButtonStyle.xaml"
            this.BtnTask2.Click += new System.Windows.RoutedEventHandler(this.BtnTask2_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

