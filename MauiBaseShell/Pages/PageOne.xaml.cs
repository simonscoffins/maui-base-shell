using MauiBaseShell.ViewModels;

namespace MauiBaseShell.Pages;

public partial class PageOne : ContentPage {

	private PageOneViewModel _vm;

	public PageOne(PageOneViewModel vm) { 
		InitializeComponent();

		_vm = vm;
		BindingContext = _vm;
	}
}