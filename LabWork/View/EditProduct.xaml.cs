using LabWork.Model;
using LabWork.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace LabWork.View
{
    /// <summary>
    /// Логика взаимодействия для EditProduct.xaml
    /// </summary>
    public partial class EditProduct : Window
    {
        public EditProduct(Product productToEdit)
        {
            InitializeComponent();
            DataContext = new DataManageVM();
            DataManageVM.SelectedProduct = productToEdit;
            DataManageVM.ProductName = productToEdit.Name;
            DataManageVM.ProductPrice = productToEdit.Price;
            DataManageVM.ProductDesc = productToEdit.Desc;


        }

        private void CancelEdit_btn_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
