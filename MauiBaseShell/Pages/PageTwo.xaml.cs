using MauiBaseShell.ViewModels;

namespace MauiBaseShell.Pages;

public partial class PageTwo : ContentPage {

	private PageTwoViewModel _vm;

    public PageTwo(PageTwoViewModel vm) {

        InitializeComponent();
        
        _vm = vm;
        BindingContext = _vm;
    }
}