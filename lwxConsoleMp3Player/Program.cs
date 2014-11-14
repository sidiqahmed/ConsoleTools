using System;
using System.IO;
using System.Threading;
using WMPLib;

/// <summary>
/// A simple mp3 player to use from CMD or batch files
/// </summary>
namespace lwxConsoleMp3Player
{
    class Program
    {
        static bool isDone = false;
        static WindowsMediaPlayer wplayer = new WindowsMediaPlayer();
        /// <summary>
        /// Mains the specified arguments.
        /// </summary>
        /// <param name="args">path to the file</param>
        static void Main(string[] args)
        {
            if (args.Length > 0)
            {
                //Add all arguments to a single file, so the filename will be used regardsless if the user provides
                //the link with quotes or not
                string filename = string.Join(" ", args);

                //remove extra spaces
                filename = filename.Trim();

                if (filename != "")
                {
                    if (File.Exists(filename))
                    {
                        wplayer.PlayStateChange += wplayer_PlayStateChange;
                        wplayer.URL = filename;

                        //Wait for the file to stop playing
                        while (!isDone)
                        {
                            Thread.Sleep(100);
                        }
                    }
                    else
                    {
                        Console.WriteLine("mp3 file not found");
                    }
                }
                else
                {
                    Console.WriteLine("Filename was empty");
                }
            }
            else
            {
                Console.WriteLine("Usage: lwxConsoleMp3Player filename.mp3");
            }
        }

        /// <summary>
        /// Triggers when media player state changes.
        /// </summary>
        /// <param name="NewState">The new state.</param>
        static void wplayer_PlayStateChange(int NewState)
        {
            if (NewState == (int)WMPLib.WMPPlayState.wmppsMediaEnded)
            {
                isDone = true;
            }
        }


    }
}
