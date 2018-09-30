#!/bin/sh
nuget pack NuGet/Intercom.Sdk.Fcm.nuspec -BasePath .
nuget pack NuGet/Intercom.Sdk.Gcm.nuspec -BasePath .
nuget pack NuGet/Intercom.Sdk.nuspec -BasePath .
