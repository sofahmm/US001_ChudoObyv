using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using US001_ChudoObyv.DbConnection;

namespace US001_ChudoObyv.Pages
{
    /// <summary>
    /// Логика взаимодействия для ProductListPage.xaml
    /// </summary>
    public partial class ProductListPage : Page
    {
        public static List<Product> products { get; set; }
        public static List<Size_Product> sizesPr { get; set; }
        public static string Res;
        public ProductListPage()
        {
            InitializeComponent();
            products = new List<Product>(ConnectionString.obyvEntities.Product.ToList());
            sizesPr = new List<Size_Product>(ConnectionString.obyvEntities.Size_Product.ToList());
            foreach (var product in products)
            {
                if(Convert.ToInt32(sizesPr.Count(i => i.IdProduct == product.Id)) > 5)
                        Res = "Мало";
            }

            

            this.DataContext = this;
        }
    }
}
