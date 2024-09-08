using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace ByteOrganizer
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            this.AllowDrop = true;
        }

        private void btn_organize_bytes_Click(object sender, EventArgs e)
        {
            string strTemp = txb_bytes.Text;
            strTemp = Regex.Replace(strTemp, @"\b[0-9a-fA-F]{4}\b", "");
            strTemp = Regex.Replace(strTemp, @"\b([0-9a-fA-F]{2})\b", "0x$1, ");
            strTemp = Regex.Replace(strTemp, @"\s+", "");
            strTemp = strTemp.Replace(",", ", ");

            if (strTemp.EndsWith(", "))
                strTemp = strTemp.Substring(0, strTemp.Length - 2);

            int count = 0;
            for (int i = 0; i < strTemp.Length; i++)
            {
                if (strTemp[i] == ',')
                {
                    count++;
                    if (count == 16)
                    {
                        strTemp = strTemp.Insert(i + 2, "\r\n");
                        count = 0;
                    }
                }
            }
            txb_bytes.Text = strTemp;
        }
    }
}
