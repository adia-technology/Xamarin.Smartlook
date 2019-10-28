$sdkUrl = "https://sdk.smartlook.com/ios/smartlook-ios-sdk-1.2.3.28.zip"
$sdkZipFile = "smartlook-ios-sdk-1.2.3.28.zip"
$wc = New-Object System.Net.WebClient
$wc.DownloadFile($sdkUrl, $sdkZipFile)
Expand-Archive $sdkZipFile -DestinationPath "." -Force
Remove-Item –path $sdkZipFile