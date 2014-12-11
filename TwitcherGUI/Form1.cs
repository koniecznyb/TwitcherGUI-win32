using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
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


        private void disableButtons()
        {
            refreshButton.Enabled = false;
            playButton.Enabled = false;
        }

        private void enableButtons()
        {
            refreshButton.Enabled = true;
            playButton.Enabled = true;
        }
        public Form1()
        {

            InitializeComponent();
            _getChannelListThread = new Thread(new ThreadStart(() => _ro = getChannelList()));
            _getChannelListThread.Start();
            qualityComboBox.SelectedIndex = 0;

        }

        private void populateStreamListView()
        {
            channelsListView.Items.Clear();
            for (int i = 0; i < 20; i++)
            {
                Stream stream = _ro.streams.ElementAt(i);
                int streamViewersInt = Convert.ToInt32(stream.viewers);
                string viewers = streamViewersInt.ToString("#,000");
                string[] row = { stream.game, viewers };
                channelsListView.Items.Add(stream.channel.display_name).SubItems.AddRange(row);
            }
        }

        private RootObject getChannelList()
        {
            var streamsUri = new Uri("https://api.twitch.tv/kraken/streams");

            using (var webClient = new WebClient())
            {
            webClient.Proxy = null;
            var json = webClient.DownloadString(streamsUri);

            _ro = JsonConvert.DeserializeObject<RootObject>(json);
            }

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
           /* var channelName = channelsListView.SelectedItems[0].SubItems[0].Text;
            //channelsListView.Items.Add();


            // Prepare the process to run
            ProcessStartInfo start = new ProcessStartInfo();
            // Enter in the command line arguments, everything you would enter after the executable name itself
            start.Arguments = "livestreamer twitch.tv/imaqtpie best"; 
            // Enter the executable to run, including the complete path
            //start.FileName = @"C:\Program Files (x86)\VideoLAN\VLC\vlc.exe";
            
            System.Diagnostics.Process.Start("CMD.exe",strCmdText);
            // Do you want to show a console window?
            start.WindowStyle = ProcessWindowStyle.Hidden;
            start.CreateNoWindow = true;

            // Run the external process & wait for it to finish
            using (Process proc = Process.Start(start))
            {
                proc.WaitForExit();

                // Retrieve the app's exit code
                var exitCode = proc.ExitCode;
            }
*/
            ProcessStartInfo start = new ProcessStartInfo();

            string streamerName = channelsListView.SelectedItems[0].SubItems[0].Text;
            string quality = (string) qualityComboBox.SelectedItem;
            string strCmdText = "/C livestreamer twitch.tv/" + streamerName + " " + quality;

            start.FileName = "cmd.exe";
            start.Arguments = strCmdText;
            //start.WindowStyle = ProcessWindowStyle.Hidden;
            using (Process proc = Process.Start(start))
            {
                proc.WaitForExit();

                // Retrieve the app's exit code
                var exitCode = proc.ExitCode;
            }

        }

        private void refreshButtonClick(object sender, EventArgs e)
        {
            if(channelsListView.Items.Count == 0)
            {
                disableButtons();
                _getChannelListThread.Join();
                populateStreamListView();
                enableButtons();
            }
            else
            {
                _getChannelListThread = new Thread(new ThreadStart(() => _ro = getChannelList()));
                _getChannelListThread.Start();
                disableButtons();
                _getChannelListThread.Join();
                enableButtons();
                populateStreamListView();
            }
            

        }
    }
}
