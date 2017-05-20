using Android.Content;
using Android.Media;
using MvvmCross.Platform;
using MvvmCross.Platform.Droid;

namespace Volume.Droid
{
    public sealed class VolumeService : BaseVolumeService
    {
        private readonly VolumeNotificationFlags _notificationFlags;

        internal static void Initialize(VolumeNotificationFlags notificationFlags)
            => Mvx.RegisterSingleton<IVolumeService>(new VolumeService(notificationFlags));

        private VolumeService(VolumeNotificationFlags notificationFlags)
        {
            _notificationFlags = notificationFlags;
        }

        protected override void NativeSet(int percentage)
        {
            var context = Mvx.Resolve<IMvxAndroidGlobals>().ApplicationContext;
            var audioManager = context.GetSystemService(Context.AudioService) as AudioManager;
            var maxVolume = audioManager.GetStreamMaxVolume(Stream.Music);
            var volume = (maxVolume / 100.0f) * percentage;
            audioManager.SetStreamVolume(Stream.Music, (int)volume, _notificationFlags);
        }
    }
}