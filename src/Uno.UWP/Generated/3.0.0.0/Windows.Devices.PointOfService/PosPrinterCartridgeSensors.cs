#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Devices.PointOfService
{
	#if __ANDROID__ || __IOS__ || NET46 || __WASM__
	#if __ANDROID__ || __IOS__ || NET46 || __WASM__
	[global::Uno.NotImplemented]
	#endif
	public   enum PosPrinterCartridgeSensors 
	{
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		None,
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		Removed,
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		Empty,
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		HeadCleaning,
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		NearEnd,
		#endif
	}
	#endif
}
