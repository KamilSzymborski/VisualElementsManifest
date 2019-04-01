###### Parse
```csharp
public static bool ParseTest()
{
    var Manifest = ManifestService.Create(ManifestService.Parse("<Application>  <VisualElements      BackgroundColor=\"1\"      ForegroundText=\"2\"      ShowNameOnSquare150x150Logo=\"3\"      Square70x70Logo=\"4\"      Square150x150Logo=\"5\" /></Application>"));

    var Hash = BitConverter.ToString(MD5.Create().ComputeHash(Encoding.UTF8.GetBytes(Manifest)));

    return Hash.Equals("9B-D8-6F-B6-4A-02-E1-F2-B3-82-5E-87-B1-8F-7B-63");
}
```
###### Create
```csharp
public static bool CreateTest()
{
    var VisualElements = new VisualElements
    {
        [VisualElementType.BackgroundColor] = "1",
        [VisualElementType.ForegroundText] = "2",
        [VisualElementType.ShowNameOnSquare150x150Logo] = "3",
        [VisualElementType.Square70x70Logo] = "4",
        [VisualElementType.Square150x150Logo] = "5"
    };
    var Manifest = ManifestService.Create(VisualElements);

    var Hash = BitConverter.ToString(MD5.Create().ComputeHash(Encoding.UTF8.GetBytes(Manifest)));

    return Hash.Equals("9B-D8-6F-B6-4A-02-E1-F2-B3-82-5E-87-B1-8F-7B-63");
}
```
###### Validate
```csharp
public static bool ValidateTest()
{
    var TestFragments = new Dictionary<string, bool>
    {
        {"<Application>  <VisualElements      BackgroundColor=\"aqua\"      ForegroundText=\"dark\"      ShowNameOnSquare150x150Logo=\"on\" /></Application>", true },
        {"<Application>  <VisualElements      BackgroundColor=\"aqua\"      ForegroundText=\"dark\"      ShowNameOnSquare150x150Logo=\"on\"      Square150x150Logo=\"Medium-Image.png\" /></Application>", false },
        {"<Application>  <VisualElements      BackgroundColor=\"aqua\"      ForegroundText=\"dark\"      ShowNameOnSquare150x150Logo=\"on\"      Square70x70Logo=\"Small-Image.png\"      Square150x150Logo=\"Medium-Image.jpg\" /></Application>", true },
        {"<Application>  <VisualElements      BackgroundColor=\"#aaBBcc\"      ForegroundText=\"dark\"      ShowNameOnSquare150x150Logo=\"on\"      Square70x70Logo=\"Small-Image.gif\"      Square150x150Logo=\"Medium-Image.jpeg\" /></Application>", true },
        {"<Application>  <VisualElements      BackgroundColor=\"Aqua\"      ForegroundText=\"dark\"      ShowNameOnSquare150x150Logo=\"on\"      Square70x70Logo=\"Small-Image.gif\"      Square150x150Logo=\"Medium-Image.jpeg\" /></Application>", false },
        {"<Application>  <VisualElements      BackgroundColor=\"aqua\"      ForegroundText=\"Dark\"      ShowNameOnSquare150x150Logo=\"on\"      Square70x70Logo=\"Small-Image.gif\"      Square150x150Logo=\"Medium-Image.jpeg\" /></Application>", false },
        {"<Application>  <VisualElements      BackgroundColor=\"aqua\"      ForegroundText=\"dark\"      ShowNameOnSquare150x150Logo=\"On\"      Square70x70Logo=\"Small-Image.gif\"      Square150x150Logo=\"Medium-Image.jpg\" /></Application>", false },
        {"<Application>  <VisualElements      BackgroundColor=\"aqua\"      ForegroundText=\"dark\"      ShowNameOnSquare150x150Logo=\"on\"      Square70x70Logo=\"Small-Image.Gif\"      Square150x150Logo=\"Medium-Image.jpeg\" /></Application>", false },
        {"<Application>  <VisualElements      BackgroundColor=\"aqua\"      ForegroundText=\"dark\"      ShowNameOnSquare150x150Logo=\"on\"      Square70x70Logo=\"\\Small-Image.gif\"      Square150x150Logo=\"Medium-Image.jpeg\" /></Application>", false },
        {"<Application>  <VisualElements      BackgroundColor=\"aqua\"      ForegroundText=\"dark\"      ShowNameOnSquare150x150Logo=\"on\"      Square70x70Logo=\"Images\\Small-Image.gif\"      Square150x150Logo=\"Medium-Image.jpeg\" /></Application>", true },
        {"<Application>  <VisualElements      BackgroundColor=\"aqua\"      ForegroundText=\"dark\"      ShowNameOnSquare150x150Logo=\"on\"      Square70x70Logo=\"C:\\Images\\Small-Image.gif\"      Square150x150Logo=\"Medium-Image.jpeg\" /></Application>", true }
    };

    return TestFragments.All(TestFragment => ManifestService.Validate(TestFragment.Key) == TestFragment.Value);
}
```
###### IDictionaryExtension
```csharp
public static bool IDictionaryExtensionTest()
{
    bool Valid = false;
    VisualElements VisualElements;


    // PART 1 SETTERS ---------------------------------------
    VisualElements = new VisualElements();


    VisualElements.SetBackgroundColorOn(0);
    Valid = VisualElements[VisualElementType.BackgroundColor].Equals("#000000");
    if (Valid == false) return false;


    VisualElements.SetBackgroundColorOn(32327);
    Valid = VisualElements[VisualElementType.BackgroundColor].Equals("#007e47");
    if (Valid == false) return false;

    VisualElements.SetBackgroundColorOn(255, 255, 255);
    Valid = VisualElements[VisualElementType.BackgroundColor].Equals("#ffffff");
    if (Valid == false) return false;

    VisualElements.SetForegroundTextOnDark();
    Valid = VisualElements[VisualElementType.ForegroundText].Equals("dark");
    if (Valid == false) return false;

    VisualElements.SetForegroundTextOnLight();
    Valid = VisualElements[VisualElementType.ForegroundText].Equals("light");
    if (Valid == false) return false;

    VisualElements.SetShowNameOnSquare150x150LogoOnOn();
    Valid = VisualElements[VisualElementType.ShowNameOnSquare150x150Logo].Equals("on");
    if (Valid == false) return false;

    VisualElements.SetShowNameOnSquare150x150LogoOnOff();
    Valid = VisualElements[VisualElementType.ShowNameOnSquare150x150Logo].Equals("off");
    if (Valid == false) return false;

    VisualElements.SetSquare70x70LogoOn("C:\\CsS\\skaskda.tetwe");
    Valid = VisualElements[VisualElementType.Square70x70Logo].Equals("C:\\CsS\\skaskda.tetwe");
    if (Valid == false) return false;

    VisualElements.SetSquare150x150LogoOn("C:\\CsS\\skaskda.tetwe");
    Valid = VisualElements[VisualElementType.Square150x150Logo].Equals("C:\\CsS\\skaskda.tetwe");
    if (Valid == false) return false;

    VisualElements.Remove(VisualElementType.Square70x70Logo);
    VisualElements.Remove(VisualElementType.Square150x150Logo);
    VisualElements.SetSquare70x70LogoAndSquare150x150LogoOn("C:\\CsS\\skaskda.tetwe");
    Valid = VisualElements[VisualElementType.Square70x70Logo].Equals("C:\\CsS\\skaskda.tetwe") && VisualElements[VisualElementType.Square150x150Logo].Equals("C:\\CsS\\skaskda.tetwe");
    if (Valid == false) return false;


    // PART 2 CHECKERS ---------------------------------------
    VisualElements = new VisualElements();


    VisualElements.SetBackgroundColorOn(0);
    Valid = VisualElements.IsBackgroundColorSet();
    if (Valid == false) return false;

    VisualElements.SetForegroundTextOnDark();
    Valid = VisualElements.IsForegroundTextSet();
    if (Valid == false) return false;

    VisualElements.SetShowNameOnSquare150x150LogoOnOn();
    Valid = VisualElements.IsShowNameOnSquare150x150LogoSet();
    if (Valid == false) return false;

    VisualElements.SetSquare70x70LogoOn("C:\\CsS\\skaskda.tetwe");
    Valid = VisualElements.IsSquare70x70LogoSet();
    if (Valid == false) return false;

    VisualElements.SetSquare150x150LogoOn("C:\\CsS\\skaskda.tetwe");
    Valid = VisualElements.IsSquare150x150LogoSet();
    if (Valid == false) return false;

    VisualElements.Remove(VisualElementType.Square70x70Logo);
    VisualElements.Remove(VisualElementType.Square150x150Logo);
    VisualElements.SetSquare70x70LogoAndSquare150x150LogoOn("C:\\CsS\\skaskda.tetwe");
    Valid = VisualElements.IsSquare70x70LogoAndSquare150x150LogoSet();
    if (Valid == false) return false;


    // PART 3 GETTERS ---------------------------------------
    VisualElements = new VisualElements();


    VisualElements[VisualElementType.BackgroundColor] = "#000000";
    Valid = VisualElements.GetSetBackgroundColor() == 0;
    if (Valid == false) return false;

    VisualElements[VisualElementType.BackgroundColor] = "#007e47";
    Valid = VisualElements.GetSetBackgroundColor() == 32327;
    if (Valid == false) return false;

    VisualElements[VisualElementType.Square70x70Logo] = "C:\\CsS\\skaskda.tetwe";
    Valid = VisualElements.GetSetSquare70x70Logo().Equals("C:\\CsS\\skaskda.tetwe");
    if (Valid == false) return false;

    VisualElements[VisualElementType.Square150x150Logo] = "C:\\CsS\\skaskda.tetwe";
    Valid = VisualElements.GetSetSquare150x150Logo().Equals("C:\\CsS\\skaskda.tetwe");
    if (Valid == false) return false;


    return Valid;
}
```