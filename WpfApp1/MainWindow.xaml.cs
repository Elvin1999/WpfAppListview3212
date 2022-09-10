using System;
using System.Collections.Generic;
using System.IO;
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
using WpfApp1.Models;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<Book> Books { get; set; } = new List<Book>
        {
            new Book
            {
                Id=1,
                Author="Fyodor Dostoyevski",
                Genre="Criminal",
                Pages=800,
                Publisher="BAKU INC",
                Title="Crime And Punishment",
                ImagePath="Images/image1.jpg"
            },
            new Book
            {
                Id=1,
                Author="Napolion Hill",
                Genre="Self Improvement",
                Pages=600,
                Publisher="BAKU INC",
                Title="Think and Grow Rich",
                ImagePath="Images/image2.jpg"
            },
            new Book
            {
                Id=1,
                Author="Robert Kiyosoki",
                Genre="Self Improvement",
                Pages=300,
                Publisher="BAKU INC",
                Title="Rich Dad ,Poor Dad",
                ImagePath="Images/image3.jpg"
            },
        };

        public  void DirSearch(string sDir)
        {
            try
            {

            foreach (var directory in Directory.GetDirectories(sDir))
            {
                var treeViewItem = new TreeViewItem();
                treeViewItem.Header = Directory.GetParent(directory).Name;
                foreach (var filename in Directory.GetFiles(directory))
                {

                    treeViewItem.Items.Add(new TreeViewItem
                    {
                        Header = filename,
                    });
                       
                }

                DirSearch(directory);
                //mytree.Items.Add(treeViewItem);
            }
            }
            catch
            {

            }
        }

        public MainWindow()
        {
            InitializeComponent();
            //this.listview.ItemsSource = Books;

            DirSearch(@"C:\Users\e.camalzade");



            this.DataContext = this;
        }

        private void listview_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
           // var book = listview.SelectedItem as Book;
            //MessageBox.Show(book.Title);
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            //mygrid.Background = Brushes.Red;
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {

            //mygrid.Background = Brushes.DeepSkyBlue;
        }

        private void MenuItem_Click_2(object sender, RoutedEventArgs e)
        {

            //mygrid.Background = Brushes.LimeGreen;
        }
    }
}
