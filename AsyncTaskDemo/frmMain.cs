using System.Diagnostics;
using System.Net;

namespace AsyncTaskDemo
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnSyncOperation_Click(object sender, EventArgs e)
        {
            //clear the listbox
            lstData.Items.Clear();

            var sw = new Stopwatch();
            sw.Start();

            GetWebsiteDataSync();

            sw.Stop();
            lstData.Items.Add("---------------------------------------------");
            lstData.Items.Add($"The total execution in Sync mode: {sw.ElapsedMilliseconds} milliseconds");
        }

        private async void btnAsync_Click(object sender, EventArgs e)
        {
            //clear the listbox
            lstData.Items.Clear();

            var sw = new Stopwatch();
            sw.Start();

            await GetWebsiteDataAsync(); //comment the await keyword and see what happens--> fire and forget happens

            //await GetWebsiteDataParallelAsync();

            sw.Stop();
            lstData.Items.Add("---------------------------------------------");
            lstData.Items.Add($"The total execution in Async mode: {sw.ElapsedMilliseconds} milliseconds");
        }

        private List<string> GetDataSources()
        {
            return new List<string>
            {
                "https://www.google.com",
                "https://www.bing.com",
                "https://www.microsoft.com",
                "https://www.c-sharpcorner.com",
                "https://www.yahoo.com",
                "https://www.cnn.com"
            };
        }

        private WebsiteDataModel DownloadWebsite(string url)
        {
            var dataModel = new WebsiteDataModel();
            dataModel.Url = url;

            using (var client = new HttpClient())
            {
                //makes this run synchronously
                dataModel.Data = client.GetStringAsync(url).Result;

                //This is just to make the process longer
                Thread.Sleep(100);
            }

            return dataModel;
        }

        private void PopulateWebsiteInfoToUi(WebsiteDataModel dataModel)
        {
            lstData.Items.Add($"{dataModel.Url} downloaded {dataModel.Data.Length} characters long");
        }

        private void GetWebsiteDataSync()
        {
            var sites = GetDataSources();
            foreach (var site in sites)
            {
                var datamodel = DownloadWebsite(site);
                PopulateWebsiteInfoToUi(datamodel);
            }
        }

        #region AsyncSection

        private async Task GetWebsiteDataAsync()
        {
            var sites = GetDataSources();
            foreach (var site in sites)
            {
                var datamodel = await Task.Run(()=> DownloadWebsite(site));
                PopulateWebsiteInfoToUi(datamodel);
            }
        }

        private async Task GetWebsiteDataParallelAsync()
        {
            var sites = GetDataSources();
            List<Task<WebsiteDataModel>> tasks = new List<Task<WebsiteDataModel>>();

            foreach (var site in sites)
            {
                tasks.Add(Task.Run(()=>DownloadWebsite(site)));
            }

            var results = await Task.WhenAll(tasks);

            foreach (var item in results)
            {
                PopulateWebsiteInfoToUi(item);
            }
        }

        #endregion
    }
}