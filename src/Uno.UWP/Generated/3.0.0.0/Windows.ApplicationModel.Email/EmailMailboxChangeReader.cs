#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.ApplicationModel.Email
{
	#if __ANDROID__ || __IOS__ || NET46 || __WASM__
	[global::Uno.NotImplemented]
	#endif
	public  partial class EmailMailboxChangeReader 
	{
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		[global::Uno.NotImplemented]
		public  void AcceptChanges()
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.ApplicationModel.Email.EmailMailboxChangeReader", "void EmailMailboxChangeReader.AcceptChanges()");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		[global::Uno.NotImplemented]
		public  void AcceptChangesThrough( global::Windows.ApplicationModel.Email.EmailMailboxChange lastChangeToAcknowledge)
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.ApplicationModel.Email.EmailMailboxChangeReader", "void EmailMailboxChangeReader.AcceptChangesThrough(EmailMailboxChange lastChangeToAcknowledge)");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		[global::Uno.NotImplemented]
		public  global::Windows.Foundation.IAsyncOperation<global::System.Collections.Generic.IReadOnlyList<global::Windows.ApplicationModel.Email.EmailMailboxChange>> ReadBatchAsync()
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<IReadOnlyList<EmailMailboxChange>> EmailMailboxChangeReader.ReadBatchAsync() is not implemented in Uno.");
		}
		#endif
	}
}
