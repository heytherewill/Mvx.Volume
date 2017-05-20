using Android.Content;
using Android.Media;
using MvvmCross.Platform;
using MvvmCross.Platform.Droid;

namespace Volume
{
    public sealed class VolumeService : BaseVolumeService
    {
        internal static void Initialize()
            => Mvx.RegisterSingleton<IVolumeService>(new VolumeService());

        private VolumeService() { }

        protected override void NativeSet(int percentage)
        {
            var context = Mvx.Resolve<IMvxAndroidGlobals>().ApplicationContext;
            var audioManager = context.GetSystemService(Context.AudioService) as AudioManager;

            var maxVolume = audioManager.GetStreamMaxVolume(Stream.Music);
            audioManager.SetStreamVolume(Stream.Music, maxVolume, VolumeNotificationFlags.ShowUi);
        }
    }
}