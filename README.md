# RoR2ModTest
my first attempt at a risk of rain 2 mod using BepInEx and R2API.

Just simple stuff intended to setup my dev environment mostly and play around with the modding API. 
This is currently just a simple mod that lets you spawn items using the num pad.<br>
<br>
Basic:<br>
numpad0 - a random white item<br>
numpad1 - a random green item<br>
numpad2 - a random red item<br>
numoad3 - a random boss item<br>
numpad4 - a random equipment item<br>
numpad5 - a random lunar item<br>
numpad6 - a random lunar equipment item<br>
numpad7 - a random void item (tier 1)<br>
numpad8 - a random void item (tier 2)<br>
numpad9 - a random void item (tier 3)<br>
<br>
Extras:<br>
numpad_plus - Captain's Defensive Microbot<br>
alpha1 - Pearl<br>
alpha2 - Shiny pearl

## Build Instructions
<br><br>If you want to change the code for this mod or attempt to build it yourself, you will need to setup a few dependencies first using NuGet.<br> You can find all the necessary dependency packages in ROR2TestMod.csproj and you can install them by using the following NuGet command:
```
dotnet add package SomeName.LibName -v *-*
```
Here is an example of this:
```
dotnet add package BepInEx.Core --v 6.0.0-be.553
```

The only exceptions to this are the R2API dll and the MMHOOK dll which are referenced explicitly and are expected to be placed in the libs folder.<br>

Once all of the dependencies are in place, you can build the mod using the followign command:
```
dotnet build
```
The newly assembled mod dll will be placed in \bin\Debug\netstandard2.0
