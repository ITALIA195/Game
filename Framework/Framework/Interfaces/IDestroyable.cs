namespace Framework
{
    public interface IDestroyable
    {
        bool IsDestroyed { get; }
        void Destroy();
    }
}