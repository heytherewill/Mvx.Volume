using System;

namespace Volume
{
    public abstract class BaseVolumeService : IVolumeService
    {
        protected abstract void NativeSet(int percentage);

        public void Mute() => Set(0);

        public void Set(int percentage)
        {
            if (percentage < 0 || percentage > 100)
                throw new ArgumentException("The value for percentage must be between 0 and 100");

            NativeSet(percentage);
        }
    }
}