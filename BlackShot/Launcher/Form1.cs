using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using System.Threading;
using System.Windows.Forms;

namespace BlackShotLegacy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string acceptTerm = "Before proceeding with the use of this software, please read and understand the following terms:\r\n\r\n" +
                                "User Responsibility: The use of this software implies acceptance that you are solely responsible for all " +
                                "actions taken through it. This includes, but is not limited to, any content created, modified, or shared " +
                                "using the software.\r\nNo Warranties: This software is provided \"as is,\" without warranties of any kind, " +
                                "expressed or implied. There are no guarantees that the software will be error-free, secure, or suitable for " +
                                "any specific purpose.\r\nLimitation of Liability: I, developer, shall not be liable for any direct, indirect, " +
                                "incidental, consequential, or special damages arising from the use or inability to use this software. " +
                                "This includes, but is not limited to, loss of data, profits, or damage to reputation.\r\n" +
                                "Legal Compliance: You agree to use this software in compliance with all applicable laws, regulations, and policies. " +
                                "Any illegal or improper use of the software is strictly prohibited.\r\n\r\nBy clicking \"OK\" below, you indicate that " +
                                "you have read, understood, and agreed to the above terms and conditions, and that you are willing to assume full " +
                                "responsibility for the use of this software.";

            if(MessageBox.Show(acceptTerm, "Info", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
            {
                Application.Exit();
            }
            txb_user.Text = BlackShotRebirth.Properties.Settings.Default.Login;
            txb_password.Text = BlackShotRebirth.Properties.Settings.Default.Senha;
        }

        private async void btn_connect_Click(object sender, EventArgs e)
        {
            if (txb_user.Text.Length < 5 || txb_password.Text.Length < 5)
            {
                MessageBox.Show("You must provide your login and password.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (var httpClient = new HttpClient())
            {
                var tokenEndpoint = "http://host.docker.internal:8083/realms/master/protocol/openid-connect/token";
                var clientId = "blackshot-api";
                var clientSecret = "qYT42C4kEPI1YEAZdKRdruY41z7p1gHW";
                var username = txb_user.Text;
                var password = txb_password.Text;

                var requestBody = new FormUrlEncodedContent(new[]
                {
                    new KeyValuePair<string, string>("client_id", clientId),
                    new KeyValuePair<string, string>("client_secret", clientSecret),
                    new KeyValuePair<string, string>("grant_type", "password"),
                    new KeyValuePair<string, string>("username", username),
                    new KeyValuePair<string, string>("password", password)
                });

                var response = await httpClient.PostAsync(tokenEndpoint, requestBody);
                if (response.IsSuccessStatusCode)
                {
                    BlackShotRebirth.Properties.Settings.Default.Login = txb_user.Text;
                    BlackShotRebirth.Properties.Settings.Default.Senha = txb_password.Text;
                    BlackShotRebirth.Properties.Settings.Default.Save();

                    string path = Application.StartupPath + "\\system\\blackshot.exe";
                    string arguments = $"-id {txb_user.Text} -auth {txb_password.Text} -server 127.0.0.1 -Nation 1 -Language 0 -port 14000";

                    var startInfo = new ProcessStartInfo
                    {
                        FileName = path,
                        Arguments = arguments,
                        UseShellExecute = false,
                        Verb = "runas",
                        WorkingDirectory = Application.StartupPath + "\\system"
                    };

                    Process.Start(startInfo);
                    Thread.Sleep(2000);
                    Application.Exit();
                }
                else
                {
                    MessageBox.Show("The login or password entered is incorrect.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_reset_password_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Coming Soon.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btn_info_Click(object sender, EventArgs e)
        {
            Hide();
            new Form2().ShowDialog();
            Show();
        }
    }
}
