using MvvmCross.Platform.Plugins;

namespace Volume.iOS
{
    public class Plugin : IMvxPlugin
    {
        public void Load() => VolumeService.Initialize();
    }
}