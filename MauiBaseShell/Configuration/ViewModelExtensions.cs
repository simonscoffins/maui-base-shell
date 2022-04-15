using MauiBaseShell.ViewModels;

namespace MauiBaseShell.Configuration;

public static class ViewModelExtensions {

    public static MauiAppBuilder ConfigureViewModels(this MauiAppBuilder builder) {

        builder.Services.AddSingleton<PageOneViewModel>();
        builder.Services.AddSingleton<PageOneAViewModel>();
        builder.Services.AddSingleton<PageOneBViewModel>();

        builder.Services.AddSingleton<PageTwoViewModel>();
        builder.Services.AddSingleton<PageTwoAViewModel>();
        builder.Services.AddSingleton<PageTwoBViewModel>();

        builder.Services.AddSingleton<PageThreeViewModel>();
        builder.Services.AddSingleton<PageThreeAViewModel>();
        builder.Services.AddSingleton<PageThreeBViewModel>();

        return builder;
    }
}
