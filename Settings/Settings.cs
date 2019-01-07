using System.Configuration;

namespace CommBankCoding.Settings
{
    public static class Settings
    {
        public static string OutputFolderPath
        {
            get { return ConfigurationManager.AppSettings["Setting.FolderPath"]; }
        }
    }
}
