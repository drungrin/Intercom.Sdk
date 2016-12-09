#!/bin/sh
nuget pack NuGet/Intercom.Sdk.Base.nuspec -BasePath .
nuget pack NuGet/Intercom.Sdk.Gcm.nuspec -BasePath .
nuget pack NuGet/Intercom.Sdk.nuspec -BasePath .
