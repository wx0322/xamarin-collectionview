using System.ComponentModel;
using Xamarin.Forms;
using XCollectionView.ViewModels;

namespace XCollectionView.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}