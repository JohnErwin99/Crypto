using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoWallet
{
    internal class FileOperation
    {
        public string FileName { get; set; }
        public FileOperation(string filename)
        {
            FileName = filename;
        }

        private void openFile(string filename)
        {

        }
        private void readFile(string filename)
        {
            const Int32 BufferSize = 128;
            using (var fileStream = File.OpenRead(filename))
            using (var streamReader = new StreamReader(fileStream, Encoding.UTF8, true, BufferSize))
            {
                String line;
                while ((line = streamReader.ReadLine()) != null)
                {
                    //read txtfile containin crypto name
                    //nvm use this for later ,maybe for reading transaction after writing them in a file
                }
            }
        }
        private void writeToFile(string filename)
        {

        }
    }
}
