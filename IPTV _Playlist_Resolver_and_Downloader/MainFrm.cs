using m3uParser;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Cache;
using System.Net.Http;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace IPTV__Playlist_Resolver_and_Downloader
{
    public partial class MainFrm : Form
    {
        public MainFrm()
        {
            InitializeComponent();
        }

        public List<string[]> parsedm3ucontent = new List<string[]>();
        public string m3ucontent;
        public int limit;

        private void btnm3udownload_Click(object sender, EventArgs e)
        {
            download_M3U(txtm3ulink.Text);
        }

        private void download_M3U(string url)
        {
            using (WebClient wc = new WebClient())
            {
                wc.DownloadDataCompleted += (sender, e) =>
                {
                    pbDownload.Value = pbDownload.Maximum;
                    m3ucontent = Encoding.UTF8.GetString(e.Result);
                    MessageBox.Show("Playlist imported and parsing. Please Wait!");
                    parseContent(m3ucontent);
                };

                wc.DownloadProgressChanged += (sender, e) =>
                {
                    pbDownload.Value = e.ProgressPercentage;
                };

                wc.DownloadDataAsync(
                    new Uri(txtm3ulink.Text)
                );
            }
        }

        public void parseContent(string m3ucontent)
        {
            pbDownload.Value = 0;
            _ = Task.Run(() =>
            {
                parsedm3ucontent.Clear();

                var m3uparsed = M3U.Parse(m3ucontent);
                
                int first = 0;
                int last = m3uparsed.Medias.Count(); 
                foreach (var m3uline in m3uparsed.Medias)
                {
                    string[] line = { m3uline.Attributes.GroupTitle, m3uline.Title.InnerTitle, m3uline.MediaFile };
                    parsedm3ucontent.Add(line);
                    this.Invoke((MethodInvoker)delegate
                    {
                        pbDownload.Value = (int)((first * 100) / last);
                    });
                    first++;
                }

                this.Invoke((MethodInvoker)delegate
                {
                    pbDownload.Value = pbDownload.Maximum;
                    filllistview();
                });
            });
        }

        private void filllistview()
        {
            lvwContent.Items.Clear();
            for (int i = 0; i < 100; i++)
            {
                ListViewItem item = new ListViewItem(parsedm3ucontent[i]);
                lvwContent.Items.Add(item);
            }
        }

        private void btnSearchName_Click(object sender, EventArgs e)
        {
            string searchingText = txtSearch.Text;

            var items = parsedm3ucontent.FindAll(x => x[1].ToLower().Contains(searchingText.ToLower()));

            lvwContent.Items.Clear();
            limit = items.Count > 100 ? 100 : items.Count;

            for (int i = 0; i < limit; i++)
            {
                lvwContent.Items.Add(new ListViewItem(items[i]));
            }
        }

        private void btnSearchGroup_Click(object sender, EventArgs e)
        {
            string searchingText = txtSearch.Text;

            var items = parsedm3ucontent.FindAll(x => x[0].ToLower().Contains(searchingText.ToLower()));

            lvwContent.Items.Clear();
            limit = items.Count > 100 ? 100 : items.Count;

            for (int i = 0; i < limit; i++)
            {
                lvwContent.Items.Add(new ListViewItem(items[i]));
            }
        }
        private void btnResetFilter_Click(object sender, EventArgs e)
        {
            filllistview();
        }

        private void btnMovieDownload_Click(object sender, EventArgs e)
        {
            if(lvwContent.SelectedItems.Count != 1)
            {
                MessageBox.Show("Choose a content to download!");
                return;
            }

            var content = parsedm3ucontent.Find(x => x[1] == lvwContent.SelectedItems[0].SubItems[1].Text);


            if(saveFile.ShowDialog() == DialogResult.OK)
            {
                downloadContent(content[2],saveFile.FileName);
            }
        }

        private void downloadContent(string contenturl, string savePath)
        {
            DateTime _startedAt = new DateTime();

            using (WebClient wc = new WebClient())
            {
                wc.DownloadFileCompleted += (sender, e) =>
                {
                    MessageBox.Show("Content Downloaded!");
                };

                wc.DownloadProgressChanged += (sender, e) =>
                {
                    pbDownload.Value = e.ProgressPercentage;
                    if (_startedAt == default(DateTime))
                    {
                        _startedAt = DateTime.Now;
                    }
                    else
                    {
                        var timeSpan = DateTime.Now - _startedAt;
                        if (timeSpan.TotalSeconds >= 1)
                        {
                            var bytesPerSecond = e.BytesReceived / (long)timeSpan.TotalSeconds;
                            lblDownloadSpeed.Text = (bytesPerSecond / (1024 * 1024)).ToString() + " Mb/s";
                            TimeSpan time = TimeSpan.FromSeconds((e.TotalBytesToReceive - e.BytesReceived) / bytesPerSecond);

                            string remaningTime = time.ToString(@"mm\:ss");
                            lblRemainingTime.Text = remaningTime;
                        }
                    }
                };

                wc.DownloadFileAsync(
                    new Uri(contenturl),
                    savePath
                );

            }
        }
    }
}
