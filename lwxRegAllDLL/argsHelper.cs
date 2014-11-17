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

namespace lwxConsoleTools
{

    internal class argsHelper
    {
        /// <summary>
        /// Gets the argument value.
        /// </summary>
        /// <param name="args">The arguments.</param>
        /// <param name="prefix">The prefix. ie like "/" or "-"</param>
        /// <param name="key">The key.</param>
        /// <param name="keyAlias1">Alternative key (ie /s alias /silent)</param>
        /// <param name="keyAlias2">Alternative key (ie /s alias /silent)</param>
        /// <returns></returns>
        internal static string getArgValue(string[] args, string key, string keyAlias1 = "", string keyAlias2 = "")
        {
            int len = args.Length;
            string retVal = "";
            if (keyAlias1 == "") keyAlias1 = key;
            if (keyAlias2 == "") keyAlias2 = key;

            int keyIndex = Array.FindIndex(args, pos => pos == key);
            if (keyIndex == -1) keyIndex = Array.FindIndex(args, pos => pos == keyAlias1);
            if (keyIndex == -1) keyIndex = Array.FindIndex(args, pos => pos == keyAlias2);

            if (keyIndex > 0)
            {
                int i = keyIndex + 1;
                if (i + 1 < len)
                {
                    retVal = args[i + 1];
                }
            }
            return retVal;
        }

        internal static bool doesArgExist(string[] args, string key, string keyAlias1 = "", string keyAlias2 = "")
        {
            if (keyAlias1 == "") keyAlias1 = key;
            if (keyAlias2 == "") keyAlias2 = key;

            int keyIndex = Array.FindIndex(args, pos => pos == key);
            if (keyIndex == -1) keyIndex = Array.FindIndex(args, pos => pos == keyAlias1);
            if (keyIndex == -1) keyIndex = Array.FindIndex(args, pos => pos == keyAlias2);

            return keyIndex != -1;
        }

    }
}