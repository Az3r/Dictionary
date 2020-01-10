﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Http;
using Main.Ultilities;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Diagnostics;
using System.ComponentModel;
using Newtonsoft.Json;
using Main.API;
namespace Main.ViewModels
{
    public class MainViewModel : BindingUltility, IDisposable
    {
        public MainViewModel() 
        {
            mClient.DefaultRequestHeaders.Add("app_id", API.APIInfo.APP_ID);
            mClient.DefaultRequestHeaders.Add("app_key", API.APIInfo.APP_KEY);
            mClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            mClient.Timeout = TimeSpan.FromMilliseconds(REQUEST_TIME_OUT);
        }

        public async Task<ResponseBody> Lemmas(string word)
        {
            string jsonContent = await GetResponseString(word);
            return JsonConvert.DeserializeObject<ResponseBody>(jsonContent);
        }

        private async Task<string> GetResponseString(string word)
        {
            string query = QueryUltility.CreateLemmasQuery(word);
            try
            {
                Uri uri = new Uri(query);
                HttpResponseMessage httpResponse = await mClient.GetAsync(uri, HttpCompletionOption.ResponseContentRead);
                return httpResponse.Content.ReadAsStringAsync().Result;
            }
            catch (UriFormatException uriEx)
            {
                Trace.WriteLine(uriEx.Message);
                return null;
            }
            catch (JsonException jsonEx)
            {
                Trace.Write(jsonEx.Message);
                return null;
            }
            catch (Exception e)
            {
                Trace.Write(e.Message);
                return null;
            }
        }

        public async Task<bool> FindWordAsync(string word)
        {
            Task<bool> task = Task.Factory.StartNew(() =>
            {
                string query = QueryUltility.CreateLemmasQuery(word);
                try
                {
                    Uri uri = new Uri(query);
                    Task<HttpResponseMessage> task = mClient.GetAsync(uri, HttpCompletionOption.ResponseHeadersRead);
                    task.Wait();
                    HttpResponseMessage response = task.Result;
                    if (response.IsSuccessStatusCode) return true;
                    else return false;
                }
                catch (UriFormatException e)
                {
                    Trace.WriteLine(e.Message);
                    return false;
                }
            });

            return await task;
        }

        public void Dispose(){ if (mClient != null) mClient.Dispose(); }




#region Binding properties
        private string mResultText;
        public string ResultText
        {
            get => mResultText;
            set
            {
                mResultText = value;
                NotifyPropertyChanged();
            }
        }
#endregion

        private HttpClient mClient = new HttpClient();
        private const int REQUEST_TIME_OUT = 10000;   // 10 seconds
    }
}
