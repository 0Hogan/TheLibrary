using TheLibrary.Models;

namespace TheLibrary.Services;

public class ConfigurationSettings
{
    public ConfigurationSettings()
    {
        LoadConfigurationSettings();
    }
    
    public void LoadConfigurationSettings()
    {
        DefaultOwner = new Person("Hogan", "Michael & Kadi");
    }
    
    public Person getDefaultOwner()
    {
        if (!DefaultOwner)
        {
            return new Person("Unknown");
        }
        return DefaultOwner;
    }

    private Person DefaultOwner { get; set; }
}