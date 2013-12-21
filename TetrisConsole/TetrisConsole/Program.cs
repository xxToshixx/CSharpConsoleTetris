using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TetrisConsole
{
    class Program
    {
        public static int exitCode = 100;
        static void Main(string[] args)
        {
            Tetris t = new Tetris();

            while(true)
            {
                t.Draw();
                int rtn= InputManager.KeyDown();

                if (rtn != exitCode)
                {
                    t.Update();
                    InputManager.clearKey();
                }
                if (rtn == exitCode)
                    return;
            }
        }
    }
}
