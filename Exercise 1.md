# Exercise 1

During this exercise you'll work with a few new concepts of (ASP).NET Core.

  - Work with the request pipeline
  - Runtime information
  - Understand the new project structure, including the wwwroot

### DNVM

First validate if DNVM is installed. Open a Powershell window and type in

```sh
dnvm
```
When the command is not recognized, install DNVM using the Powershell command

```sh
&{$Branch='dev';$wc=New-Object System.Net.WebClient;$wc.Proxy=[System.Net.WebRequest]::DefaultWebProxy;$wc.Proxy.Credentials=[System.Net.CredentialCache]::DefaultNetworkCredentials;Invoke-Expression ($wc.DownloadString('https://raw.githubusercontent.com/aspnet/Home/dev/dnvminstall.ps1'))}
```

### Clone the Git repository

* Open Visual Studio 2015 and navigate to the Team Explorer
* Click ```Local Git Repositories``` and ```Clone```
* Enter the GitHub URL ``` https://github.com/DeSjoerd/sdfg.git ``` and a local folder.
* Hit ```Clone``` and double-click the new repository
* Double-click the solution ```SDFG.BlankWebApp```

### LaunchSettings
* Open Project properties  ```Debug``` tab or the file ```properties\launchSettings.json```
* Create a new profile (e.g. web_staging) which uses the ```web``` command with the staging environment
* Create another profile (e.g. web_x64) which uses the ```web``` command with a specific version of the runtime. 
Hint: you can use the following command to add additional runtimes.
``` sh 
dnvm install [NAME] -r coreclr -o win -a x64
``` 

### Request pipeline
* Open the file ```startup.cs``` and add the following snippet to the Configure method.
``` sh
if (env.IsDevelopment())
{ 
    app.Run(async (context) =>
    {
        await context.Response.WriteAsync("Hello World!");
    });
}
else
{
    app.UseWelcomePage();
}
```
* Debug the application using ```IISExpress``` and ```Kestrel``` 

### Runtime information
* Open the file ```startup.cs``` and add the following line the Configure method.
``` sh
app.UseRuntimeInfoPage("/info");
```
* Run the application and navigate to http://localhost:5000/info

### wwwroot
* Create a new folder (e.g. images) under ```wwwroot``` and add a sample image.
* Open the file ```startup.cs``` and add the following line the Configure method.
``` sh
app.UseStaticFiles();
```
* Check is the sample image is being served.
* Enable directory browsing (only on development) and check if you can see the content of the ```images``` folder.










