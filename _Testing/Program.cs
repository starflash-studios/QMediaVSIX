using System;
using System.Collections.Generic;
using System.Linq;

using AudioUtils;

#nullable enable

namespace _Testing {
    internal class Program {
        static void Main( string[] Args ) {
            Console.WriteLine("Displaying volumes.");

            List<AudioProgram> LAP = AudioProgram.GetAudioPrograms().ToList();
            for (int I = 0; I < LAP.Count; I++) { Console.WriteLine($"{I} ... {LAP[I]}"); }

            Console.WriteLine("Displayed all volumes.");

            while (true) {
                Console.Write('\n');

                StageOne:
                Console.Write("\nList ID: ");
                string? LID_St = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(LID_St) || !int.TryParse(LID_St, out int LID) || LID < 0 || LAP.Count <= LID) { goto StageOne; }

                StageTwo:
                Console.Write("\nChange [v]olume, or [m]ute: ");
                switch (Console.ReadKey().KeyChar) {
                    case 'v':
                    case 'V':
                        StageThreeV:
                        Console.WriteLine($"\nCurrent Volume: {LAP[LID].Volume}");
                        Console.Write("Set Volume To (0.0-1.0): ");
                        string? VOL_St = Console.ReadLine();
                        if (string.IsNullOrWhiteSpace(VOL_St) || !float.TryParse(VOL_St, out float VOL) || VOL is < 0.0f or > 1.0f) { goto StageThreeV; }

                        AudioProgram A = LAP[LID];
                        A.Volume = VOL;
                        LAP[LID] = A;

                        Console.WriteLine($"Set as {VOL}.");
                        break;
                    case 'm':
                    case 'M':
                        StageThreeM:
                        Console.WriteLine($"\nCurrent Mute Status: {LAP[LID].IsMuted}");
                        Console.Write("Set Mute To (true/false): ");
                        string? MUT_St = Console.ReadLine();
                        if (string.IsNullOrWhiteSpace(MUT_St) || !bool.TryParse(MUT_St, out bool MUT)) { goto StageThreeM; }

                        AudioProgram B = LAP[LID];
                        B.IsMuted = MUT;
                        LAP[LID] = B;

                        Console.WriteLine($"Set as {MUT}.");
                        break;
                    default:
                        goto StageTwo;
                }

            }

            //_ = Console.ReadKey();
            // ReSharper disable once FunctionNeverReturns
        }
    }
}