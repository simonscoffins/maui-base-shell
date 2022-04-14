using MauiBaseShell.ViewModels;

namespace MauiBaseShell.Pages;

public partial class PageThree : ContentPage {

	private readonly PageThreeViewModel _vm;

    public PageThree(PageThreeViewModel vm) {

        InitializeComponent();
        _vm = vm;
        BindingContext = _vm;
    }
}