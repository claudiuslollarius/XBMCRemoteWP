using System;
using System.Linq;

namespace XBMCRemoteWP.Helpers
{
    public class SettingsHelper
    {
        private static IsolatedStorageSettings AppSettings = IsolatedStorageSettings.ApplicationSettings;

        public static void SetValue(string key, Object value)
        {
            if (!AppSettings.Contains(key))
                AppSettings.Add(key, value);
            else
                AppSettings[key] = value;
            AppSettings.Save();
        }

        public static Object GetValue(string key)
        {
            if (AppSettings.Contains(key))
                return AppSettings[key];
            else
                return null;
        }
    }
}
