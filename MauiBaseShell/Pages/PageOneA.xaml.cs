using MauiBaseShell.ViewModels;

namespace MauiBaseShell.Pages;

public partial class PageOneA : ContentPage {

	private readonly PageOneAViewModel _vm;

	public PageOneA(PageOneAViewModel vm) { 

		InitializeComponent();

		_vm = vm;
		BindingContext = _vm;
	}
}