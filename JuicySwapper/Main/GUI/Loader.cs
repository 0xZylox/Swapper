﻿using DiscordRPC;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using JuicySwapper.Main.Classes;

namespace JuicySwapper.Main.GUI
{
    public partial class Loader : Form
    {
        public byte holder = 0;
        public DiscordRpcClient discordRpcClient_0 = new DiscordRpcClient("704324460291031047");
        public Loader()
        {
            Juicy.discordrpc.Initialize();
            Juicy.SetDiscordAction("Loading Swapper...");
            InitializeComponent();
            Juicy.CloseEpicProcesses();
            Juicy.DiscordInvite();
            SwapUtilities.Requestoffsets();
            //SwapUtilities.RequestPaks();
            Juicy.FindPaks();
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            holder += 4;
            var adv = new List<string> { ".", "..", "..." };
            Random random = new Random();
            int i = random.Next(adv.Count);
            string strg = adv[i];
            label1.Text = "Getting data from Juicy's API" + strg;
            label2.Text = holder + "%";
            if (holder == 100)
            {
                timer1.Enabled = false;
                Hide();
                var Open = new Home();
                Open.Closed += (s, args) => Close();
                Open.Show();
            };
        }
    }
}
