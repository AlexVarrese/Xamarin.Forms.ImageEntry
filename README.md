# Xamarin.Forms.ImageEntry

Use images in your entrys
 
###### This is the component, works on iOS, Android.

UWP coming soon
 
 **NuGet**

|Name|Info|
| ------------------- | :------------------: |
|ImageEntry|[![NuGet](https://img.shields.io/badge/nuget-1.0.7-blue.svg)](https://www.nuget.org/packages/Xamarin.Forms.ImageEntry/)|

**Platform Support**

ImageEntry is a .NET Standard 2.0 library.Its only dependency is the Xamarin.Forms

## Setup / Usage

Install the package on all projects.

iOS, in AppDelegate on FinishedLaunching start control  Xamarin.Forms.ImageEntry.ImageEntryRenderer.Init(); :

```csharp
   public override bool FinishedLaunching(UIApplication app, NSDictionary options)
   {
     global::Xamarin.Forms.Forms.Init();

     Xamarin.Forms.ImageEntry.ImageEntryRenderer.Init();

     LoadApplication(new App());

     return base.FinishedLaunching(app, options);
   }
```


