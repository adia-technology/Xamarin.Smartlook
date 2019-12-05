namespace Xamarin.Smartlook
{
    /// <summary>
    /// Represents an abstract factory of Smartlook clients
    /// </summary>
    public interface ISmartlookFactory
    {
        /// <summary>
        /// Creates a new instance of platform-specific Smartlook client
        /// </summary>
        /// <returns></returns>
        ISmartlook CreateSdk();
    }
}
