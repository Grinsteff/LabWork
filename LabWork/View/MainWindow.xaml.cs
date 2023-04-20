using LabWork.ViewModel;
using ModernWpf.Controls;
using System.Windows;
using System.Windows.Controls;

namespace LabWork.View
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static System.Windows.Controls.ListView AllProductsView;
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new DataManageVM();
            AllProductsView = ViewAllProducts;
        }
    }
}
