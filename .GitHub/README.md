###### VERSION
------------
1.0.2

###
­

###### ALLOCATION
------------
- .NET Core 2.0
- .NET Standard 2.0
- .NET Framework 4.5
 
###
­
 
###### DESCRIPTION
------------
Service for [VisualElementsManifest](https://docs.microsoft.com/en-us/previous-versions/windows/apps/dn449733(v=win.10)).

\
--> [Unit Tests](UNIT-TESTS.md)\
--> [Change Log](CHANGE-LOG.md)\
--> [Author](AUTHOR.md) and [License](LICENSE.md)

\
--> [(0.85 USD) Cup of Coffee](https://www.paypal.me/kamilszymborski/0.85usd)

###
­

###### HOW TO USE
------------


Create:
```csharp
var Properties = new ManifestProperties();
    Properties[ManifestPropertyType.Color] = "#ffffff";
    Properties[ManifestPropertyType.Theme] = "light";
    Properties[ManifestPropertyType.LabelStatus] = "on";
    Properties[ManifestPropertyType.SmallImagePath] = "Small-Image.png";
    Properties[ManifestPropertyType.MediumImagePath] = "Medium-Image.png";

var Manifest = ManifestService.Create(Properties);
```

###
­

Parse:
```csharp
var Properties = ManifestService.Parse("Manifest");
```
###
­

Validate:
```csharp
var Valid = ManifestService.Validate("Manifest");
```