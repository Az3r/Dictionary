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
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net;
using Main.ViewModels;
using Main.API;
using Main.Ultilities;
namespace Main.Views
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            DataContext = VM;
            InitializeComponent();
            Style = FindResource(typeof(Window)) as Style;
        }

        private void Label_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            Keyboard.Focus(tbWordToSearch);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string word = tbWordToSearch.Text;
            TaskScheduler scheduler = TaskScheduler.Current;
            VM.Lemmas(word).ContinueWith((task) =>
            {
                ResponseLemmas body = task.Result;
                if (body is null) VM.ResultText = "Not Found";
                else VM.ResultText = body.ToString();
            }, scheduler);
        }

        public MainViewModel VM { get; set; } = new MainViewModel();
    }
}
