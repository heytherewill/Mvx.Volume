using System.Linq;
using MediaPlayer;
using MvvmCross.Platform;
using UIKit;

namespace Volume.iOS
{
    public sealed class VolumeService : BaseVolumeService
    {
        private readonly UISlider _slider;

        internal static void Initialize()
            => Mvx.RegisterSingleton<IVolumeService>(new VolumeService());

        private VolumeService()
        {
            _slider = new MPVolumeView().Subviews.OfType<UISlider>().First();
        }
       
        protected override void NativeSet(int percentage)
            => _slider.Value = percentage / 100.0f;
    }
}