# Mvx.Volume [![Build Status](https://www.bitrise.io/app/9e2ca66d654196bf/status.svg?token=s0ZpMIOwzNWuuhedljgVRA&branch=master)](https://www.bitrise.io/app/9e2ca66d654196bf)
:mute: MvvmCross Plugin to handle the device's volume

This plugin allows you to handle the device's volume in any [MvvmCross](https://github.com/MvvmCross/MvvmCross) project.

# Installation

Install via [NuGet](https://www.nuget.org/packages/Mvx.Volume/) using:

``PM> Install-Package Mvx.Volume``

# Usage

Resolve it:

``var volumeService = Mvx.Resolve<IVolumeService>();``

Use it at will:

```
//Sets the volume. Parameter must be between 0 and 100, inclusive, or else this will throw. 
volumeService.Set(50);

//Convenient alias to volumeService.Set(0)
volumeService.Mute();
```

Check the Sample projects for a working example.

# Acknowledgements

Icon Mute by Gregor Cresnar from the Noun Project
