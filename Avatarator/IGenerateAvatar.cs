namespace Avatarator
{
    public interface IGenerateAvatar
    {
        byte[] Generate(string data, int width, int height);
    }
}
