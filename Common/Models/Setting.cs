namespace Common.Models
{
    public class Setting
    {
        public string Key;
        public string Value;

        public Setting() { }

        public Setting(string key, string value)
        {
            Key = key;
            Value = value;
        }
    }
}
