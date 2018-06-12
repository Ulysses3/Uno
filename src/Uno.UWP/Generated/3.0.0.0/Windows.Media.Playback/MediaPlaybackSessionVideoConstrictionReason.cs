#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Media.Playback
{
	#if __ANDROID__ || __IOS__ || NET46 || __WASM__
	#if __ANDROID__ || __IOS__ || NET46 || __WASM__
	[global::Uno.NotImplemented]
	#endif
	public   enum MediaPlaybackSessionVideoConstrictionReason 
	{
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		None,
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		VirtualMachine,
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		UnsupportedDisplayAdapter,
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		UnsignedDriver,
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		FrameServerEnabled,
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		OutputProtectionFailed,
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		Unknown,
		#endif
	}
	#endif
}