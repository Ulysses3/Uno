#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Devices.PointOfService
{
	#if __ANDROID__ || __IOS__ || NET46 || __WASM__
	[global::Uno.NotImplemented]
	#endif
	public  partial class MagneticStripeReaderStatusUpdatedEventArgs 
	{
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		[global::Uno.NotImplemented]
		public  uint ExtendedStatus
		{
			get
			{
				throw new global::System.NotImplementedException("The member uint MagneticStripeReaderStatusUpdatedEventArgs.ExtendedStatus is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		[global::Uno.NotImplemented]
		public  global::Windows.Devices.PointOfService.MagneticStripeReaderStatus Status
		{
			get
			{
				throw new global::System.NotImplementedException("The member MagneticStripeReaderStatus MagneticStripeReaderStatusUpdatedEventArgs.Status is not implemented in Uno.");
			}
		}
		#endif
		// Forced skipping of method Windows.Devices.PointOfService.MagneticStripeReaderStatusUpdatedEventArgs.Status.get
		// Forced skipping of method Windows.Devices.PointOfService.MagneticStripeReaderStatusUpdatedEventArgs.ExtendedStatus.get
	}
}
