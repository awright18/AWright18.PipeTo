
# Installation

## Nuget
Using [Nuget](https://www.nuget.org/) [https://www.nuget.org/packages/AWright18.PipeTo](https://www.nuget.org/packages/AWright18.PipeTo)

From the Package Manager Command Line

![](images/package_manager_commandline_install.png)

From Visual Studio "Manage Packages"

![](images/install_with_nuget.gif)

## Paket [http://fsprojects.github.io/Paket/](http://fsprojects.github.io/Paket/)

You can use the [packet add](http://fsprojects.github.io/Paket/paket-add.html) command.  

packet add nuget AWright18.PipeTo -i 

![](images/Install_with_paket.gif)


Or simply add it to your paket.dependencies file by hand. 
![](images/paket.dependencies.png)

Then run paket install
![](images/paket_install.png)