using MvvmCross.Core.ViewModels;
using Volume;

namespace Client.Core.ViewModels
{
    public class FirstViewModel : MvxViewModel
    {
        private readonly IVolumeService _volumeService;

        public FirstViewModel(IVolumeService volumeService)
        {
            _volumeService = volumeService;

            MuteCommand = new MvxCommand(MuteCommandExecute);
        }

        private int percentage = 100;
        public int Percentage
        {
            get { return percentage; }
            set
            {
                if (percentage == value) return;

                percentage = value;
                RaisePropertyChanged();

                if (percentage < 0 || percentage > 100) return;
                _volumeService.Set(percentage);
            }
        }

        public IMvxCommand MuteCommand { get; }

        private void MuteCommandExecute()
            => _volumeService.Mute();
    }
}
