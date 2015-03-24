using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace Avatarator
{
    public class AvataratorConfig : IAvataratorConfig
    {
        public AvataratorConfig()
        {
            var converter = new ColorConverter();
            BackgroundColors = new[] { (Color)converter.ConvertFromString("#1abc9c"), 
                (Color)converter.ConvertFromString("#2ecc71"), 
                (Color)converter.ConvertFromString("#3498db"), 
                (Color)converter.ConvertFromString("#9b59b6"), 
                (Color)converter.ConvertFromString("#34495e"), 
                (Color)converter.ConvertFromString("#16a085"), 
                (Color)converter.ConvertFromString("#27ae60"), 
                (Color)converter.ConvertFromString("#2980b9"), 
                (Color)converter.ConvertFromString("#8e44ad"), 
                (Color)converter.ConvertFromString("#2c3e50"), 
                (Color)converter.ConvertFromString("#f1c40f"), 
                (Color)converter.ConvertFromString("#e67e22"), 
                (Color)converter.ConvertFromString("#e74c3c"), 
                (Color)converter.ConvertFromString("#95a5a6"), 
                (Color)converter.ConvertFromString("#f39c12"), 
                (Color)converter.ConvertFromString("#d35400"), 
                (Color)converter.ConvertFromString("#c0392b"), 
                (Color)converter.ConvertFromString("#bdc3c7"), 
                (Color)converter.ConvertFromString("#7f8c8d") };
        }

        public IEnumerable<Color> BackgroundColors { get; private set; }

        public IAvataratorConfig WithBackgroundColors(IEnumerable<Color> colors)
        {
            if (colors == null || !colors.Any()) throw new ArgumentNullException("colors");
            BackgroundColors = colors;
            return this;
        }
    }
}
