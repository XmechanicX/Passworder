using Microsoft.Win32;
using Passworder.DataBase;
using Passworder.Model;
using System.Data.Common;
using System.IO;

namespace Passworder.Instruments
{
    public class ImportExport
    {
        public ImportExport() { }

        private DataBase.DbCommand dbCommand = new DataBase.DbCommand();

        private string GetPath()
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Text files(*.csv)|*.csv|All files(*.*)|*.*";

            if (dialog.ShowDialog() == false)
                return string.Empty;

            return dialog.FileName;
        }

        public void Import()
        {
            string path = GetPath();

            using (StreamReader writer = new StreamReader(path, false))
            {
                while (!writer.EndOfStream)
                {
                    var line = writer.ReadLine();
                    var values = line.Split(',');

                    var value = new DataFilling()
                    {
                        Website = values[0],
                        Login = values[1],
                        Password = values[2]
                    };
                    //dbCommand.AddDataInDb(value);
                }
            }
        }

        public void Export()
        {
            string path = GetPath();


        }
    }
}
