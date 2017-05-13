# Avatarator

<p align="center">
    <a href="https://ci.appveyor.com/project/mgibas/avatarator/branch/master">
        <img src="https://ci.appveyor.com/api/projects/status/github/mgibas/avatarator?branch=master&svg=true"></img>
    </a>
    <a href="https://www.gitcheese.com/donate/users/530319/repos/32778272">
        <img src="https://s3.amazonaws.com/gitcheese-ui-master/images/badge.svg"></img>
    </a>
    <a href="https://www.nuget.org/packages/Avatarator/">
        <img src="https://img.shields.io/nuget/v/Avatarator.svg?style=flat-square"></img>
    </a>
</p>

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

