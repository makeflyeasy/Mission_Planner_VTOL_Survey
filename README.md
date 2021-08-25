Mission Planner VTOL Survey
==============
### Introduction:

Mission Planner VTOL Survey is based on the official MP1.3.45 and optimized according to the needs of VTOL fixed-wing surveying and mapping.
### Features:
1. Removed functions that are not commonly used;
2. Optimized the position of the high-frequency use function icon;
3. Optimized the difficulty of route generation;
### Target:
Reduce the difficulty of VTOL fixed-wing ground station route planning, which is simpler and more practical.

  
### Download latest stable version:
http://fw.makeflyeasy.com/Mission_Planner_VTOL_Survey/
  
### Website:
http://ardupilot.org/planner/  
 
### Forum:
http://discuss.ardupilot.org/c/ground-control-software/mission-planner


How to compile
==============

1. Install software

- Git
  https://git-for-windows.github.io/
  Select a file summarized as "Full installer for official Git for Windows"
   with the highest version
- TortoiseGit
  https://tortoisegit.org/
- Visual Studio
  http://www.visualstudio.com/downloads/download-visual-studio-vs
  Select "Visual Studio Community 2017 for Windows Desktop" version 15.3 or newer (to include .NET standard 2.0).
- Microsoft .NET 4.0
- .NET standard 2.0

2. Check out

- Create an empty folder anywhere
- In explorer left click and select "Git Clone"
  set URL https://github.com/ArduPilot/MissionPlanner
  OK

3. Build

- Open MissionPlanner.sln with Visual Studio 2017 for windows desktop.
- Compile.


-----------MONO-------------

run using 
mono MissionPlanner.exe

run debuging
MONO_LOG_LEVEL=debug mono MissionPlanner.exe

you need prereq's
sudo apt-get install mono-runtime libmono-system-windows-forms4.0-cil libmono-system-core4.0-cil libmono-winforms2.0-cil libmono-corlib2.0-cil libmono-system-management4.0-cil libmono-system-xml-linq4.0-cil


