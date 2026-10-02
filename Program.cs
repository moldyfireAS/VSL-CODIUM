using Avalonia;
using System;

namespace VSL_CODIUM_AVALONIA
{
    internal class Program
    {
        // Avalonia configuration, don't remove; used by previewer
        public static AppBuilder BuildAvaloniaApp()
            => AppBuilder.Configure<App>()
                         .UsePlatformDetect()
                         .LogToTrace();

        [STAThread]
        public static void Main(string[] args)
        {
            BuildAvaloniaApp()
                .StartWithClassicDesktopLifetime(args);
        }
    }
}
