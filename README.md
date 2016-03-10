<a href="https://www.gitcheese.com/app/#/projects/cac52adf-9413-446a-bdc8-8d8593d5a9ce/pledges/create" target="_blank" style="float:left;" > <img src="https://api.gitcheese.com/v1/projects/cac52adf-9413-446a-bdc8-8d8593d5a9ce/badges" width="200px" /> </a>
Avatarator [![Build status](https://ci.appveyor.com/api/projects/status/uf021jx0uwmss48o?retina=true)](https://ci.appveyor.com/project/mgibas/avatarator)
====
Just simple .Net avatar generator :)

NuGet
====
```
Install-Package Avatarator
```

Features
====
* generate abbreviation/initial avatar

Usages
====
```csharp
var config = new AvataratorConfig();
var generator = new AbbreviationGenerator(config);
var image = generator.Generate("my name", 100, 100);
```
Changing background colors set (default are pretty nice though :) ):
```csharp
var myColors = new []{ Color.AliceBlue, Color.Aquamarine };
var config = new AvataratorConfig().WithBackgroundColors(myColors);
```
Of course You probably use some IoC - no problem :) Just bind `IAvataratorConfig` and `IGenerateAvatar` :)

Contribute
====
Maybe You have an idea for other avatar generator - do no hesitate - please send me some pull request :)
