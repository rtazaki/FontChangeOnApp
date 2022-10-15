using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace FontChangeOnApp
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public App()
        {
            // WindowやPage毎にスタイルを追加する必要がある。
            Action<FontFamily, double, Type> style = (font, size, type) =>
            {
                var style = new Style(type);
                style.Setters.Add(new Setter(Control.FontFamilyProperty, font));
                style.Setters.Add(new Setter(Control.FontSizeProperty, size));
                FrameworkElement.StyleProperty.OverrideMetadata(
                    type, new FrameworkPropertyMetadata(style));
            };
            style(new FontFamily("MS Gothic"), 42.0, typeof(Window));
            style(new FontFamily("HGP創英角ﾎﾟｯﾌﾟ体"), 24.0, typeof(Page));
        }
    }
}
