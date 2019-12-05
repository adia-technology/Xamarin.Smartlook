namespace Xamarin.Smartlook
{
    public class SmartlookImplementation : ISmartlook
    {
        public void SetupWithKey(string apiKey)
        {
            Com.Smartlook.Sdk.Smartlook.Smartlook.Setup(apiKey);
        }

        public void StartRecording()
        {
            Com.Smartlook.Sdk.Smartlook.Smartlook.StartRecording();
        }

        public void StopRecording()
        {
            Com.Smartlook.Sdk.Smartlook.Smartlook.StopRecording();
        }
    }
}
