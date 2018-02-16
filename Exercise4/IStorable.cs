namespace Interfaces
{
    public interface IStorable
    {
        void Read(string content);
        void Write(IStorable str);
    }
}