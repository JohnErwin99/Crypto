using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CryptoWallet
{
    public partial class viewTxtFile : Form
    {
        string[] data = { };
        public viewTxtFile()
        {
            InitializeComponent();
            FillesAndStreams read = new FillesAndStreams();
            read.OpenDirectory();
            
            data = read.readData();
            for(int i = 0; i < data.Length; i++)
            {
                transferData.Text += data[i];
            }
            read.closeReader();
        }
    }
}
