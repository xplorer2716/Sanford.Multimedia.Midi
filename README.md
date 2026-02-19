Sanford.Multimedia.Midi
=======================

This is all source code of the C# MIDI toolkit from CodeProject by Leslie Sanford.

Improvements:
- 64-bit compatible
- <b>Windows 10+ compatible</b>
- Mono framework compatible on Windows
- <b>.NET 10 compatible</b>
- Core assembly 'Sanford.Multimedia.Midi.Core' can be used without any UI attached
- 'Sanford.Multimedia.Midi.Core' assembly is portable and cross-platform, it can be used anywhere!
- 'Sanford.Multimedia.Midi.Core' does not require additional assemblies
- Only the UI assemblies require additional assemblies
- Faster midi file reading in Release build

- <b>Minor changes  regarding SysexMessage, ChannelMessage, ControlChangesNames</b>

Since this is developed in .NET, the following will need to be installed:
- For building: <b>.NET 10 SDK</b>
- For running: <b>.NET 10 Runtime</b>
- Both can be downloaded here: https://dotnet.microsoft.com/download/dotnet/8.0

~~Also avaliable on Nuget.org~~

~~PM> Install-Package Sanford.Multimedia.Midi~~

If you have any improvement or fix to this library, please don't hesitate to make a fork and open a pull request.

MIT License

Credits:

http://www.codeproject.com/Articles/6228/C-MIDI-Toolkit

https://code.google.com/p/vsticks/
