namespace Xamarin.Smartlook
{
    public class SmartlookFactoryImplementation : ISmartlookFactory
    {
        public ISmartlook CreateSdk()
        {
            return new SmartlookImplementation();
        }
    }
}
