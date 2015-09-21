$nuspec = (Split-Path -Parent $PSScriptRoot) + "\ALEX.Win32.PowerManagement\ALEX.Win32.PowerManagement.nuspec"
$output = (Split-Path -Parent $PSScriptRoot) + "\NuGet"
$nuget = $PSScriptRoot + "\nuget.exe"
$nuspec

#&($nuget) "setApiKey" "4cfc0f8e-6ff5-475d-a212-f8afd6c26e1b"

$result = (&($nuget) "pack" "$nuspec" -Prop "Configuration=Release" -Build -output "$output")

$package = ($result | where {$_.Contains("nupkg")} | foreach {
    $start = $_.IndexOf("'")
    $end = $_.IndexOf("'", $start +1)
    #$start
    #$end
    $_.SubString($start + 1, $end - $start - 1)
})

#$package
&($nuget) "push" "$package"