using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Passworder.Core
{
    public static class Initialization
    {
        public static void InitPathDirectory()
        {
            if (!Directory.Exists(ApplicationPathFiles.AppDataPath))
            {
                Directory.CreateDirectory(ApplicationPathFiles.AppDataPath);
            }
            if (!Directory.Exists(ApplicationPathFiles.DataPath))
            {
                Directory.CreateDirectory(ApplicationPathFiles.DataPath);
            }
        }
        
    }

    public class ApplicationPathFiles
    {
        public static readonly string AppDataPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Passworder");

        public static string DataPath
        {
            get => Path.Combine(AppDataPath, "Data");
        }
    }
}
