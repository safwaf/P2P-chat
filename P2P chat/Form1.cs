using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P2P_chat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private byte[] ByteString(string s)
        {
            char[] c = s.ToCharArray();
            byte[] b = null;
            int l = s.Length;
            for (int i=0;i<l;i++)
            {
                b[i] = (byte)c[i];
            }
            return b;
        }

        private void SendButton_Click(object sender, EventArgs e)
        {

        }
    }
}
