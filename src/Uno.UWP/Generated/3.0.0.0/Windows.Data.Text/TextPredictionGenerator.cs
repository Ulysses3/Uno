#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Data.Text
{
	#if __ANDROID__ || __IOS__ || NET46 || __WASM__
	[global::Uno.NotImplemented]
	#endif
	public  partial class TextPredictionGenerator 
	{
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		[global::Uno.NotImplemented]
		public  bool LanguageAvailableButNotInstalled
		{
			get
			{
				throw new global::System.NotImplementedException("The member bool TextPredictionGenerator.LanguageAvailableButNotInstalled is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		[global::Uno.NotImplemented]
		public  string ResolvedLanguage
		{
			get
			{
				throw new global::System.NotImplementedException("The member string TextPredictionGenerator.ResolvedLanguage is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		[global::Uno.NotImplemented]
		public TextPredictionGenerator( string languageTag) 
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Data.Text.TextPredictionGenerator", "TextPredictionGenerator.TextPredictionGenerator(string languageTag)");
		}
		#endif
		// Forced skipping of method Windows.Data.Text.TextPredictionGenerator.TextPredictionGenerator(string)
		// Forced skipping of method Windows.Data.Text.TextPredictionGenerator.ResolvedLanguage.get
		// Forced skipping of method Windows.Data.Text.TextPredictionGenerator.LanguageAvailableButNotInstalled.get
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		[global::Uno.NotImplemented]
		public  global::Windows.Foundation.IAsyncOperation<global::System.Collections.Generic.IReadOnlyList<string>> GetCandidatesAsync( string input)
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<IReadOnlyList<string>> TextPredictionGenerator.GetCandidatesAsync(string input) is not implemented in Uno.");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		[global::Uno.NotImplemented]
		public  global::Windows.Foundation.IAsyncOperation<global::System.Collections.Generic.IReadOnlyList<string>> GetCandidatesAsync( string input,  uint maxCandidates)
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<IReadOnlyList<string>> TextPredictionGenerator.GetCandidatesAsync(string input, uint maxCandidates) is not implemented in Uno.");
		}
		#endif
	}
}
