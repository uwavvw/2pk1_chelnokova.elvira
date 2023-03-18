using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
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
using System.IO;
using Microsoft.Win32;

namespace pz_26._1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        public MainWindow()
        {
            InitializeComponent();
            
        }
        private void savefile_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)| *.*";
            if (saveFileDialog.ShowDialog() == true)
            {
                string filename = saveFileDialog.FileName;
                File.WriteAllText(filename, new TextRange(RTextBox.Document.ContentStart, RTextBox.Document.ContentEnd).Text);
            }
        }
        private void openfile_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.FileName = "Документ"; 
            openFileDialog.DefaultExt = ".txt"; 
            openFileDialog.Filter = "Text documents (.txt)|*.txt";            
            Nullable<bool> result = openFileDialog.ShowDialog();
            if (result == true)
            {
                string filename = openFileDialog.FileName;                
                string bebe = File.ReadAllText(filename);
                RTextBox.Document.Blocks.Clear();//очищаем ричбокс для открытия нового файла
                RTextBox.Document.Blocks.Add(new Paragraph(new Run(bebe)));
            }
        }
        private void deletefile_Click(object sender, RoutedEventArgs e)
        {
            RTextBox.Document.Blocks.Clear();   
        }
        private void newfile_Click(object sender, RoutedEventArgs e)
        {
            NewFile newFile = new NewFile();
            newFile.ShowDialog();
            
        }
        private void UpdateCursorPosition()
        {
            //int row = RTextBox.GetLineIndexFromCharacterIndex(RTextBox.CaretIndex);
            //int col = RTextBox.CaretIndex - RTextBox.GetLineIndexFromCharacterIndex(row);
            //cursorPosition.Text = $"строка: {row + 1} столбец: {col + 1}";
            
           
        }


        private void cursorPosition_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
    
}
