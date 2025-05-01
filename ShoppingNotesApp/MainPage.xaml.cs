using StockManager.Pages;
using StockManager.Services;

namespace ShoppingNotesApp
{
    public partial class MainPage : ContentPage
    {
        private readonly IStockService _stockService;
        public MainPage(IStockService stockService)
        {
            InitializeComponent();
            _stockService = stockService;
            BindingContext = this;
            NavigateToShoppingPage();
        }

        private async void NavigateToShoppingPage()
        {
            // Ensure ShoppingPage is registered in your app
            await Shell.Current.GoToAsync(nameof(ShoppingPage));
        }
    }

}
