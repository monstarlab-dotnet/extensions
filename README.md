# Getting started
The solution only contains extension methods, so there's nothing you can start as you would in a normal project.

To run the extensions, you either need to run/write unit tests or add a reference to the NuGet package in another project.

# Monstarlab.Extensions
This project contains extensions for basic .NET types e.g. string to enum

## String extensions

### ToNullableEnum
This method converts a string to a nullable enum, meaning that if the string cannot be parsed into the specified enum, the method will return `null`.

### TryParseEnum
This method converts a string to an enum. The method returns whether it was successful or not and returns a default value as the out parameter if it isn't able to parse it.


# Monstarlab.Web.Extensions
This project contains extensions for ASP.NET Core classes.

## ConfigExtensions

### AddConfig
Add a config section as a singleton to the DI container.