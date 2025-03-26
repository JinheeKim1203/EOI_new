using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenCvSharp;


namespace JidamVision.Algorithm
{
    public class FmInspAlgorithm : InspAlgorithm
    {

        public int DifferanceGv { get; set; } = 50;

        public Size size { get; set; } = new Size(10, 10);
        //public int SizeX { get; set; } = 10;
        //public int SizeY { get; set; } = 10;

        public enum DiffGVColor
        {
            White = 0,
            Black,
            All
        }

        public FmInspAlgorithm()
        {
            //#ABSTRACT ALGORITHM#5 각 함수마다 자신의 알고리즘 타입 설정
            InspectType = InspectType.InspFm;
        }

        public override bool DoInspect()
        {
            return true;
        }
    }
}
