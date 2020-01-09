using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Http;
using Main.Ultilities;
using System.Net.Http.Headers;

namespace Main.ViewModels
{
    public class MainViewModel : BindingUltility
    {
        public MainViewModel() 
        {
            mClient.DefaultRequestHeaders.Add("app_id", API.API.APP_ID);
            mClient.DefaultRequestHeaders.Add("app_key", API.API.APP_KEY);
            mClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public void FindWord(string word)
        {

        }




        #region Binding properties
        private string mText;
        public string Text
        {
            get => mText;
            set
            {
                mText = value;
                NotifyPropertyChanged();
            }
        }
        #endregion

        private HttpClient mClient = new HttpClient();
    }
}
