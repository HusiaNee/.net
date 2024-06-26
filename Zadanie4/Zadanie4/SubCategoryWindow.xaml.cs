using System.Windows;

namespace Zadanie4
{
    public partial class SubCategoryWindow : Window
    {
        public SubCategoryWindow(SubCategory subCategory)
        {
            InitializeComponent();
            SubCategoryDescription.Text = subCategory.Description;
            ParentCompanyText.Text = $"Koncern: {subCategory.ParentCompany}";
            FoundedText.Text = $"Data powstania: {subCategory.Founded}";
            CountriesText.Text = $"Kraje produkcji: {subCategory.Countries}";
            ElementDataGrid.ItemsSource = subCategory.Elements;
        }
    }
}
