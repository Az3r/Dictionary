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

namespace Main
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private const string BASE_URL = "https://od-api.oxforddictionaries.com/api/v2";
        private const string APP_ID = "5fa279e3";
        private const string APP_KEY = "f0c1503fffd8f1003c440bea6b9c5664";
        public MainWindow()
        {
            InitializeComponent();
            Style = FindResource(typeof(Window)) as Style;
        }

        private void Label_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            Keyboard.Focus(tbURL);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string word_id = "hello";
            string langCode = "en-gb";
            string fields = "pronunciations";
            string strictMatch = "false";

            string query = string.Format($"entries/{langCode}/{word_id}?fields={fields}&strictMatch={strictMatch}");
            string url = string.Join('/', BASE_URL, query);

            try
            {
                HttpClient client = new HttpClient();
                client.DefaultRequestHeaders.Add("app_id", APP_ID);
                client.DefaultRequestHeaders.Add("app_key", APP_KEY);
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                Task<HttpResponseMessage> task = client.GetAsync(url);
                task.Wait();
                HttpResponseMessage response = task.Result;
                Task<string> readStringTask = response.Content.ReadAsStringAsync();
                readStringTask.Wait();
                string content = readStringTask.Result;
                tblContent.Text = content;
            }
            catch (Exception ex)
            {
                tblContent.Text = ex.ToString();
            }

            //try
            //{
            //    var webRequest = System.Net.WebRequest.Create(url);
            //    if (webRequest != null)
            //    {
            //        webRequest.Method = "GET";
            //        webRequest.Timeout = 12000;
            //        webRequest.ContentType = "application/json";
            //        webRequest.Headers.Add("app_id", APP_ID);
            //        webRequest.Headers.Add("app_key", APP_KEY);

            //        using System.IO.Stream s = webRequest.GetResponse().GetResponseStream();
            //        using System.IO.StreamReader sr = new System.IO.StreamReader(s);
            //        var jsonResponse = sr.ReadToEnd();
            //        tblContent.Text = string.Format("Response: {0}", jsonResponse);
            //    }
            //}
            //catch (Exception ex)
            //{
            //    tblContent.Text = ex.ToString();
            //}
        }
    }
}
