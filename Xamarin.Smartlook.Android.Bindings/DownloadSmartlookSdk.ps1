if (!(Test-Path -Path "./Jars" )) {
    New-Item -ItemType directory -Path "./Jars"
}
Invoke-WebRequest -Uri "https://sdk.smartlook.com/android/release/com/smartlook/recording/app/1.1.5-native/app-1.1.5-native.aar" -OutFile "./Jars/smartlook-1.1.5-native.aar"