using System;
using System.IO;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace Yulgang_Serial_Code
{
    public class Bot
    {
        private bool Running = false;
        public string RunCode = "?";
        public string RunIndex = "?";
        public string Codes = "";
        public bool BotStop = false;
        private string[] _codes;
        private string[] _indexes;
        private int _runIndex;

        public void SetCode(String codes)
        {
            var textArr = codes.Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
            int codesLineCount = textArr.Length;
            _codes = new string[codesLineCount];
            _indexes = new string[codesLineCount];

            using( StringReader reader = new StringReader(codes) )
            {
                string line;
                int loop = 0;

                while( ( line = reader.ReadLine() ) != null )
                {
                    if( line.Contains('|') )
                    {
                        string[] data = line.Split('|');
                        _codes[loop] = data[1];
                        _indexes[loop] = data[0];
                        loop++;
                    }
                }
            }

            Console.WriteLine(string.Join(", ", _codes));
            Console.WriteLine(string.Join(", ", _indexes));
        }

        public void Reset()
        {
            RunCode = "?";
            RunIndex = "?";
            Codes = "";
            BotStop = false;
            _runIndex = 0;
            _codes = null;
            _indexes = null;
            Running = false;
        }

        public void Run(IntPtr handleWindow, SerialCode.GameWindow gameWindow,Boolean npcZoom)
        {

            if( Running )
            {
                Console.WriteLine(@"Bot running...");
            }
            else
            {
                //set running
                Running = true;
                Console.WriteLine(@"Bot start...");
                Console.WriteLine(@"run index :" + _runIndex.ToString());

                //Check code 
                if( ( _runIndex + 1 ) > _codes.Length || _codes.Length == 0 )
                {
                    Console.WriteLine(@"Bot set stop");

                    BotStop = true;
                    return;
                }

                //Get code
                string code =  _codes[_runIndex];
                string index =  _indexes[_runIndex];
                Console.WriteLine(code);
                Console.WriteLine(index);

                //Set run code
                RunCode = code;
                RunIndex = index;

                //Check code empty
                if (code == "" || code.Trim() == "" || code == " ")
                {
                    Console.WriteLine(@"Skip code empty");
                }
                else
                {
                    var serialCode  = new SerialCode(handleWindow);

                    //Talk NPC
                    serialCode.NpcSelection();

                    //Sleep for NPC
                    if (npcZoom)
                    {
                        Thread.Sleep(2500);
                    }
                    else
                    {
                        Thread.Sleep(1000);
                    }

                    //Open window for put code
                    serialCode.OpenWindow(gameWindow);
                    Thread.Sleep(500);

                    //Typing code
                    serialCode.Code(code);
                    Thread.Sleep(500);

                    //Enter code
                    serialCode.Enter();

                    //Sleep for close NPC
                    if ( npcZoom )
                    {
                        Thread.Sleep(1500);
                    }
                    else
                    {
                        Thread.Sleep(500);
                    }
                }

                _runIndex++;
                //Clear running
                Running = false;
            }
        }
    }
}