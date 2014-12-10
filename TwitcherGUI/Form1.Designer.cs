namespace TwitcherGUI
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.channelsListView = new System.Windows.Forms.ListView();
            this.channelName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gameName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.refreshButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.playButton = new System.Windows.Forms.Button();
            this.views = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // channelsListView
            // 
            this.channelsListView.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.channelsListView.Alignment = System.Windows.Forms.ListViewAlignment.Default;
            this.channelsListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.channelsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.channelName,
            this.gameName,
            this.views});
            this.channelsListView.FullRowSelect = true;
            this.channelsListView.GridLines = true;
            this.channelsListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.channelsListView.HideSelection = false;
            this.channelsListView.Location = new System.Drawing.Point(10, 22);
            this.channelsListView.MultiSelect = false;
            this.channelsListView.Name = "channelsListView";
            this.channelsListView.Size = new System.Drawing.Size(329, 368);
            this.channelsListView.TabIndex = 1;
            this.channelsListView.UseCompatibleStateImageBehavior = false;
            this.channelsListView.View = System.Windows.Forms.View.Details;
            this.channelsListView.SelectedIndexChanged += new System.EventHandler(this.channelsListView_SelectedIndexChanged);
            // 
            // channelName
            // 
            this.channelName.Text = "Streamer";
            this.channelName.Width = 100;
            // 
            // gameName
            // 
            this.gameName.Text = "Game";
            // 
            // refreshButton
            // 
            this.refreshButton.Location = new System.Drawing.Point(155, 13);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(80, 27);
            this.refreshButton.TabIndex = 0;
            this.refreshButton.Text = "Refresh";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButtonClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.playButton);
            this.groupBox1.Controls.Add(this.refreshButton);
            this.groupBox1.Location = new System.Drawing.Point(10, 396);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(327, 46);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select game";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(6, 17);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(143, 21);
            this.comboBox1.TabIndex = 3;
            // 
            // playButton
            // 
            this.playButton.Location = new System.Drawing.Point(241, 13);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(80, 27);
            this.playButton.TabIndex = 1;
            this.playButton.Text = "Play";
            this.playButton.UseVisualStyleBackColor = true;
            this.playButton.Click += new System.EventHandler(this.playButtonClick);
            // 
            // views
            // 
            this.views.Text = "Views";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 449);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.channelsListView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.Text = "TwitcherGUI";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView channelsListView;
        private System.Windows.Forms.ColumnHeader channelName;
        private System.Windows.Forms.ColumnHeader gameName;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ColumnHeader views;

    }
}

