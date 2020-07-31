# MobileAppTestFramework

Pointed at Xamarin examples found [here]("https://github.com/xamarin/xamarin-forms-samples").

#### .vscode/settings.json
```
{
    "dotnet-test-explorer.testProjectPath": "./src/UI.Tests"
}
```

#### iOS gotchas
Point automation at .app file - may need to run the below

```
xattr -d com.apple.quarantine [yourappnamehere].app
```



