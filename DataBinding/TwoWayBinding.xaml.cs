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

namespace DataBinding
{
    /// <summary>
    /// TwoWayBinding.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class TwoWayBinding : Window
    {
        Person person = new Person { Name = "khj", Age = "30" };

        public TwoWayBinding()
        {
            InitializeComponent();

            // 데이터 바인딩
            this.DataContext = person;
        }

        // 버튼 클릭 이벤트
        private void BtnClick(object sender, RoutedEventArgs e)
        {
            string msg = person.Name + " " + person.Age;
            txtBlock.Text = msg;
        }

    }

    // 바인딩 시 get, set 해줄 클래스
    public class Person
    {
        private string nameVal = "";
        private string ageVal = "";

        public string Name
        {
            get { return nameVal; }
            set { nameVal = value; }
        }

        public string Age
        {
            get { return ageVal; }
            set { ageVal = value; }
        }

    }
}
