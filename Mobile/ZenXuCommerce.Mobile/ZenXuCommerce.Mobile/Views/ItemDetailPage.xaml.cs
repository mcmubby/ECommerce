using System.ComponentModel;
using Xamarin.Forms;
using ZenXuCommerce.Mobile.ViewModels;

namespace ZenXuCommerce.Mobile.Views
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