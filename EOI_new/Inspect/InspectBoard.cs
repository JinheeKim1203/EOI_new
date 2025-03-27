using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EOI_new.Algorithm;
using EOI_new.Property;
using EOI_new.Teach;
using EOI_new.Core;
using OpenCvSharp;

namespace EOI_new.Inspect
{
    public class InspectBoard
    {
        public InspectBoard()
        {
        }
        //InspWindow라는 설계도(클래스)로 만들어진 검사 창 객체 window를 받아서 검사
        public bool Inspect(InspWindow window)
        {
            if (window is null)
                return false;

            if (window.InspWindowType == Core.InspWindowType.Group)
            {
                GroupWindow group = (GroupWindow)window;
                if (!InspectWindowList(group.Members))
                    return false;
            }
            else
            {
                if (!InspectWindow(window))
                    return false;
            }

            return true;
        }
        //내부적으로 검사 알고리즘들을 실행해서 검사 성공/실패만 판단하는 기능
        private bool InspectWindow(InspWindow window)
        {
            foreach (InspAlgorithm algo in window.AlgorithmList)
            {
                if (!algo.DoInspect())
                    return false;
            }
            return true;
        }
        private bool InspectWindowList(List<InspWindow> windowList)
        {
            if (windowList.Count <= 0)
                return false;

            //ID 윈도우가 매칭알고리즘이 있고, 검사가 되었다면, 오프셋을 얻는다.
            Point alignOffset = new Point(0, 0);
            InspWindow idWindow = windowList.Find(w => w.InspWindowType == Core.InspWindowType.ID);
            if (idWindow != null)
            {
                MatchAlgorithm matchAlgo = (MatchAlgorithm)idWindow.FindInspAlgorithm(InspectType.InspMatch);
                if (matchAlgo.IsUse)
                {
                    if (!InspectWindow(idWindow))
                        return false;

                    if (matchAlgo.IsInspected)
                    {
                        alignOffset = matchAlgo.GetOffset();
                        idWindow.InspArea = idWindow.WindowArea + alignOffset;
                    }
                }
            }

            foreach (InspWindow window in windowList)
            {
                //모든 윈도우에 오프셋 반영
                window.SetInspOffset(alignOffset);
                if (!InspectWindow(idWindow))
                    return false;
            }

            return true;
        }
    }
}
