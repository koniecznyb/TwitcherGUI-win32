using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Security.Authentication.ExtendedProtection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace TwitcherGUI
{
    public partial class Form1 : Form
    {

        private RootObject getChannelList()
        {
            var streamsUri = new Uri("https://api.twitch.tv/kraken/streams");
            RootObject ro;

            using (var webClient = new WebClient())
            {
                var json = webClient.DownloadString(streamsUri);
                // Now parse with JSON.Net
                ro = JsonConvert.DeserializeObject<RootObject>(json);
            }

            return ro;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RootObject ro = getChannelList();

            for (int i = 0; i < 20; i++)
            {
                Stream stream = ro.streams.ElementAt(i);
                int streamViewersInt = Convert.ToInt32(stream.viewers);
                string streamViewers = streamViewersInt.ToString("#,000");
                string[] row = { stream.game, streamViewers };
                channelsListView.Items.Add(stream.channel.name).SubItems.AddRange(row);
            }

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        // 100 000
        // 

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void channelsListView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
