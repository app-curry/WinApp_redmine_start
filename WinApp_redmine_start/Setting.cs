using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Text.Json;
using System.Text.Json.Serialization;
using System.IO;
using System.Diagnostics;

namespace WinApp_redmine_start
{
    internal class Setting
    {
        private string _redmineInstallPath;

        /// <summary>
        /// redmineインストールディレクトリ
        /// </summary>
        public string RedmineInstallPath
        {
            get { return _redmineInstallPath; }
            set { _redmineInstallPath = value; }
        }

        public static string GetSettingFilePath()
        {
            string path = string.Empty;

            path = Environment.CurrentDirectory;
            path = Path.Combine(path, "setting.json");


            return path;
        }

        public static void Save(Setting setting)
        {
            string path = GetSettingFilePath();

            Save(setting, path);
        }

        public static void Save(Setting setting, string path)
        {
            if (!File.Exists(path))
            {
                path = GetSettingFilePath();
            }

            string json = JsonSerializer.Serialize(setting);

            File.WriteAllText(path, json);

        }

        public static Setting Load()
        {
            string path = GetSettingFilePath();

            Setting setting = Load(path);

            return setting;
        }

        public static Setting Load(string path)
        {
            Setting setting = null;

            if (!File.Exists(path))
            {
                return new Setting();
            }

            string s = File.ReadAllText(path);

            setting = JsonSerializer.Deserialize<Setting>(s);

            return setting;

        }
    }
}
