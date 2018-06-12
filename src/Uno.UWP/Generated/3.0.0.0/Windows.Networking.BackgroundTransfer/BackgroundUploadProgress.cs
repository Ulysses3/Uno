#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Networking.BackgroundTransfer
{
	#if __ANDROID__ || __IOS__ || NET46 || __WASM__
	[global::Uno.NotImplemented]
	#endif
	public  partial struct BackgroundUploadProgress 
	{
		// Forced skipping of method Windows.Networking.BackgroundTransfer.BackgroundUploadProgress.BackgroundUploadProgress()
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		public  ulong BytesReceived;
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		public  ulong BytesSent;
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		public  ulong TotalBytesToReceive;
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		public  ulong TotalBytesToSend;
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		public  global::Windows.Networking.BackgroundTransfer.BackgroundTransferStatus Status;
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		public  bool HasResponseChanged;
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		public  bool HasRestarted;
		#endif
	}
}