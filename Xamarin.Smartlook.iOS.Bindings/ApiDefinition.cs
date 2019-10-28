using Foundation;

namespace SmartlookSdk
{
    [BaseType(typeof(NSObject))]
    interface Smartlook
    {

    }

    [Category]
    [BaseType(typeof(Smartlook))]
    interface Smartlook_PublicInterface
    {
        [Static]
        [Export("setupWithKey:")]
        void SetupWithKey(string key);

        [Static]
        [Export("setupWithKey:options:")]
        void SetupWithKey(string key, [NullAllowed] NSDictionary<NSString, NSObject> options);

        [Static]
        [Export("startRecording")]
        void StartRecording();
    }
}
