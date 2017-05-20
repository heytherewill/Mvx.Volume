using System;
using MvvmCross.Platform.Plugins;

namespace Volume.Droid
{
    public class Plugin : IMvxConfigurablePlugin
    {
        private VolumeConfiguration _configuration;

        public void Configure(IMvxPluginConfiguration configuration)
        {
            if (configuration == null)
            {
                _configuration = VolumeConfiguration.Default;
                return;
            }

            var volumeConfiguration = configuration as VolumeConfiguration;
            _configuration = volumeConfiguration ?? throw new System.ArgumentException("Volume Plugin requires an instance of VolumeConfiguration");
        }

        public void Load() => VolumeService.Initialize(_configuration.Flags);
    }
}
