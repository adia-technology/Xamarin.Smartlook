namespace Xamarin.Smartlook
{
    /// <summary>
    /// Represents an entry point to Smartlook client library
    /// </summary>
    public interface ISmartlook
    {
        /// <summary>
        /// Configures the Smartlook client to use a specific API key
        /// </summary>
        /// <param name="apiKey">API key to authenticate with Smartlook</param>
        void SetupWithKey(string apiKey);

        /// <summary>
        /// Starts session recording
        /// </summary>
        void StartRecording();

        /// <summary>
        /// Stops session recording
        /// </summary>
        void StopRecording();
    }
}
