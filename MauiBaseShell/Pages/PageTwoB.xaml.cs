
using MauiBaseShell.ViewModels;

namespace MauiBaseShell.Pages;

public partial class PageTwoB : ContentPage {

	private readonly PageTwoBViewModel _vm;

    public PageTwoB(PageTwoBViewModel vm) {

        InitializeComponent();
        
        _vm = vm;
        BindingContext = _vm;
    }
}