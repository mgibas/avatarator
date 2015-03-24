using System.IO;

namespace Avatarator.Example
{
    class Program
    {
        static void Main(string[] args)
        {
            var generator = new AbbreviationGenerator(new AvataratorConfig());

            var avatar = generator.Generate("amy some", 100, 100);
            File.WriteAllBytes("image.png", avatar);
        }
    }
}
