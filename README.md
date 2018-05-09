Having a weird issue when referencing a .NET Standard class library from a .NET Core 2.1 preview 2 (2.1.300-preview2-008533) project, in particular with the System.ServiceModel.Primitives NuGet package.

There is a custom IEndpointBehavior implementation in the class library, which is using System.ServiceModel.Primitives version 4.4.2.
When using that class in the the console app, which is referencing System.ServiceModel.Primitives 4.5.0-preview2-26410-01, the following error occurs:
"Cannot convert from 'ClassLibrary1.CustomBehavior' to 'System.ServiceModel.Description.IEndpointBehavior'"

Suggested fix is "You must add a reference to assembly 'System.ServiceModel.Primitives, Version=4.2.0.1, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'"
Why is this neccessary? As far as I know .NET Core 2.1 is still .NET Standard 2.0 compliant and I should just be able to use this class library. I don't know, so I submitted an issue to the WCF team: https://github.com/dotnet/wcf/issues/2791

Update: This was a bug, the public key of System.ServiceModel.Primitives was changed by accident. This has been reverted for the 2.1 release.

![Screenshot of the issue](https://github.com/rvanmaanen/dotnetcore21issue/blob/master/ConsoleApp1/Screenshot.png "Screenshot")
