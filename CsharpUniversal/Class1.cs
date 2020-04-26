using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace CsharpUniversal
{
    public class APIMethod
    {
        public static async Task<string> JSONGet(string _fullpath)
        {
            HttpResponseMessage res = await new HttpClient().GetAsync(_fullpath);
            res.EnsureSuccessStatusCode();
            return await res.Content.ReadAsStringAsync();
        }

        public static async Task<string> JSONPost(string _fullpath, string _content)
        {
            HttpContent htc = new StringContent(_content, Encoding.UTF8, "application/json");
            HttpResponseMessage res = await new HttpClient().PostAsync(_fullpath, htc);
            res.EnsureSuccessStatusCode();
            return await res.Content.ReadAsStringAsync();
        }

        public static async Task<string> JSONPut(string _fullpath, string _content)
        {
            HttpContent htc = new StringContent(_content, Encoding.UTF8, "application/json");
            HttpResponseMessage res = await new HttpClient().PutAsync(_fullpath, htc);
            res.EnsureSuccessStatusCode();
            return await res.Content.ReadAsStringAsync();
        }

        public static async Task<string> JSONDelete(string _fullpath)
        {
            HttpResponseMessage res = await new HttpClient().DeleteAsync(_fullpath);
            res.EnsureSuccessStatusCode();
            return await res.Content.ReadAsStringAsync();
        }


        public static async Task<string> JSONPostFile(string _fullpath, FileStream _content)
        {
            HttpContent htc = new StreamContent(_content);
            HttpResponseMessage res = await new HttpClient().PostAsync(_fullpath, htc);
            res.EnsureSuccessStatusCode();
            return await res.Content.ReadAsStringAsync();
        }
    }
}