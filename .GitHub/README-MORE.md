###### VERSION
------------
2.0.0

###
­

###### ALLOCATION
------------
- .NET Core 1.0
- .NET Standard 1.3
- .NET Framework 3.5
 
###
­
 
###### DESCRIPTION
------------
Service for [VisualElementsManifest](https://docs.microsoft.com/en-us/previous-versions/windows/apps/dn449733(v=win.10)).

\
--> [Unit Tests](UNIT-TESTS.md)\
--> [Change Log](CHANGE-LOG.md)\
--> [Author & Contact](AUTHOR.md)

\
--> [Donate](https://www.paypal.me/kamilszymborski)

###
­

###### HOW TO USE
------------

Create:
```csharp
var VisualElements = new VisualElements()
{
    { VisualElementType.BackgroundColor, "#ffffff" },
    { VisualElementType.ForegroundText, "light" },
    { VisualElementType.ShowNameOnSquare150x150Logo, "on" },
    { VisualElementType.Square70x70Logo, "70x70-Logo.png" },
    { VisualElementType.Square150x150Logo, "150x150-Logo.png" }
};

var Manifest = ManifestService.Create(VisualElements);
```
or

```csharp
var VisualElements = new VisualElements();
    VisualElements.SetBackgroundColorOn(100, 100, 100);
    VisualElements.SetForegroundTextOnLight();
    VisualElements.SetShowNameOnSquare150x150LogoOnOn();
    VisualElements.SetSquare70x70LogoOn("70x70-Logo.png");
    VisualElements.SetSquare150x150LogoOn("150x150-Logo.png");

var Manifest = ManifestService.Create(VisualElements);
```

###
­

```
Extension methods will ensure correctness.
```

###
­

Parse:
```csharp
var VisualElements = ManifestService.Parse("Xml");
```
###
­

Validate:
```csharp
var Valid = ManifestService.Validate("Xml");
```