using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TetrisConsole
{
    static class InputManager
    {
        public static bool rightKey = false;
        public static bool leftKey = false;
        public static bool downkey = false;
        public static bool spaceKey = false;

        public static int KeyDown()
        {

            ConsoleKeyInfo c = Console.ReadKey(true);
            switch (c.Key)
            {
                case ConsoleKey.DownArrow:
                    downkey = true;
                    break;
                case ConsoleKey.LeftArrow:
                    leftKey = true;
                    break;

                case ConsoleKey.RightArrow:
                    rightKey = true;
                    break;

                case ConsoleKey.Spacebar:
                    spaceKey = true;
                    break;
                case ConsoleKey.Escape:
                    return Program.exitCode;
                    
                default :
                    break;
            }
            return 0;
        }

        public static void clearKey()
        {
            rightKey = leftKey = downkey = spaceKey = false;
        }


    }
}
