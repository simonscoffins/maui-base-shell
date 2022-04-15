using MauiBaseShell.ViewModels;

namespace MauiBaseShell.Pages;

public partial class PageThreeA : ContentPage {

	private readonly PageThreeAViewModel _vm;

    public PageThreeA(PageThreeAViewModel vm) {

        InitializeComponent();
        _vm = vm;
        BindingContext = _vm;
    }
}