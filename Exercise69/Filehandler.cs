using System.Collections.Generic;
using System.IO;

namespace Exercise69
{
    public class Filehandler
    {
        public void WriteFile(string filepath, string filename, List<int> intList)
        {
            using (StreamWriter streamWriter = new StreamWriter(filepath+filename))
            {
                foreach (var VARIABLE in intList)
                {
                    streamWriter.WriteLine(VARIABLE);
                }
            }
        }
    }
}