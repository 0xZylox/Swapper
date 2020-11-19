﻿using Newtonsoft.Json;
using System;
using System.Diagnostics;
using System.Net;
using System.Windows.Forms;
using Type = JuicySwapper.Classes.Json_Api.ContentAPI.Type;

namespace JuicySwapper.Panels
{
    public partial class DashPanel : UserControl
    {
        private static DashPanel _instance;      
        public static DashPanel Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new DashPanel();
                return _instance;
            }
        }
        public DashPanel()
        {
            InitializeComponent();
        }

        private void bunifuFlatButton7_Click(object sender, System.EventArgs e)
        {
            Environment.Exit(0);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://juicyswapper.xyz");
        }

        private void DashPanel_Load(object sender, EventArgs e)
        {
            GetContent();
        }

        public void GetContent()
        {
            //Downloads JSON from Juicy Swapper API.
            var ContentAPI = new WebClient().DownloadString("http://juicyswapper.xyz/api/content.json");

            //Deserializes JSON from Juicy Swapper API.
            Type StatusResponse = JsonConvert.DeserializeObject<Type>(ContentAPI);

            //Sets Form Items from API Response.
            newsTitleLabel.Text = StatusResponse.News.NewsTitle;
            newsTextLabel.Text = StatusResponse.News.NewsText;
            newsImagePictureBox.ImageLocation = StatusResponse.News.NewsImage;
            changelogTextLabel.Text = StatusResponse.Patchnotes.PatchnotesText;
            currentVersionLabel.Text = $"Current Version: v{Application.ProductVersion}";
        }
    }
}
