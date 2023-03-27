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
using System.Windows.Shapes;
using cost.Models;
using cost.ViewModels;
using MahApps.Metro.Controls;

namespace cost.Views
{
    /// <summary>
    /// FA.xaml 的交互逻辑
    /// </summary>
    public partial class FA : MetroWindow
    {
        public FA( table_fa products)
        {
            InitializeComponent();
            this.DataContext = new ViewModels.FaViewModel( products);
        }
    }
}
