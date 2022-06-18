using PlusMinusMobile.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace PlusMinusMobile.Views
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