using Passworder.Core;
using Passworder.Model;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows;

namespace Passworder.Instruments
{
    public class Serialization
    {
        public static async Task SerializationJson(List<DataFilling> data)
        {
            using (FileStream fs = new FileStream($"{ApplicationPathFiles.DataPath}\\Data.json", FileMode.OpenOrCreate))
            {
                await JsonSerializer.SerializeAsync<List<DataFilling>>(fs, data);
            }
        }

        public static List<DataFilling> DeSerializationJsonAsync()
        {
            List<DataFilling> data = new List<DataFilling>();
            try
            {
                using (FileStream fs = new FileStream($"{ApplicationPathFiles.DataPath}\\Data.json", FileMode.OpenOrCreate))
                {
                    data = JsonSerializer.Deserialize<List<DataFilling>>(fs);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"{ex}");
            }
            return data;
        }
    }
}
