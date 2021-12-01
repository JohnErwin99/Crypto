using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CryptoWallet
{
    public partial class CryptoInfoViewer : Form
    {
        private string selectedImage;
        public CryptoInfoViewer()
        {
            InitializeComponent();
            loadData();
        }

        public CryptoInfoViewer(string selectedImage)
        {
            InitializeComponent();
            this.selectedImage = selectedImage;
            loadData();

        }
        //Create dbcontext for crypto
        private CryptoWallet.CryptoEntities cryptoCbContext =
            new CryptoWallet.CryptoEntities();

        //method to laod database data
        private void loadData()
        {

            cryptoCbContext.Inventories
                .Where(data => data.Name == selectedImage)
                .Load();

            inventoryBindingSource.DataSource = cryptoCbContext.Inventories.Local;
        }

    }
}
