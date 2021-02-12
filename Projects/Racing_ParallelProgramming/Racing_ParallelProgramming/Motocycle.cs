using System;
using System.Collections.Generic;
using System.Text;

namespace Racing_ParallelProgramming
{
    class Motocycle: Transport
    {
        private static int motoAmount = 0;
        private bool isWithSidecar;

        public Motocycle(double speed, bool withSidecar)
        {
            motoAmount++;
            Name = $"Moto{motoAmount}";
            puncturePosibility = 0.2;
            this.speed = speed;
            isWithSidecar = withSidecar;
        }

        public override void DisplayParameters()
        {
            base.DisplayParameters();
            Console.WriteLine($"\tMotocycle {(isWithSidecar ? "has" : "doesn`t have")} a sidecar");
        }
    }
}
