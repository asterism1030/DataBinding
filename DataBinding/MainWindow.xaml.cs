using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Cache;
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

namespace DataBinding
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            // 데이터 바인딩
            DataContext = Info.GetInfo();
        }

        public class Info
        {
            public string Name { get; set; }
            public string Age { get; set; }

            public static Info GetInfo()
            {
                Info info = new Info()
                {
                    Name = "khj",
                    Age = "30's"
                };
                return info;
            }
        }



    }
}
