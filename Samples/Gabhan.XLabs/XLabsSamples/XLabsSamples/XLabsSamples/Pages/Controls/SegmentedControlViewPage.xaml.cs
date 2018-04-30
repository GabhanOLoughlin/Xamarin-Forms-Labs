﻿// ***********************************************************************
// Assembly         : XLabs.Sample
// Author           : XLabs Team
// Created          : 12-27-2015
// 
// Last Modified By : XLabs Team
// Last Modified On : 01-04-2016
// ***********************************************************************
// <copyright file="SegmentedControlViewPage.xaml.cs" company="XLabs Team">
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
// 

using Xamarin.Forms;

namespace XLabsSamples.Pages.Controls
{
	/// <summary>
	/// Class SegmentedControlViewPage.
	/// </summary>
	public partial class SegmentedControlViewPage : ContentPage
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="SegmentedControlViewPage"/> class.
		/// </summary>
		public SegmentedControlViewPage()
		{
			InitializeComponent();

			Filter.SelectedItem = 1;
		}
	}
}