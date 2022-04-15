using MauiBaseShell.ViewModels;

namespace MauiBaseShell.Pages;

public partial class PageThreeB : ContentPage {

	private readonly PageThreeBViewModel _vm;

    public PageThreeB(PageThreeBViewModel vm) {

        InitializeComponent();
        _vm = vm;
        BindingContext = _vm;
    }
}