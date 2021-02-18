﻿using JuicySwapper.Main.Classes;
using JuicySwapper.Properties;
using System;
using System.Windows.Forms;

namespace JuicySwapper.Main.GUI
{
    public partial class Login : Form
    {
        bool _try;
        bool _hwidtry;

        public Login()
        {
            InitializeComponent();
            if (Settings.Default.MusicAct == "True")
            {
                Music MusicController = new Music();
                MusicController.MusicControl("True");
            }
        }

        private void LoginGest_Click(object sender, EventArgs e)
        {
            Settings.Default.AccVerify = "Guest";
            Settings.Default.Name = "Guest";
            Settings.Default.Save();
            Hide();
            var Home = new Home();
            Message FreeLogin = new Message(Resources.Guestlogin);
            FreeLogin.ShowDialog();
            Home.Closed += (s, args) => Close();
            Home.Show();
        }

        private void SignUp_Click(object sender, EventArgs e)
        {
            string hwid = JuicyUtilities.GET_HARDWAREID;

            MongoCRUD db = new MongoCRUD("JuicySwapper");

            if (string.IsNullOrEmpty(Username.Text) || Username.Text.Length < 3 || Username.Text == "Enter a username...")
            {
                Message userinvalid = new Message(Resources.userinvalid);
                userinvalid.ShowDialog();
                return;
            }
            if (string.IsNullOrEmpty(password.Text) || password.Text.Length < 3 || password.Text == "Enter a password...")
            {
                Message Passwordinvalid = new Message(Resources.passwordinvalid);
                Passwordinvalid.ShowDialog();
                return;
            }

            try
            {
                _try = false;
                var Usercheck = db.LoadRecordByUsername<UserModel>("Juicy", Username.Text);
            }
            catch
            {
                _try = true;
            }

            try
            {
                _hwidtry = false;
                var onerec = db.LoadRecordByHwid<UserModel>("Juicy", hwid);
            }
            catch
            {
                _hwidtry = true;
            }

            if (_try == false)
            {
                Message Userfound = new Message(Resources.Userfound);
                Userfound.ShowDialog();
                return;
            }
            if (_hwidtry == false)
            {
                Message HWIDfound = new Message(Resources.HWIDfound);
                HWIDfound.ShowDialog();
                return;
            }

            db.InsertRecord("Juicy", new UserModel
            {
                username = Username.Text,
                password = JuicyUtilities.Encrypt(password.Text),
                paid = false,
                boost = false,
                HWID = hwid
            });

            Message Account_created = new Message(Resources.Account_created);
            Account_created.ShowDialog();
        }

        private void username_Enter(object sender, EventArgs e)
        {
            Username.ResetText();
        }

        private void password_Enter(object sender, EventArgs e)
        {
            password.ResetText();
            password.isPassword = true;
        }

        private void ExitSwapper_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //todo
        [Obsolete]
        private void PaidLogin_Click(object sender, EventArgs e)
        {
            MongoCRUD db = new MongoCRUD("JuicySwapper");
            string hwid = JuicyUtilities.GET_HARDWAREID;

            //epic
            if (string.IsNullOrEmpty(Username.Text) || Username.Text.Length < 3 || Username.Text == "Enter a username...")
            {
                Message userinvalid = new Message(Resources.userinvalid);
                userinvalid.ShowDialog();
                return;
            }
            if (string.IsNullOrEmpty(password.Text) || password.Text.Length < 3 || password.Text == "Enter a password...")
            {
                Message Passwordinvalid = new Message(Resources.passwordinvalid);
                Passwordinvalid.ShowDialog();
                return;
            }

            try
            {
                _try = false;
                var Usercheck = db.LoadRecordByUsername<UserModel>("Juicy", Username.Text);
            }
            catch
            {
                _try = true;
            }

            if (_try == true)
            {
                Message Usernotfound = new Message(Resources.Usernotfound);
                Usernotfound.ShowDialog();
                return;
            }

            var onerec = db.LoadRecordByUsername<UserModel>("Juicy", Username.Text);
            if (onerec.password != JuicyUtilities.Encrypt(password.Text))
            {
                Message Passwordincorect = new Message(Resources.Passwordincorect);
                Passwordincorect.ShowDialog();
                return;
            }

            onerec = db.LoadRecordByUsername<UserModel>("Juicy", Username.Text);

            if (onerec.HWID == "Reset")
            {
                onerec.HWID = hwid;
                db.UpsertRecord("Juicy", onerec.username, onerec);
                Message hwidreset = new Message(Resources.hwidreset);
                hwidreset.ShowDialog();
                return;
            }

            if (onerec.HWID != hwid)
            {
                Message HWIDincorect = new Message(Resources.HWIDincorect);
                HWIDincorect.ShowDialog();
                return;
            }

            bool User = onerec.paid;
            if (User)
                Settings.Default.AccVerify = "Paid";
            else
                Settings.Default.AccVerify = "Free";

            Settings.Default.Name = Username.Text;
            Settings.Default.Save();

            Hide();
            var Home = new Home();
            if (User)
            {
                Message paidlogin = new Message(Resources.paidlogin);
                paidlogin.ShowDialog();
            }
            else
            {
                Message FreeLogin = new Message(Resources.freelogin);
                FreeLogin.ShowDialog();
            }
            Home.Closed += (s, args) => Close();
            Home.Show();
        }
    }
}
