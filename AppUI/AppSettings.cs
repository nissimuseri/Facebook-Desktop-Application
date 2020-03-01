using System.IO;
using System.Reflection;
using System.Xml.Serialization;

namespace AppUI
{
    public sealed class AppSettings
    {
        public bool RememberMe { get; set; }

        public string LastAccessToken { get; set; }

        public AppSettings()
        {
            RestoreDefault();
        }

        public void SaveToFile()
        {
            using (Stream stream = new FileStream(@"AppSettings.xml", FileMode.Create))
            {
                XmlSerializer serializer = new XmlSerializer(this.GetType());
                serializer.Serialize(stream, this);
            }
        }

        public void LoadFromFile()
        {
            if (File.Exists(@"AppSettings.xml"))
            {
                using (Stream stream = new FileStream(@"AppSettings.xml", FileMode.Open))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(AppSettings));
                    AppSettings appsettingsFromFile = serializer.Deserialize(stream) as AppSettings;
                    foreach (PropertyInfo property in appsettingsFromFile.GetType().GetProperties())
                    {
                        if (property.GetSetMethod() != null)
                        {
                            this.GetType().GetProperty(property.Name).SetValue(this, property.GetValue(appsettingsFromFile, null), null);
                        }
                    }
                }
            }
            else
            {
                this.RestoreDefault();
                this.SaveToFile();
            }
        }

        public void RestoreDefault()
        {
            RememberMe = false;
            LastAccessToken = null;
        }
    }
}
