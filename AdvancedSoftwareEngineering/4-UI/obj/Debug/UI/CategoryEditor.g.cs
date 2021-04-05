﻿#pragma checksum "..\..\..\UI\CategoryEditor.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "DCF625FABE1F197E507C2BA379D9B4CF9D61DC69182731E69054F0B6286E8C7B"
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
using _4_UI.UI;


namespace _4_UI.UI {
    
    
    /// <summary>
    /// CategoryEditor
    /// </summary>
    public partial class CategoryEditor : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 11 "..\..\..\UI\CategoryEditor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid myGrid;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\..\UI\CategoryEditor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label categoryLabel;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\..\UI\CategoryEditor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox categoryComboBox;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\UI\CategoryEditor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox nameTextBox;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\..\UI\CategoryEditor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox colourComboBox;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\..\UI\CategoryEditor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox limitTextBox;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\..\UI\CategoryEditor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox currencyComboBox;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\..\UI\CategoryEditor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button createCategoryButton;
        
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
            System.Uri resourceLocater = new System.Uri("/4-UI;component/ui/categoryeditor.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\UI\CategoryEditor.xaml"
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
            this.myGrid = ((System.Windows.Controls.Grid)(target));
            return;
            case 2:
            
            #line 24 "..\..\..\UI\CategoryEditor.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.ClickCreationMode);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 27 "..\..\..\UI\CategoryEditor.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.ClickEditMode);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 30 "..\..\..\UI\CategoryEditor.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.BackClick);
            
            #line default
            #line hidden
            return;
            case 5:
            this.categoryLabel = ((System.Windows.Controls.Label)(target));
            return;
            case 6:
            this.categoryComboBox = ((System.Windows.Controls.ComboBox)(target));
            
            #line 36 "..\..\..\UI\CategoryEditor.xaml"
            this.categoryComboBox.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.CategorySelectionChanged);
            
            #line default
            #line hidden
            return;
            case 7:
            this.nameTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.colourComboBox = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 9:
            this.limitTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 10:
            this.currencyComboBox = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 11:
            this.createCategoryButton = ((System.Windows.Controls.Button)(target));
            
            #line 47 "..\..\..\UI\CategoryEditor.xaml"
            this.createCategoryButton.Click += new System.Windows.RoutedEventHandler(this.ClickCreateCategory);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

