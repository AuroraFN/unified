﻿using Newtonsoft.Json;
using System.IO;
using System.Reflection;

namespace AuroraLauncher.Providers
{
    class Configuration
    {
        #region Field Region

        string _path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "Configuration.json");

        #endregion

        #region Property Region

        [JsonProperty("InstallLocation")] //required because fucking confuserex
        public string InstallLocation { get; set; }

        [JsonProperty("Arguments")]
        public string Arguments { get; set; }

        [JsonProperty("Email")]
        public string Email { get; set; }
        [JsonProperty("Password")]
        public string Password { get; set; }

        [JsonProperty("DarkMode")]
        public bool DarkMode { get; set; }

        [JsonProperty("DisableOnline")]
        public bool DisableOnline { get; set; }

        #endregion

        #region Method Region

        // TODO: Add configuration file to Build.cs.
        public void Open()
        {
            if (File.Exists(_path))
            {
                var configuration = JsonConvert.DeserializeObject<Configuration>(File.ReadAllText(_path));

                // Load all variables, etc...
                InstallLocation = configuration.InstallLocation;

                Arguments = configuration.Arguments;

                Email = configuration.Email;
                Password = configuration.Password;

                DarkMode = configuration.DarkMode;

                DisableOnline = configuration.DisableOnline;
            }
            else
            {
                foreach (EpicGames.Installed.Installation installation
                    in EpicGames.LauncherInstalled.InstallationList)
                {
                    if (installation.AppName == "Fortnite")
                        InstallLocation = installation.InstallLocation;
                }

                DarkMode = true;

                Save();
            }
        }

        public void Save() => File.WriteAllText(_path, JsonConvert.SerializeObject(this));

        #endregion
    }
}
