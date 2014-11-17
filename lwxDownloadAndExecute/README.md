Purpose: Download a file and execute it

The main idea is to be able to tell it what to download and install, when reinstalling a computer

  parameters:
  /help        - displays this help
  /url         - /url url to the file to download
  /silent      - send the /silent parameter to MSI installer
  /passive     - send the /passive parameter to MSI installer
  /failsafe    - failsafe, if the executable can't be downloaded, open a webbrowser with the download link
  /dontExecute - just download, dont execute the file
  /saveas   - filename to save the file as

  Alias parameter:
  /?  = /help
  /u  = /url
  /s  = /silent
  /p  = /passive
  /f  = /failsafe
  /sa = /saveAs
