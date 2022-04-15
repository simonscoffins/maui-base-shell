using MauiBaseShell.Pages;

namespace MauiBaseShell.Configuration {

    public static class PageBuilderExtensions {

        public static MauiAppBuilder ConfigurePages(this MauiAppBuilder builder) {

            builder.Services.AddSingleton<PageOne>();
            builder.Services.AddSingleton<PageOneA>();
            builder.Services.AddSingleton<PageOneB>();

            builder.Services.AddSingleton<PageTwo>();
            builder.Services.AddSingleton<PageTwoA>();
            builder.Services.AddSingleton<PageTwoB>();

            builder.Services.AddSingleton<PageThree>();
            builder.Services.AddSingleton<PageThreeA>();
            builder.Services.AddSingleton<PageThreeB>();

            return builder;
        }

    }
}
