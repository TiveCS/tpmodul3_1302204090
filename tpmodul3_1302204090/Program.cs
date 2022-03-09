using System;

namespace tpmodul3_1302204090
{
    internal class Program
    {
        static void Main(string[] args)
        {
            KodePos kodePos = new KodePos();
            kodePos.printKodePos(40286);
            kodePos.printKodePos(50212);

            DoorMachine doorMachine = new DoorMachine();
            Console.WriteLine("Door machine: ");
            doorMachine.kunciPintu();
            doorMachine.bukaPintu();
        }
    }
}
