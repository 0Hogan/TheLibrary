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
        return DefaultOwner;
    }

    private Person DefaultOwner { get; set; } = new Person("Unknown");
}