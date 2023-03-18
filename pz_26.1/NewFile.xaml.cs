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
using System.IO;

namespace pz_26._1
{
    /// <summary>
    /// Логика взаимодействия для NewFile.xaml
    /// </summary>
    public partial class NewFile : Window
    {
        public NewFile()
        {
            InitializeComponent();
        }
        private void Accept_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = true;
            string baba = fileNameBox.Text;
            FileStream file1 = new FileStream(@"C:\Users\эля\Source\Repos\2pk1_chelnokova.elvira\pz_26.1\data\" + baba + ".txt", FileMode.CreateNew);            
        }
        public string FileName
        {
            get { return fileNameBox.Text; }
        }   
    }
}
