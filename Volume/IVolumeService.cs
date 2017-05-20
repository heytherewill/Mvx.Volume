namespace Volume
{
    public interface IVolumeService
    {
        void Mute();

        void Set(int percentage);
    }
}