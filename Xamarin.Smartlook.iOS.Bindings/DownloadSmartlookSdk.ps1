$sdkUrl = "https://sdk.smartlook.com/ios/smartlook-ios-sdk-1.2.3.28.zip"
$sdkZipFile = "./smartlook-ios-sdk-1.2.3.28.zip"
Invoke-WebRequest -Uri $sdkUrl -OutFile $sdkZipFile
Expand-Archive $sdkZipFile -DestinationPath "." -Force
Remove-Item –path $sdkZipFile