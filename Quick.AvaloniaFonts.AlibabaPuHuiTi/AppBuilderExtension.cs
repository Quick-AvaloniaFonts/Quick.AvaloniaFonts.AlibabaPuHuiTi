using Avalonia.Media;

namespace Avalonia;

public static class AppBuilderExtension
{
    public static AppBuilder WithFont_AlibabaPuHuiTi(this AppBuilder appBuilder)
    {
        var uri = "avares://Quick.AvaloniaFonts.AlibabaPuHuiTi/Assets/Fonts#Alibaba PuHuiTi";
        return appBuilder.With(new FontManagerOptions()
        {
            DefaultFamilyName = uri,
            FontFallbacks = new[] { new FontFallback { FontFamily = new FontFamily(uri) } }
        });
    }
}