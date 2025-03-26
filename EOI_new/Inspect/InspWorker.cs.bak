using JidamVision.Algorithm;
using JidamVision.Core;
using JidamVision.Teach;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenCvSharp;
using JidamVision;

namespace JidamVision.Inspect
{
    public class InspWorker
    {
        public InspWorker()
        {
        }

        //#INSP WORKER#2 InspStage내의 모든 InspWindow들을 검사하는 함수
        public bool RunInspect()
        {
            List<InspWindow> inspWindowList = Global.Inst.InspStage.InspWindowList;
            foreach (var inspWIndow in inspWindowList)
            {
                if (inspWIndow is null)
                    continue;

                List<InspAlgorithm> inspAlgorithmList = inspWIndow.AlgorithmList;
                foreach (var algoritm in inspAlgorithmList)
                {
                    UpdateInspData(algoritm);
                }
            }

            foreach (var inspWIndow in inspWindowList)
            {
                inspWIndow.DoInspect(InspectType.InspNone);
                DisplayResult(inspWIndow, InspectType.InspNone);
            }

            return true;
        }

        //#INSP WORKER#5 특정 InspWindow에 대한 검사 진행
        //inspType이 있다면 그것만을 검사하고, 없다면 InpsWindow내의 모든 알고리즘 검사
        public bool TryInspect(InspWindow inspObj, InspectType inspType)
        {
            if (inspObj is null)
                return false;
            InspAlgorithm inspAlgo = inspObj.FindInspAlgorithm(inspType);
            if(inspAlgo is null)
                return false;   

            if (!UpdateInspData(inspAlgo))
                return false;

            if (!inspObj.DoInspect(inspType))
                return false;

            DisplayResult(inspObj, inspType);
            return true;
        }

        //#INSP WORKER#3 각 알고리즘 타입 별로 검사에 필요한 데이터를 입력하는 함수
        private bool UpdateInspData(InspAlgorithm inspAlgo)
        {
            InspectType inspType = inspAlgo.InspectType;

            switch (inspType)
            {
                case InspectType.InspBinary:
                    {
                        BlobAlgorithm blobAlgo = (BlobAlgorithm)inspAlgo;

                        Mat srcImage = Global.Inst.InspStage.GetMat();
                        blobAlgo.SetInspData(srcImage);
                        break;
                    }

                case InspectType.InspMatch:
                    {
                        MatchAlgorithm matchAlgo = (MatchAlgorithm)inspAlgo;

                        Mat srcImage = Global.Inst.InspStage.GetMat();
                        matchAlgo.SetInspData(srcImage);
                        break;
                    }
                default:
                    {
                        Console.WriteLine($"Not supported InspectType: %s", inspType.ToString());
                        return false;
                    }
            }

            return true;
        }

        //#INSP WORKER#4 InspWindow내의 알고리즘 중에서, 인자로 입력된 알고리즘과 같거나,
        //인자가 None이면 모든 알고리즘의 검사 결과(Rect 영역)를 얻어, cameraForm에 출력한다.
        private bool DisplayResult(InspWindow inspObj, InspectType inspType)
        {
            if (inspObj is null)
                return false;

            List<Rect> totalArea = new List<Rect>();

            List<InspAlgorithm> inspAlgorithmList = inspObj.AlgorithmList;
            foreach (var algorithm in inspAlgorithmList)
            {
                if (algorithm.InspectType != inspType && algorithm.InspectType != InspectType.InspNone)
                    continue;

                List<Rect> resultArea = new List<Rect>();
                int resultCnt = algorithm.GetResultRect(out resultArea);
                if(resultCnt > 0)
                {
                    totalArea.AddRange(resultArea);
                }
            }

            if (totalArea.Count >= 0)
            { 
                //찾은 위치를 이미지상에서 표시
                var cameraForm = MainForm.GetDockForm<CameraForm>();
                if (cameraForm != null)
                {
                    cameraForm.AddRect(totalArea);
                }
            }

            return true;
        }

    }
}
