$nuspec1 = (Split-Path -Parent $PSScriptRoot) + "\ALEX.Win32\ALEX.Win32.sln.nuspec"
$nuspec2 = (Split-Path -Parent $PSScriptRoot) + "\ALEX.Win32\ALEX.Win32.dll\ALEX.Win32.dll.csproj.nuspec"
$nuspec3 = (Split-Path -Parent $PSScriptRoot) + "\ALEX.Win32\ALEX.Win32.winmd\ALEX.Win32.winmd.csproj.nuspec"
$output = (Split-Path -Parent $PSScriptRoot) + "\NuGet"
$nuget = $PSScriptRoot + "\nuget.exe"
$nuspec
&($nuget) "pack" $nuspec2 -Prop "Configuration=Release" -Build -output "$output"

