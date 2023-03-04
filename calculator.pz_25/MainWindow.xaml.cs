using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
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

namespace calculator.pz_25
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //через цикл обращаемся к каждой кнопке
            foreach(UIElement element in calculate.Children)
            {
                if(element is Button)
                {
                    ((Button)element).Click += Button_Click;
                }
            }
        }
        private void Button_Click(object sender, RoutedEventArgs e) //метод, который присваивает значения кнопкам
        {
            string str = (string)((Button)e.OriginalSource).Content;
            //условие, при котором текстовое поле будет очищаться
            if(str == "AC")
            {
                textLabel.Text = "";
            }
            //условие, при котором будет происходить математический расчет
            else if (str == "=")
            {
                string value = new DataTable().Compute(textLabel.Text, null).ToString();//
                
                textLabel.Text = value;
            }
            else //вывод цифр на текстовое поле
            {
                textLabel.Text += str; 
            }
        }
        //сделала калькулятор с помощью курсов в ютубе ^^
    }
}
