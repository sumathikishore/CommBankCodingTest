using System;
using System.IO;
using CommBankCoding.Interface;
using System.Collections.Generic;

namespace CommBankCoding.Implementation
{
    public class IOOperations :IIOOperations
    {
        public void WriteToTextFile(List<string> text, string fileName)
        {
            try
            {
                if (CreateFile(Path.Combine(Settings.Settings.OutputFolderPath, fileName)))
                {
                    using (StreamWriter outputFile = new StreamWriter(Path.Combine(Settings.Settings.OutputFolderPath, fileName)))
                    {
                        foreach (string line in text)
                            outputFile.WriteLine(line);
                    }
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
        private bool CreateFile(string fileName)
        {
            try
            {
                if (!Directory.Exists(fileName.Substring(0,fileName.LastIndexOf('\\'))))  // if it doesnt exist, create one
                    Directory.CreateDirectory(fileName.Substring(0, fileName.LastIndexOf('\\')));

                return true;
            }
            catch(Exception ex)
            {
                return false;
            }
        }
    }
}
