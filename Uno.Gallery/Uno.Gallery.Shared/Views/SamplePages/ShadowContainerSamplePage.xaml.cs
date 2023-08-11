﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Uno.Gallery.Entities.Data;
using Uno.Toolkit.UI;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;

namespace Uno.Gallery.Views.SamplePages
{
	[SamplePage(SampleCategory.Toolkit, "ShadowContainer",
		SourceSdk.UnoToolkit,
		Description = "The ShadowContainer provides the possibility to add many-colored shadows to its content.",
		DocumentationLink = "https://github.com/unoplatform/uno.toolkit.ui/blob/main/doc/controls/ShadowContainer.md",
		DataType = typeof(TestCollections))]
	public sealed partial class ShadowContainerSamplePage : Page
	{
		public ShadowContainerSamplePage()
		{
			this.InitializeComponent();
		}

	}
}
