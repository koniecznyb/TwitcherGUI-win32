using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Runtime.Remoting.Channels;
using System.Security.Authentication.ExtendedProtection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Threading;

namespace TwitcherGUI
{
    public partial class Form1 : Form
    {

        private List <Stream> channels;
        private RootObject _ro;
        private Thread _getChannelListThread;

        public Form1()
        {
            InitializeComponent();
            _getChannelListThread = new Thread(new ThreadStart(() => _ro = getChannelList()));
            _getChannelListThread.Start();
        }

        private void populateStreamListView()
        {
            channelsListView.Items.Clear();
            for (int i = 0; i < 20; i++)
            {
                Stream stream = _ro.streams.ElementAt(i);
                int streamViewersInt = Convert.ToInt32(stream.viewers);
                string streamNameAndViewers = streamViewersInt.ToString("#,000");
                string[] row = { stream.game, streamNameAndViewers };
                channelsListView.Items.Add(stream.channel.name).SubItems.AddRange(row);
            }
        }

        private RootObject getChannelList()
        {
            var streamsUri = new Uri("https://api.twitch.tv/kraken/streams");

            //using (var webClient = new WebClient())
            //{
            var webClient = new WebClient();
                var json = webClient.DownloadString(streamsUri);
                // Now parse with JSON.Net
                _ro = JsonConvert.DeserializeObject<RootObject>(json);
            //}

            return _ro;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void channelsListView_SelectedIndexChanged(object sender, EventArgs e)
        {
          
                


        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void playButtonClick(object sender, EventArgs e)
        {
            var channelName = channelsListView.SelectedItems[0].SubItems[0].Text;
            //channelsListView.Items.Add();

        }

        private void refreshButtonClick(object sender, EventArgs e)
        {
            if(channelsListView.Items.Count == 0)
            {
                _getChannelListThread.Join();
                populateStreamListView();
            }
            else
            {
                _getChannelListThread = new Thread(new ThreadStart(() => _ro = getChannelList()));
                _getChannelListThread.Start();
                refreshButton.Enabled = false;
                playButton.Enabled = false;
                _getChannelListThread.Join();
                refreshButton.Enabled = true;
                playButton.Enabled = true;
                populateStreamListView();
            }
            

        }
    }
}
