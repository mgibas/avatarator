using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Linq;

namespace Avatarator
{
    public class AbbreviationGenerator : IGenerateAvatar
    {
        public AbbreviationGenerator(IAvataratorConfig config)
        {
            this.config = config;
        }

        private IAvataratorConfig config;

        public byte[] Generate(string data, int width, int height)
        {
            var abbreviation = GetAbbreviation(data);
            var backgroundColor = config.BackgroundColors.ElementAt(abbreviation[0] % (config.BackgroundColors.Count() - 1));

            using (var bitmap = new Bitmap(width, height))
            {
                using (var graphics = Graphics.FromImage(bitmap))
                {
                    graphics.TextRenderingHint = TextRenderingHint.AntiAlias;
                    graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;

                    using (var brush = new SolidBrush(backgroundColor))
                    {
                        graphics.FillRectangle(brush, 0, 0, bitmap.Width, bitmap.Height);
                    }

                    var rectangle = new RectangleF(0, 0, width, height);
                    var stringMaxHeight = height - height * 0.1;
                    var stringMaxWidth = height - height * 0.1;
                    var format = new StringFormat { LineAlignment = StringAlignment.Center, Alignment = StringAlignment.Center };
                    var font = CalculateFont(abbreviation, stringMaxHeight, stringMaxWidth, graphics, new Font(FontFamily.GenericSansSerif, (float)height / 2, FontStyle.Bold));
                    using (var brush = new SolidBrush(Color.White))
                    {
                        graphics.DrawString(abbreviation, font, brush, rectangle, format);
                    }
                }

                ImageConverter converter = new ImageConverter();
                return (byte[])converter.ConvertTo(bitmap, typeof(byte[]));
            }
        }

        private Font CalculateFont(string text, double maxHeight, double maxWidth, Graphics graphics, Font actualFont)
        {
            var size = graphics.MeasureString(text, actualFont);
            if (size.Width > maxWidth)
                return CalculateFont(text, maxHeight, maxWidth, graphics, new Font(actualFont.FontFamily, actualFont.Size - 0.1f, actualFont.Style));
            if (size.Height > maxHeight)
                return CalculateFont(text, maxHeight, maxWidth, graphics, new Font(actualFont.FontFamily, actualFont.Size - 0.1f, actualFont.Style));
            return actualFont;
        }
        private string GetAbbreviation(string data)
        {
            var trimedData = data.Trim();

            if (trimedData.Contains(' '))
            {
                var splited = trimedData.Split(' ');
                return string.Format("{0}{1}", splited[0].ToUpper()[0], splited[1].ToUpper()[0]);
            }

            var pascalCase = trimedData;
            pascalCase = trimedData.ToUpper()[0] + pascalCase.Substring(1);
            var upperCaseOnly = string.Concat(pascalCase.Where(c => char.IsUpper(c)));
            if (upperCaseOnly.Length > 1 && upperCaseOnly.Length <= 3)
            {
                return upperCaseOnly.ToUpper();
            }

            if (trimedData.Length <= 3)
                return trimedData.ToUpper();
            return trimedData.Substring(0, 3).ToUpper();
        }
    }
}
