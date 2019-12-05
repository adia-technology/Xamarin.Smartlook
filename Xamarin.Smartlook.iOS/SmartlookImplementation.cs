namespace Xamarin.Smartlook
{
    public class SmartlookImplementation : ISmartlook
    {
        SmartlookSdk.Smartlook implementation;

        public SmartlookImplementation() 
        {
            implementation = new SmartlookSdk.Smartlook();
        }

        public void SetupWithKey(string apiKey)
        {
            SmartlookSdk.Smartlook_PublicInterface.SetupWithKey(this.implementation, apiKey);
        }

        public void StartRecording()
        {
            SmartlookSdk.Smartlook_PublicInterface.StartRecording(this.implementation);
        }

        public void StopRecording()
        {
            SmartlookSdk.Smartlook_PublicInterface.StopRecording(this.implementation);
        }
    }
}
