namespace Volume
{
    public interface IVolumeService
    {
        void Mute();

        void Increase();

        void Decrease();

        void Set(int percentage);
    }
}