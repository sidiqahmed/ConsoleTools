
namespace lwxConsoleTools
{
    public class argsHelper
    {
        /// <summary>
        /// Gets the argument value.
        /// </summary>
        /// <param name="myArgs">The arguments.</param>
        /// <param name="prefix">The prefix. ie like "/" or "-"</param>
        /// <param name="key">The key.</param>
        /// <param name="keyAlias1">Alternative key (ie /s alias /silent)</param>
        /// <param name="keyAlias2">Alternative key (ie /s alias /silent)</param>
        /// <returns></returns>
        internal static string getArgValue(string[] myArgs, string key, string keyAlias1 = "", string keyAlias2 = "")
        {
            int len = myArgs.Length;
            string retVal = "";
            if (keyAlias1 == "") keyAlias1 = key;
            if (keyAlias2 == "") keyAlias2 = key;

            int keyIndex = System.Array.FindIndex(myArgs, pos => pos == key);
            if (keyIndex == -1) keyIndex = System.Array.FindIndex(myArgs, pos => pos == keyAlias1);
            if (keyIndex == -1) keyIndex = System.Array.FindIndex(myArgs, pos => pos == keyAlias2);

            if (keyIndex >= 0)
            {
                int i = keyIndex + 1;
                if (i < len)
                {
                    retVal = myArgs[i];
                }
            }
            return retVal;
        }

        public  static bool doesArgExist(string[] myArgs, string key, string keyAlias1 = "", string keyAlias2 = "")
        {
            if (keyAlias1 == "") keyAlias1 = key;
            if (keyAlias2 == "") keyAlias2 = key;

            int keyIndex = System.Array.FindIndex(myArgs, pos => pos == key);
            if (keyIndex == -1) keyIndex = System.Array.FindIndex(myArgs, pos => pos == keyAlias1);
            if (keyIndex == -1) keyIndex = System.Array.FindIndex(myArgs, pos => pos == keyAlias2);

            return keyIndex != -1;
        }
    }
}