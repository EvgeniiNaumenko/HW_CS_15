using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
namespace HW_15_28_06_2024
{
    internal class IPInfoData
    {
        public List<IPInfo> IPs;
        public string Path {  get; set; }
        public IPInfoData()
        {
            IPs = new List<IPInfo>();
            Path = @".\ip_date.json";
        }
        public async void GetDataFromServer(string ip)
        {
            string url = $"http://ipwho.is/{ip}";
            HttpClient client = new HttpClient();
            var respose = await client.GetAsync(url);
            if (respose.IsSuccessStatusCode)
            {
                string content = await respose.Content.ReadAsStringAsync();
                var data = JsonConvert.DeserializeObject<IPInfo>(content);
                IPs.Add(data);
            }
        }
        public void Save()
        {
            string json = JsonConvert.SerializeObject(IPs, Formatting.Indented);
            File.WriteAllText(Path, json);
        }
        public void Load()
        {
            string json = File.ReadAllText(Path);
            IPs = JsonConvert.DeserializeObject<List<IPInfo>>(json);
        }
        public void Print()
        {
            foreach (var ip in IPs)
            {
                Console.WriteLine(ip);
            }
        }
    }
}
