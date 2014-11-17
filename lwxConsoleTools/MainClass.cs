/*
    This file is part of lwxConsoleTools project.

    lwxConsoleTools project is free software: you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation, either version 3 of the License, or
    (at your option) any later version.

    Foobar is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with Foobar.  If not, see <http://www.gnu.org/licenses/>.

    For more information, contact marcus@lunaworx.net
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lwxConsoleTools
{
    class Program
    {
        /// <summary>
        /// This class is only to display info
        /// </summary>
        /// <param name="args">The arguments are invalid</param>
        static void Main(string[] args)
        {
            Console.WriteLine(" +---------------------------------------------------------------------------+");
            Console.WriteLine(" |                              LunaWorX Consoletools                        +");
            Console.WriteLine(" +---------------------------------------------------------------------------+");
            Console.WriteLine(" |                                                                           +");
            Console.WriteLine(" | I love batch scripting so I created a collection of fun functions to      +");
            Console.WriteLine(" | enhance the scripting. Nothing fancy but still useful. Console scripting  +");
            Console.WriteLine(" | is a thing of the past, unless you find yourself in the position of being +");
            Console.WriteLine(" | admin at the office... sooner or later you will need scripting.. a lot :) +");
            Console.WriteLine(" |                                                                           +");
            Console.WriteLine(" +---------------------------------------------------------------------------+");
            Console.WriteLine(" |                                                                           +");
            Console.WriteLine(" | Tools so far:                                                             +");
            Console.WriteLine(" | * lwxConsoleTools project   - plays soundfiles from the Console :-)           +");
            Console.WriteLine(" |                           a nicer replacement for the Beep                +");
            Console.WriteLine(" | * lwxDownloadAndExecute - Downloads a file and executes it with /silent   +");
            Console.WriteLine(" |                           and /passive MSI tags (if the executable can    +");
            Console.WriteLine(" |                           handle it)                                      +");
            Console.WriteLine(" | * lwxRegAllDll          - A relique from the DLL-HELL years, it runs a    +");
            Console.WriteLine(" |                           regSvr32.dll on all exe and DLL files in the    +");
            Console.WriteLine(" |                           folder.                                         +");
            Console.WriteLine(" |                                                                           +");
            Console.WriteLine(" |                                                          www.lunaworx.net +");
            Console.WriteLine(" +---------------------------------------------------------------------------+");
        }
    }
}
