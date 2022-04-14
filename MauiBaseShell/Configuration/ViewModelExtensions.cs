using MauiBaseShell.ViewModels;

namespace MauiBaseShell.Configuration;

public static class ViewModelExtensions {

    public static MauiAppBuilder ConfigureViewModels(this MauiAppBuilder builder) {

        builder.Services.AddSingleton<PageOneViewModel>();
        builder.Services.AddSingleton<PageTwoViewModel>();
        builder.Services.AddSingleton<PageThreeViewModel>();

        return builder;
    }
}
