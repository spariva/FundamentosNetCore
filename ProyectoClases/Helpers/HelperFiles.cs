using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoClases.Helpers
{
    public class HelperFiles
    {
        public static async Task<string> ReadFileAsync(string Path) 
        {
            FileInfo file = new FileInfo(Path);
            using(TextReader reader = file.OpenText())
            {
                string data = await reader.ReadToEndAsync();
                reader.Close();
                return data;
            }
        }

        public static async Task WriteFileAsync(string Path, string Data)
        {
            FileInfo file = new FileInfo(Path);
            using (TextWriter writer = file.CreateText())
            {
                await writer.WriteAsync(Data);
                writer.Close();
            }
        }
    }
}
