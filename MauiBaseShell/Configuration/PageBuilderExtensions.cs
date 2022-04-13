using MauiBaseShell.Pages;

namespace MauiBaseShell.Configuration {

    public static class PageBuilderExtensions {

        public static MauiAppBuilder ConfigurePages(this MauiAppBuilder builder) {

            builder.Services.AddSingleton<PageOne>();
            builder.Services.AddSingleton<PageTwo>();
            builder.Services.AddSingleton<PageThree>();

            return builder;
        }

    }
}
