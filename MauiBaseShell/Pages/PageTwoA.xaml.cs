
using MauiBaseShell.ViewModels;

namespace MauiBaseShell.Pages;

public partial class PageTwoA : ContentPage {

	private readonly PageTwoAViewModel _vm;

    public PageTwoA(PageTwoAViewModel vm) {

        InitializeComponent();
        
        _vm = vm;
        BindingContext = _vm;
    }
}