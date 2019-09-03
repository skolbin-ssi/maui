﻿namespace Xamarin.Forms.Controls.GalleryPages.CollectionViewGalleries.HeaderFooterGalleries
{
	internal class HeaderFooterGallery : ContentPage
	{
		public HeaderFooterGallery()
		{
			var descriptionLabel =
				new Label { Text = "Header/Footer Galleries", Margin = new Thickness(2, 2, 2, 2) };

			Title = "Header/Footer Galleries";

			Content = new ScrollView
			{
				Content = new StackLayout
				{
					Children =
					{
						descriptionLabel,
						GalleryBuilder.NavButton("Header/Footer (String)", () => new HeaderFooterString(), Navigation),
						GalleryBuilder.NavButton("Header/Footer (Forms View)", () => new HeaderFooterView(), Navigation),
						GalleryBuilder.NavButton("Header/Footer (Template)", () => new HeaderFooterTemplate(), Navigation),
						GalleryBuilder.NavButton("Header/Footer (Grid)", () => new HeaderFooterGrid(), Navigation),
						GalleryBuilder.NavButton("Header/Footer (Grid Horizontal)", () => new HeaderFooterGridHorizontal(), Navigation),
					}
				}
			};
		}
	}
}
