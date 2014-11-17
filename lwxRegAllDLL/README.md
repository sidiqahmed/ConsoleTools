I created this program for a project at work a long time ago. It was used frequently when having DLL HELL in Windows XP. I am not sure if it's needed now, but I decided recreate the functionality in case someone needs it.

What it does is simply that it looks for all the DLL or EXE files and runs a RegSvr32 on them.

Simple, and it solved a lot of problems at that time.

<Anecdote>
A funny anecdote. 
One time, a coworker and I were visiting a really grumpy customer, and he told us he found the solution to the DLL-hell that happened when updating out software. We had to use the RegAllDLL.exe file he had found while snooping in the project files. I asked my coworker if I should inform him that I created that program just for that reason, but my coworker thought it was best to let the gumpy customer scream off some steam. A those were the fun days of consulting...
</Anecdote>

Parameters:
  /help        - displays this help
  /silent      - send the /silent parameter to MSI installer
  /unregister  - Unregister the DLL

  Alias parameter:
  /?  = /help
  /s  = /silent
  /u  = /unregister
  

  
  
www.lunaworx.net
