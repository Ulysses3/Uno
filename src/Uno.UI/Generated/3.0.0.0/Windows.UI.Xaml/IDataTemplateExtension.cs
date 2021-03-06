#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Xaml
{
	#if __ANDROID__ || __IOS__ || NET46 || __WASM__
	[global::Uno.NotImplemented]
	#endif
	public  partial interface IDataTemplateExtension 
	{
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		void ResetTemplate();
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		bool ProcessBinding( uint phase);
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		int ProcessBindings( global::Windows.UI.Xaml.Controls.ContainerContentChangingEventArgs arg);
		#endif
	}
}
