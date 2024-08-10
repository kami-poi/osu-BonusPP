# <img src="BonusPP/pp.png" width="40"/> osu! Bonus PP [![](https://img.shields.io/github/release/kami-poi/osu-BonusPP.svg)](https://github.com/kami-poi/osu-BonusPP/releases) [![](https://img.shields.io/github/downloads/kami-poi/osu-BonusPP/total.svg)](#downloads)

# Note

This repository uses .NET instead of [original](https://github.com/RoanH/osu-BonusPP) java 1.8, witch old and out-of-data. Therefore, this project only supports running under Windows because we use WinForm as UI implement. And only can run on Windows 7 and above because .NET 8 does not support Windows XP.

---

A simple tool that can be used to calculate the amount of bonus pp and ranked scores a player has (in osu!).

[Jump directly to downloads](#downloads)

# Forum post

So a little while back a friend of mine asked me to write a program to calculate how much bonus PP he had.
And after writing said program I figured, why not share it with the rest of the community?

For those of you that don't know what bonus PP is, it's basically PP awarded for having passes on a certain number of maps. You can read more about this on the [wiki](https://osu.ppy.sh/wiki/Performance_Points).    
![Bonus PP Table](https://media.roanh.dev/bonuspp/table.png)

To use the program you will need an osu! API key, which you can get [here](https://osu.ppy.sh/home/account/edit) (under Legacy API).

After you run the program you should see the following form:    
![Input Form](https://media.roanh.dev/bonuspp/input.png)

After you fill in the details you should get an output like this:    
![Output Form](https://media.roanh.dev/bonuspp/output.png)

It'll tell you both the amount of bonus PP you have and from that it'll also calculate the number of ranked scores/passes you have.
Every point on the graph represents one of your top 100 scores and what it's worth both weighted and raw (I just thought it looked nice so I left it in).

One thing to note however is that this program uses some statistical tricks in order to get an approximation of the amount of bonus PP you have. So the returned values are not 100% acurate, I believe them to be preatty close though :)

So have fun with the program (or not :P) and feel free to report any bugs you may encounter.

## Downloads

- [Windows executable](https://github.com/kami-poi/osu-BonusPP/releases/download/v1.0/BonusPP-v1.0.exe) _(Requires .NET 8)_
- [Windows executable standalone](https://github.com/kami-poi/osu-BonusPP/releases/download/v1.0/BonusPP-standalone-v1.0.exe)

All releases: [releases](https://github.com/kami-poi/osu-BonusPP/releases)<br>
GitHub repository: [repository](https://github.com/kami-poi/osu-BonusPP)<br>

## History
Project development started: 26 December 2016
