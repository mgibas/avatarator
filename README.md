# Avatarator
<p align="center">
    <a href="https://ci.appveyor.com/project/mgibas/avatarator/branch/master">
        <img src="https://ci.appveyor.com/api/projects/status/github/mgibas/avatarator?branch=master&svg=true"></img>
    </a>
    <a href="https://www.gitcheese.com/app/#/projects/cac52adf-9413-446a-bdc8-8d8593d5a9ce/pledges/create">
        <img src="https://api.gitcheese.com/v1/projects/cac52adf-9413-446a-bdc8-8d8593d5a9ce/badges"></img>
    </a>
</p>

===

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

