﻿

#pragma checksum "C:\Users\Kristy\documents\visual studio 2015\Projects\WhatWhen\WhatWhen\WhatWhen.Windows\AddPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "4DA6C6EA5391921370AACBD07C6AA2FD"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WhatWhen
{
    partial class AddPage : global::Windows.UI.Xaml.Controls.Page, global::Windows.UI.Xaml.Markup.IComponentConnector
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
 
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1:
                #line 62 "..\..\AddPage.xaml"
                ((global::Windows.UI.Xaml.Controls.TextBox)(target)).TextChanged += this.TextBox_TextChanged;
                 #line default
                 #line hidden
                break;
            case 2:
                #line 89 "..\..\AddPage.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.ButtonBase)(target)).Click += this.cancel_Click;
                 #line default
                 #line hidden
                break;
            case 3:
                #line 90 "..\..\AddPage.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.ButtonBase)(target)).Click += this.ok_Click;
                 #line default
                 #line hidden
                break;
            case 4:
                #line 85 "..\..\AddPage.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.Selector)(target)).SelectionChanged += this.comboBox_SelectionChanged;
                 #line default
                 #line hidden
                break;
            case 5:
                #line 86 "..\..\AddPage.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.ButtonBase)(target)).Click += this.addCategory_Click;
                 #line default
                 #line hidden
                break;
            case 6:
                #line 74 "..\..\AddPage.xaml"
                ((global::Windows.UI.Xaml.Controls.TimePicker)(target)).TimeChanged += this.Time_TimeChanged;
                 #line default
                 #line hidden
                break;
            case 7:
                #line 42 "..\..\AddPage.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.ButtonBase)(target)).Click += this.backButton_Click;
                 #line default
                 #line hidden
                break;
            }
            this._contentLoaded = true;
        }
    }
}


