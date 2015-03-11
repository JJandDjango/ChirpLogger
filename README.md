# ChirpLogger
ChirpLogger a Cities: Skylines modding tool for code debugging and logging

# Summary

Writing code for mods code is a funny thing. 
In general, API's range from non-existant to plain wrong, and tools are nowhere to be found. Not a debugger, not even a meager debug console most of the times. 
We're left out in the cold, doomed to "run and repeat" until the mod magically works.

However, with Cities: Skylines it doesn't have to be this way!

ChirpLogger is here to help you along in development of more complex mods by allowing you to write debug/info/warning/error logs with simple calls such as ChirpLog.Debug("This is a log");
These logs are recorded and can be flushed to easy to access files placed in the game directory!

# Why should I use this
Do you like to wander in the dark looking as to why your mod malfunctions? I don't.

Even if not, then ChirpLogger can be your buddy while you're trying to reverse engineer the game! Just check the example mod for an idea of where to start ;)

# How to Use
1. Download the 'Proj/ChirpLoggerExample/ChirpLogger' folder and add it to your mod project.
2. Add "using ChirpLogger;" to your mod files.
3. Call ChirpLog.Debug(string), ChirpLog.Info(string), ChirpLog.Warning(string), ChirpLog.Error(string) where you need in your code (each log serves a self-explanatory purpose I hope).
4. Call ChirpLog.Flush() when you want to write the logs to file.
5. Read your debug logs in 'C:\Program Files (x86)\Steam\steamapps\common\Cities_Skylines\_DebugChirpLogs'
6. ...
7. Upload your mod WITHOUT the ChirpLogger folder (or compile it removing all calls to it)
7. Mention (and hyperlink back here) that you used ChirpLogger in your Workshop/Mod Page to validate my efforts and make me smile :)
8. Modding Fame and Profit?

If your're having trouble getting it to work, check the example mod in this repository, where I print all GameObjects n the active unity scene:
https://github.com/Enagan/ChirpLogger/blob/master/Proj/ChirpLoggerExample/CSkyMod/ChirpLoggerExample.cs

# Why are you doing this
Sadly I'm a guy with big ideas, all of them were above and beyond the scope of the current limited API. So I needed a way to probe the game. Simultaneously, I needed a tool to remain sane while developing more complex mods. Hence ChirpLogger was born!

# Is this it? It's barely any code...
For now yes. The game just came out, gimme a break! I'm... "busy"....

Key Word however is the "for now"
I plan on extending this in the future, including sch features as:
- Stacktracing.
- Capturing exceptions and writing them to Error Log.
- In-Game Debug UI, so you can see your logs written on screen in real time.
- Sister UIInjection library, to provide an easy way to create UI in-game without always having to be finnicking around with GameObjects and Components and ARGH
- In-Game Debug console, able to receive commands, (such as cheat codes) but also with an API to make calls in the currently running mod.
- I haven't thought this far, but I probably will have more ideas.

# Can I help?
Of course! What kind of open source project would it be otherwise.
If you have ideas, shoot them my way.
If you can code and you want to help, submit a pull request with your changes or additions to ChirpLogger and I will review and integrate them, crediting you in the process.

# That's it for now, thanks for reading!
