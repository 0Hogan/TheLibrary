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
    
    public Person GetDefaultOwner()
    {
        return DefaultOwner;
    }

    public bool DevelopmentTesting { get; } = true;
    private Person DefaultOwner { get; set; } = new Person("Unknown");
}