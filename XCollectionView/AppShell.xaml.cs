using System;
using System.Collections.Generic;
using Xamarin.Forms;
using XCollectionView.ViewModels;
using XCollectionView.Views;

namespace XCollectionView
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
        }

    }
}
