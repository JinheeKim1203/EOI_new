using JidamVision.Algorithm;
using JidamVision.Core;
using JidamVision.Teach;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static JidamVision.Property.BinaryInspProp;
using static System.Windows.Forms.MonthCalendar;
using OpenCvSharp;
using JidamVision;


namespace JidamVision.Property
{
    /*
    #BINARY FILTER# - <<<이진화 검사 개발>>> 
    입력된 lower, upper 임계값을 이용해, 영상을 이진화한 후, Filter(area)등을 이용해, 원하는 영역을 찾는다.
    */

    //#BINARY FILTER#7 이진화 하이라이트, 이외에, 이진화 이미지를 보기 위한 옵션
    public enum ShowBinaryMode
    {
        ShowBinaryNone = 0,             //이진화 하이라이트 끄기
        ShowBinaryHighlight,            //이진화 하이라이트 보기
        ShowBinaryOnly                  //배경 없이 이진화 이미지만 보기
    }

    public partial class BinaryInspProp : UserControl
    {
        public event EventHandler<RangeChangedEventArgs> RangeChanged;


        /* NOTE
        public int LowerValue
        {
            get { return trackBarLower.Value; }
        }
        C# 6부터는 위 코드를 더 간결하게 람다(=>) 문법을 사용하여 표현
        */

        // 속성값을 이용하여 이진화 임계값 설정
        public int LowerValue => trackBarLower.Value;
        public int UpperValue => trackBarUpper.Value;




        public BinaryInspProp()
        {
            InitializeComponent();
        }

        public void LoadInspParam()
        {
            // TrackBar 초기 설정
            trackBarLower.ValueChanged += OnValueChanged;
            trackBarUpper.ValueChanged += OnValueChanged;

            trackBarLower.Value = 0;
            trackBarUpper.Value = 128;

            //#BINARY FILTER#8 이진화 필터값을 GUI에 로딩
            InspWindow inspWindow = Global.Inst.InspStage.InspWindow;
            if (inspWindow != null)
            {
                //#INSP WORKER#13 inspWindow에서 이진화 알고리즘 찾는 코드
                BlobAlgorithm blobAlgo = (BlobAlgorithm)inspWindow.FindInspAlgorithm(InspectType.InspBinary);
                if (blobAlgo != null)
                {
                    var cond = blobAlgo.FilterCondition;

                    // 면적 필터 UI 반영
                    txtAreaMin.Text = cond.AreaMin.ToString();
                    txtAreaMax.Text = cond.AreaMax.ToString();
                    chkArea.Checked = cond.UseAreaFilter;
                    txtAreaMin.Enabled = chkArea.Checked;
                    txtAreaMax.Enabled = chkArea.Checked;

                    // 너비 필터 UI 반영
                    txtWidthMin.Text = cond.WidthMin.ToString();
                    txtWidthMax.Text = cond.WidthMax.ToString();
                    chkWidth.Checked = cond.UseWidthFilter;
                    txtWidthMin.Enabled = chkWidth.Checked;
                    txtWidthMax.Enabled = chkWidth.Checked;

                    // 높이 필터 UI 반영
                    txtHeightMin.Text = cond.HeightMin.ToString();
                    txtHeightMax.Text = cond.HeightMax.ToString();
                    chkHeight.Checked = cond.UseHeightFilter;
                    txtHeightMin.Enabled = chkHeight.Checked;
                    txtHeightMax.Enabled = chkHeight.Checked;

                }
            }
        }

        //#BINARY FILTER#10 이진화 옵션을 선택할때마다, 이진화 이미지가 갱신되도록 하는 함수
        private void UpdateBinary()
        {
            bool invert = chkInvert.Checked;
            bool highlight = chkHighlight.Checked;

            ShowBinaryMode showBinaryMode = ShowBinaryMode.ShowBinaryNone;
            if (highlight)
            {
                showBinaryMode = ShowBinaryMode.ShowBinaryHighlight;

                bool showBinary = chkShowBinary.Checked;

                if (showBinary)
                    showBinaryMode = ShowBinaryMode.ShowBinaryOnly;
            }

            RangeChanged?.Invoke(this, new RangeChangedEventArgs(LowerValue, UpperValue, invert, showBinaryMode));
        }

        //#BINARY FILTER#11 GUI 이벤트와 UpdateBinary함수 연동
        private void OnValueChanged(object sender, EventArgs e)
        {
            UpdateBinary();
        }

        private void chkInvert_CheckedChanged(object sender, EventArgs e)
        {
            UpdateBinary();
        }

        private void chkBinaryOnly_CheckedChanged(object sender, EventArgs e)
        {
            UpdateBinary();
        }

        private void chkHighlight_CheckedChanged(object sender, EventArgs e)
        {
            UpdateBinary();
        }


        // ▶ 체크박스 선택 시 TextBox 활성/비활성
        private void chkArea_CheckedChanged(object sender, EventArgs e)
        {
            txtAreaMin.Enabled = chkArea.Checked;
            txtAreaMax.Enabled = chkArea.Checked;
        }

        private void chkWidth_CheckedChanged(object sender, EventArgs e)
        {
            txtWidthMin.Enabled = chkWidth.Checked;
            txtWidthMax.Enabled = chkWidth.Checked;
        }

        private void chkHeight_CheckedChanged(object sender, EventArgs e)
        {
            txtHeightMin.Enabled = chkHeight.Checked;
            txtHeightMax.Enabled = chkHeight.Checked;
        }

        private void UpdateBlobFilter(BlobAlgorithm blobAlgo)
        {
            if (blobAlgo == null) return;
            var cond = blobAlgo.FilterCondition;

            //int.Parse 예외처리(값이 올바르지 않으면 오류가 남)
            try
            {
                // 면적 조건
                cond.UseAreaFilter = chkArea.Checked;
                if (chkArea.Checked)
                {
                    cond.AreaMin = int.Parse(txtAreaMin.Text);
                    cond.AreaMax = int.Parse(txtAreaMax.Text);
                    if (cond.AreaMax <= 0) cond.AreaMax = int.MaxValue;
                }

                // 너비 조건
                cond.UseWidthFilter = chkWidth.Checked;
                if (chkWidth.Checked)
                {
                    cond.WidthMin = int.Parse(txtWidthMin.Text);
                    cond.WidthMax = int.Parse(txtWidthMax.Text);
                    if (cond.WidthMax <= 0) cond.WidthMax = int.MaxValue;
                }

                // 높이 조건
                cond.UseHeightFilter = chkHeight.Checked;
                if (chkHeight.Checked)
                {
                    cond.HeightMin = int.Parse(txtHeightMin.Text);
                    cond.HeightMax = int.Parse(txtHeightMax.Text);
                    if (cond.HeightMax <= 0) cond.HeightMax = int.MaxValue;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("필터 값이 잘못되었습니다.\n" + ex.Message, "입력 오류", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            // 필터 조건 반영
            blobAlgo.FilterCondition = cond;
        }


        private void btnFilter_Click_1(object sender, EventArgs e)
        {
            InspWindow inspWindow = Global.Inst.InspStage.InspWindow;
            if (inspWindow is null)
                return;

            //#INSP WORKER#9 inspWindow에서 이진화 알고리즘 찾는 코드 추가 
            BlobAlgorithm blobAlgo = (BlobAlgorithm)inspWindow.FindInspAlgorithm(InspectType.InspBinary);
            if (blobAlgo is null)
                return;

            BinaryThreshold threshold = new BinaryThreshold();
            threshold.upper = UpperValue;
            threshold.lower = LowerValue;
            threshold.invert = chkInvert.Checked;

            blobAlgo.BinaryThreshold = threshold;

            // 필터 조건 업데이트(최소값, 최대값 입력 시 업데이트)
            UpdateBlobFilter(blobAlgo);

            //#INSP WORKER#10 이진화 검사시, 해당 InspWindow와 이진화 알고리즘만 실행
            Global.Inst.InspStage.InspWorker.TryInspect(inspWindow, InspectType.InspBinary);

            //Mat srcImage = Global.Inst.InspStage.GetMat();

            //if (blobAlgo.DoInspect(srcImage))
            //{
            //    //찾은 영역을 이미지상에서 표시
            //    List<Rect> findArea;
            //    int findCount = blobAlgo.GetResultRect(out findArea);
            //    if (findCount > 0)
            //    {
            //        var cameraForm = MainForm.GetDockForm<CameraForm>();
            //        if (cameraForm != null)
            //        {
            //            cameraForm.AddRect(findArea);
            //        }
            //    }
            //}
        }
    }


    //#BINARY FILTER#9 이진화 관련 이벤트 발생시, 전달할 값 추가(arguement를 추가하는거)
    public class RangeChangedEventArgs : EventArgs
    {
        public int LowerValue { get; }
        public int UpperValue { get; }
        public bool Invert { get; }
        public ShowBinaryMode ShowBinMode { get; }

        public RangeChangedEventArgs(int lowerValue, int upperValue, bool invert, ShowBinaryMode showBinaryMode)
        {
            LowerValue = lowerValue;
            UpperValue = upperValue;
            Invert = invert;
            ShowBinMode = showBinaryMode;
        }
    }
}
