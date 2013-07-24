Chartboost-MonoTouch
====================

[Chartboost](https://chartboost.com) binding for MonoTouch. I decided not to implement events system, only delegates. It works well with my Xamarin application that I'm developing right now.

#Adding to your project

1. Open Chartboost-MonoTouch solution tweak it the way you want to and build it.
2. Add Chartboost.dll that you built in previous step to your project's References.
3. Add the following code to your application:

        override public bool FinishedLaunching (UIApplication uiApp, NSDictionary options) {
            base.FinishedLaunching (uiApp, options);
    
            Chartboost cb = Chartboost.SharedChartboost ();

            cb.AppID = "YOUR_APP_ID";
            cb.AppSignature = "YOUR_APP_SIGNATURE";

            cb.Delegate = new MyChartboostDelegate();

            cb.StartSession ();
    
            cb.ShowInterstitial();
        }

4. You're done!
5. Follow this article for more instructions and information about delegates: https://help.chartboost.com/documentation/ios
