using System;
using System.Windows.Forms;

namespace BlackShotLegacy
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Changelog("1.0.0 - Authentication Mapping");
            Changelog("1.0.1 - Server tab mapping");
            Changelog("1.0.2 - Lobby Mapping");
            Changelog("1.0.3 - Weapon Mapping");
            Changelog("1.0.4 - Account creation");
            Changelog("1.0.5 - User accounts now managed by Keycloak");
            Changelog("1.0.6 - Added email account recovery");
        }

        private void Changelog(string text)
        {
            foreverTextBox1.Text += text + Environment.NewLine;
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
