using System;
using System.Drawing;
using MonoTouch.ObjCRuntime;
using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace ChartboostBinding
{
	[BaseType (typeof (NSObject))]
	interface Chartboost {

		// Values
		[Export ("appId")]
		string AppID {get; set;} 

		[Export ("appSignature")]
		string AppSignature {get; set;}

		[Export ("delegate")]
		ChartboostDelegate Delegate {get; set;}

		[Static, Export ("sharedChartboost")]
		Chartboost SharedChartboost();

		[Export ("startSession")]
		void StartSession();

		[Export ("cacheInterstitial")]
		void CacheInterstitial();

		[Export ("cacheInterstitial:")]
		void CacheInterstitial(string location);

		[Export ("showInterstitial")]
		void ShowInterstitial();

		[Export ("showInterstitial:")]
		void ShowInterstitial(string location);

		[Export ("hasCachedInterstitial:")]
		bool HasCachedInterstitial(string location);
	}

	[BaseType (typeof (NSObject))]
	[Model]
	interface ChartboostDelegate {
		[Export ("shouldRequestInterstitial:")]
		bool ShouldRequestInterstitial(string location);

		[Export ("shouldDisplayInterstitial:")]
		bool ShouldDisplayInterstitial(string location);

		[Export ("didCacheInterstitial:")]
		void CachedInterstitial(string location);

		[Export ("didFailToLoadInterstitial:")]
		void FailedToLoadInterstitial(string location);

		[Export ("didDismissInterstitial:")]
		void DismissedInterstitial(string location);

		[Export ("didCloseInterstitial:")]
		void ClosedInterstitial(string location);

		[Export ("didClickInterstitial:")]
		void ClickedInterstitial(string location);

		[Export ("shouldDisplayLoadingViewForMoreApps")]
		bool ShouldDisplayLoadingViewForMoreApps();

		[Export ("shouldDisplayMoreApps")]
		bool ShouldDisplayMoreApps();

		[Export ("didCacheMoreApps")]
		void CachedMoreApps();

		[Export ("didFailToLoadMoreApps")]
		void FailedToLoadMoreApps();

		[Export ("didDismissMoreApps")]
		void DismissedMoreApps();
		
		[Export ("didCloseMoreApps")]
		void ClosedMoreApps();
		
		[Export ("didClickMoreApps")]
		void ClickedMoreApps();
	}
}














