using System.IO;

namespace Avatarator.Example
{
    class Program
    {
        static void Main(string[] args)
        {
            var generator = new AbbreviationGenerator(new AvataratorConfig());

            var avatar = generator.Generate("8@8.pl", 200, 200);
            File.WriteAllBytes("image.png", avatar);
        }
    }
}
