using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WpfApp1.Data;
using WpfApp1.Data.Models;
using WpfApp1.Service;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<Word> wordsList = new List<Word>();

        public MainWindow()
        {
            InitializeComponent();
            LoadData();
        }

        public void LoadData()
        {
            var words = DbContextFactory.GetContext().Words;

            foreach (var word in words)
            {
                wordsList.Add(word);
            }
            wordsDataGrid.ItemsSource = wordsList;
        }
    }
}