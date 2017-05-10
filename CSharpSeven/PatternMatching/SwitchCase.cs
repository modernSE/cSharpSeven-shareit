using CSharpSeven.Deconstruction;
using System;

namespace CSharpSeven.PatternMatching
{
    class SwitchCase
    {
        void OldDemo(object someValue)
        {
            switch (someValue)
            {
                case 'c':
                    break;
                case "s":
                    break;
                case 42:
                    break;
                case Version.OLD:
                    break;
            }
        }

        void NewDemo(object someValue)
        {
            switch (someValue)
            {
                case null:
                    break;
                case 42:
                    break;
                case char c:
                    break;
                case string s:
                    break;
                case int i:
                    break;
                case Version.NEW:
                    break;
                case MyPoint origin when origin.X is 0 && origin.Y == 0:
                    Console.WriteLine("i am a special point, i go first");
                    break;
                case MyPoint p:
                    Console.WriteLine("i am too generic, i have to come last");
                    break;
            }
        }
    }

    enum Version { OLD, NEW};
}
