using Common.Models;

namespace Common
{
    public class SettingsStorage
    {
        private FileProvider fileProvider = new FileProvider();
        private List<Setting> settings;

        public SettingsStorage(FileProvider fileProvider)
        {
            this.fileProvider = fileProvider;
            settings = this.fileProvider.Read<Setting>();
        }

        public string Get(string key, Setting defaultSetting)
        {
            return settings.FirstOrDefault(setting => setting.Key == key, defaultSetting).Value;
        }

        public void Add(string key, string value)
        {
            settings.Add(new Setting(key, value));
        }

        public void UpdateValue(string key, string value)
        {
            var index = settings.FindIndex(setting => setting.Key == key);

            settings[index].Value = value;
        }

        public void Save()
        {
            fileProvider.Add(settings.ToArray());
        }

        public bool IsSettingExists(string key)
        {
            return settings.Exists(s => s.Key == key);
        }
    }
}
