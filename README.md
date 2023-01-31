# WilsonNetoDev.Utils
🎥 A simple utils package (made in a youtube video)

Video link:
https://www.youtube.com/watch?v=5v02KTGgkNg

Commands used in the video:

Generating the apckage:

```
dotnet pack -c release -o ./dist/
```

Publishing on Nuget.Org:
````
dotnet nuget push .\WilsonNetoDev.Utils\dist\WilsonNetoDev.Utils.1.0.0.nupkg -k <<YOUR-NUGET-KEY-HERE>> -s https://api.nuget.org/v3/index.json
````

Publishing on github:
```
dotnet nuget push <<PATH-TO-NUPKG>>  --api-key <<YOUR-GITHUB-PAT>> --source https://api.nuget.org/v3/index.json
```

Adding GitHub Packages source to use private packages:
```
dotnet nuget add source --username <<YOUR-GITHUB-USERNAME>> --password <<YOUR-PAT>> --store-password-in-clear-text --name github "https://nuget.pkg.github.com/<<YOUR-GITHUB-USERNAME>>/index.json"
```

