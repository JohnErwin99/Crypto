using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CryptoWallet
{

    internal class FillesAndStreams
    {
        DialogResult result;
        string fileName;
        private StreamWriter fileWriter;
        private StreamReader fileReader;

        public FillesAndStreams()
        {

        }

        public void chooseDirectory()
        {
            using (var fileChooser = new SaveFileDialog())
            {
                fileChooser.CheckFileExists = false;
                result = fileChooser.ShowDialog();
                fileName = fileChooser.FileName;
            }

            if(result == DialogResult.OK)
            {
                if (string.IsNullOrEmpty(fileName))
                {
                    MessageBox.Show("Invalid Filename");
                }
                else
                {
                    try
                    {
                        var output = new FileStream(fileName, FileMode.Append, FileAccess.Write);

                        fileWriter = new StreamWriter(output);
                    }catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);    
                    }              }
            }
        }

        public void OpenDirectory()
        {
            using (OpenFileDialog fileChooser = new OpenFileDialog())
            {
                fileChooser.CheckFileExists = false;
                result = fileChooser.ShowDialog();
                fileName = fileChooser.FileName;
            }

            if (result == DialogResult.OK)
            {
                if (string.IsNullOrEmpty(fileName))
                {
                    MessageBox.Show("Invalid Filename");
                }
                else
                {
                    try
                    {
                        var output = new FileStream(fileName, FileMode.Open, FileAccess.Read);

                        fileReader = new StreamReader(output);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        public void saveData(int id, string email, int amount)
        {
            if (!string.IsNullOrEmpty(email))
            {
                try
                {
                     fileWriter.WriteLine($"User ID : {id, -10}, Receiver Email : {email, -10}, " +
                    $"Amount Transfered : {amount:c, -10} ");
                }catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }   
               
            }
        }

        public string[] readData()
        {
            string[] inputFields = { };
            try
            {
                var inputRecord = fileReader.ReadLine();
                if(inputRecord != null)
                {
                    inputFields = inputRecord.Split(',');
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return inputFields;
        }

        public void closeWriter()
        {
            try {
                fileWriter.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void closeReader()
        {
            try
            {
                fileReader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }

}
