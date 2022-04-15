using MauiBaseShell.ViewModels;

namespace MauiBaseShell.Pages;

public partial class PageOneB : ContentPage {

	private readonly PageOneBViewModel _vm;

	public PageOneB(PageOneBViewModel vm) { 

		InitializeComponent();

		_vm = vm;
		BindingContext = _vm;
	}
}