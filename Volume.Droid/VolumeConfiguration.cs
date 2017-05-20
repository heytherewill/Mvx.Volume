using System;
using Android.Media;
using MvvmCross.Platform.Plugins;
using static Android.Media.VolumeNotificationFlags;

namespace Volume.Droid
{
    public class VolumeConfiguration : IMvxPluginConfiguration
    {
        internal static VolumeConfiguration Default { get; } = new VolumeConfiguration(ShowUi);

        public VolumeNotificationFlags Flags { get; }

        public VolumeConfiguration(VolumeNotificationFlags flags)
        {
            Flags = flags;
        }
    }
}
