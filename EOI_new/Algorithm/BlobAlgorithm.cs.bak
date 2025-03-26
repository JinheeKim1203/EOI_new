using OpenCvSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace JidamVision.Algorithm
{
    // Blob 필터 조건을 정의하는 클래스 (UI 체크박스/텍스트박스와 연동)
    public class BlobFilterCondition
    {
        // 면적 필터 사용 여부
        public bool UseAreaFilter { get; set; }
        public int AreaMin { get; set; }
        public int AreaMax { get; set; }

        // 너비 필터 사용 여부
        public bool UseWidthFilter { get; set; }
        public int WidthMin { get; set; }
        public int WidthMax { get; set; }

        // 높이 필터 사용 여부
        public bool UseHeightFilter { get; set; }
        public int HeightMin { get; set; }
        public int HeightMax { get; set; }

        // 필터 조건 초기화 함수
        public void Reset()
        {
            UseAreaFilter = true;
            AreaMin = 100;
            AreaMax = 100000;

            UseWidthFilter = false;
            WidthMin = 100;
            WidthMax = 100000;

            UseHeightFilter = false;
            HeightMin = 100;
            HeightMax = 100000;
        }
    }

    //#BINARY FILTER#1 이진화 필터를 위한 클래스

    //이진화 임계값 설정을 구조체로 만들기 (struct로 묶어두면 얘만 가져오면 끝)

    public struct BinaryThreshold
    {
        public int lower;
        public int upper;
        public bool invert;
    }
    public class BlobAlgorithm : InspAlgorithm
    {

        //이진화 필터로 찾은 영역
        private List<Rect> _findArea;

        public BinaryThreshold BinaryThreshold { get; set; } = new BinaryThreshold();
        public BlobFilterCondition FilterCondition { get; set; } = new BlobFilterCondition();

        //픽셀 영역으로 이진화 필터
        public int AreaFilter { get; set; } = 100;

        public BlobAlgorithm()
        {
              //#ABSTRACT ALGORITHM#5 각 함수마다 자신의 알고리즘 타입 설정
            InspectType = InspectType.InspBinary;
            FilterCondition.Reset(); // 필터 조건 기본값 설정

        }

        //#BINARY FILTER#2 이진화 후, 필터를 이용해 원하는 영역을 얻음(doinspect = 핵심검사) 
        //public bool DoInspect(Mat srcImage)
        //{
        //    if (srcImage == null)
        //        return false;

        //    Mat grayImage = new Mat();
        //    if (srcImage.Type() == MatType.CV_8UC3)
        //        Cv2.CvtColor(srcImage, grayImage, ColorConversionCodes.BGR2GRAY);
        //    else
        //        grayImage = srcImage;

        //    Mat binaryImage = new Mat();
        //    Cv2.InRange(grayImage, BinaryThreshold.lower, BinaryThreshold.upper, binaryImage);

        //    if (BinaryThreshold.invert)
        //        binaryImage = ~binaryImage;

        //    if (AreaFilter > 0)
        //    {
        //        if (!BlobFilter(binaryImage, AreaFilter))
        //            return false;
        //    }
        //    return true;
        //}

        //#ABSTRACT ALGORITHM#6 
        //InspAlgorithm을 상속받아, 구현하고, 인자로 입력받던 것을 부모의 _srcImage 이미지 사용
        //검사 시작전 IsInspected = false로 초기화하고, 검사가 정상적으로 완료되면,IsInspected = true로 설정
        public override bool DoInspect()
        {
            IsInspected = false;

            if (_srcImage == null)
                return false;

            Mat grayImage = new Mat();
            if (_srcImage.Type() == MatType.CV_8UC3)
                Cv2.CvtColor(_srcImage, grayImage, ColorConversionCodes.BGR2GRAY);
            else
                grayImage = _srcImage;

            Mat binaryImage = new Mat();
            //Cv2.Threshold(grayImage, binaryMask, lowerValue, upperValue, ThresholdTypes.Binary);
            Cv2.InRange(grayImage, BinaryThreshold.lower, BinaryThreshold.upper, binaryImage);

            if (BinaryThreshold.invert)
                binaryImage = ~binaryImage;

            // Blob 필터링 적용 (조건 기반 영역 추출)
            if (!BlobFilter(binaryImage, FilterCondition))
                return false;

            IsInspected = true;

            return true;
        }


        //#BINARY FILTER#3 이진화 필터처리 함수
        private bool BlobFilter(Mat binImage, BlobFilterCondition filter)
        {
            // 컨투어 찾기
            Point[][] contours;
            HierarchyIndex[] hierarchy;
            Cv2.FindContours(binImage, out contours, out hierarchy, RetrievalModes.External, ContourApproximationModes.ApproxSimple);

            // 필터링된 객체를 담을 리스트
            Mat filteredImage = Mat.Zeros(binImage.Size(), MatType.CV_8UC1);

            if (_findArea is null)
                _findArea = new List<Rect>();

            _findArea.Clear();
            

            foreach (var contour in contours)
            {
                double area = Cv2.ContourArea(contour);


                // 필터링된 객체를 이미지에 그림
                //Cv2.DrawContours(filteredImage, new Point[][] { contour }, -1, Scalar.White, -1);

                // RotatedRect 정보 계산
                //RotatedRect rotatedRect = Cv2.MinAreaRect(contour);

                Rect boundingRect = Cv2.BoundingRect(contour);

                // [면적 필터 조건] 적용
                if (filter.UseAreaFilter && (area < filter.AreaMin || area > filter.AreaMax))
                    continue;

                // [너비 필터 조건] 적용
                if (filter.UseWidthFilter && (boundingRect.Width < filter.WidthMin || boundingRect.Width > filter.WidthMax))
                    continue;

                // [높이 필터 조건] 적용
                if (filter.UseHeightFilter && (boundingRect.Height < filter.HeightMin || boundingRect.Height > filter.HeightMax))
                    continue;

                _findArea.Add(boundingRect);

           

                // RotatedRect 정보 출력
                //Console.WriteLine($"RotatedRect - Center: {rotatedRect.Center}, Size: {rotatedRect.Size}, Angle: {rotatedRect.Angle}");

                // BoundingRect 정보 출력
                //Console.WriteLine($"BoundingRect - X: {boundingRect.X}, Y: {boundingRect.Y}, Width: {boundingRect.Width}, Height: {boundingRect.Height}");
            }

            return true;
        }

        //#BINARY FILTER#4 이진화 영역 반환
        public override int GetResultRect(out List<Rect> resultArea)
        {
            resultArea = null;

            //#ABSTRACT ALGORITHM#7 검사가 완료되지 않았다면, 리턴
            if (!IsInspected)
                return -1;

            if (_findArea is null )
                return -1;

            resultArea = _findArea;
            return resultArea.Count;
        }
    }
}
