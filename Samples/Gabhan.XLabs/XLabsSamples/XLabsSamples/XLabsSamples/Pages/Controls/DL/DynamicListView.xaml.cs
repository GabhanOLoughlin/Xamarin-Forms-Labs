// ***********************************************************************
// Assembly         : XLabs.Sample
// Author           : XLabs Team
// Created          : 12-27-2015
// 
// Last Modified By : XLabs Team
// Last Modified On : 01-04-2016
// ***********************************************************************
// <copyright file="DynamicListView.xaml.cs" company="XLabs Team">
//     Copyright (c) XLabs Team. All rights reserved.
// </copyright>
// <summary>
//       This project is licensed under the Apache 2.0 license
//       https://github.com/XLabs/Xamarin-Forms-Labs/blob/master/LICENSE
//       
//       XLabs is a open source project that aims to provide a powerfull and cross 
//       platform set of controls tailored to work with Xamarin Forms.
// </summary>
// ***********************************************************************
//XLabsSamples.Pages.Controls.DynamicList
//XLabsSamples.Pages.Controls.DynamicList.DynamicListView
// 

using System;
using XLabs;
using XLabs.Forms.Mvvm;

namespace XLabsSamples.Pages.Controls.DynamicList
{
    public partial class DynamicListView : BaseView
    {
        private int _count;
        public DynamicListView()
        {
            InitializeComponent();

            this.Button.Clicked += (s, e) => this.DynamicList.Data.Add(string.Format("Added {0} items.", ++_count));

            this.ButtonDate.Clicked += (s, e) => this.DynamicList.Data.Add(DateTime.Now);

            this.DynamicList.OnSelected += dynamicList_OnSelected;
        }

        void dynamicList_OnSelected(object sender, EventArgs<object> e)
        {
            System.Diagnostics.Debug.WriteLine(e.Value);
            try
            {
                this.DynamicList.Remove(e.Value);
            }
            catch (Exception ex)
            {

                System.Diagnostics.Debug.WriteLine(ex.Message);
            }
            
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
        }
    }
}
