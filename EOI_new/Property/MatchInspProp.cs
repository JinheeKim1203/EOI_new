using EOI_new.Core;
using EOI_new.Teach;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenCvSharp;
using EOI_new.Algorithm;
using OpenCvSharp.Extensions;

namespace EOI_new.Property
{
    /*
    #MATCH PROP# - <<<템플릿 매칭 개발>>> 
    설정된 ROI 이미지를 이용해, 유사한 이미지를 대상 이미지에서 찾는다.
    [확장영역]은 현재 구현되지 않았음
    [매칭스코어]는 템플릿 매칭 결과가 입력된 스코어보다 큰것만을 유효한 것으로 판단
    [매칭갯수]는 찾고자 하는 패턴의 갯수를 입력
     */

    public partial class MatchInspProp : UserControl
    {
        public event EventHandler<EventArgs> PropertyChanged;

        MatchAlgorithm _matchAlgo = null;
        public MatchInspProp()
        {
            InitializeComponent();

            txtExtendX.Leave += OnUpdateValue;
            txtExtendY.Leave += OnUpdateValue;
            txtScore.Leave += OnUpdateValue;
            txtMatchCount.Leave += OnUpdateValue;
        }
        public void SetAlgorithm(MatchAlgorithm matchAlgo)
        {
            _matchAlgo = matchAlgo;
            SetProperty();
        }

        //#MATCH PROP#7 템플릿 매칭 속성값을 GUI에 설정
        //public void LoadInspParam()
        //{
        //    InspWindow inspWindow = Global.Inst.InspStage.InspWindow;
        //    if (inspWindow is null)
        //        return;

        //    //#INSP WORKER#14 inspWindow에서 매칭 알고리즘 찾는 코드
        //    MatchAlgorithm matchAlgo = (MatchAlgorithm)inspWindow.FindInspAlgorithm(InspectType.InspMatch);
        //    if (matchAlgo is null)
        //        return;

        //    OpenCvSharp.Size extendSize = matchAlgo.ExtSize;
        //    int matchScore = matchAlgo.MatchScore;
        //    int matchCount = matchAlgo.MatchCount;

        //    txtExtendX.Text = extendSize.Width.ToString();
        //    txtExtendY.Text = extendSize.Height.ToString();
        //    txtScore.Text = matchScore.ToString();
        //    txtMatchCount.Text = matchCount.ToString();
        //}

        //#MATCH PROP#10 템플릿 매칭 실행
        private void btnSearch_Click(object sender, EventArgs e)
        {
            InspWindow inspWindow = Global.Inst.InspStage.InspWindow;
            if(inspWindow is null) 
                return;

            //#INSP WORKER#11 inspWindow에서 매칭 알고리즘 찾는 코드 추가
            MatchAlgorithm matchAlgo = (MatchAlgorithm)inspWindow.FindInspAlgorithm(InspectType.InspMatch);
            if (matchAlgo is null)
                return; 

            //GUI에 설정된 정보를 MatchAlgorithm에 설정
            OpenCvSharp.Size extendSize = new OpenCvSharp.Size();
            extendSize.Width = int.Parse(txtExtendX.Text);
            extendSize.Height = int.Parse(txtExtendY.Text);
            int matchScore = int.Parse(txtScore.Text);
            int matchCount = int.Parse(txtMatchCount.Text);

            //InspWindow inspWindow = Global.Inst.InspStage.InspWindow;
            matchAlgo.ExtSize = extendSize;
            matchAlgo.MatchScore = matchScore;
            matchAlgo.MatchCount = matchCount;

            Global.Inst.InspStage.InspWorker.TryInspect(inspWindow, InspectType.InspMatch);
        }

        //#MATCH PROP#9 저장된 ROI이미지 로딩
        private void btnTeach_Click(object sender, EventArgs e)
        {
            InspWindow _inspWindow = Global.Inst.InspStage.InspWindow;
            if (Global.Inst == null)
            {
                MessageBox.Show("Global 인스턴스가 null입니다.");
            }
            else if (Global.Inst.InspStage == null)
            {
                MessageBox.Show("InspStage가 null입니다.");
            }
            else if (Global.Inst.InspStage.InspWindow == null)
            {
                MessageBox.Show("InspWindow가 null입니다.");
            }
            else
            {
                // 모두 null이 아니라면 PatternLearn 호출 가능
                if (_inspWindow.PatternLearn())
                    MessageBox.Show("티칭 성공");
                else
                    MessageBox.Show("티칭 실패");
            }
        }
        public void SetProperty()
        {
            if (_matchAlgo is null)
                return;

            OpenCvSharp.Size extendSize = _matchAlgo.ExtSize;
            int matchScore = _matchAlgo.MatchScore;
            int matchCount = _matchAlgo.MatchCount;

            txtExtendX.Text = extendSize.Width.ToString();
            txtExtendY.Text = extendSize.Height.ToString();
            txtScore.Text = matchScore.ToString();
            txtMatchCount.Text = matchCount.ToString();

            //Mat teachImage = _matchAlgo.GetTemplateImage();
            //if (teachImage != null)
            //{
            //    Bitmap bmpImage = BitmapConverter.ToBitmap(teachImage);
            //    picTeachImage.Image = bmpImage;
            //}
        }
        private void OnUpdateValue(object sender, EventArgs e)
        {
            if (_matchAlgo == null)
                return;

            OpenCvSharp.Size extendSize = _matchAlgo.ExtSize;

            if (!int.TryParse(txtExtendX.Text, out extendSize.Width))
            {
                MessageBox.Show("숫자만 입력 가능합니다.");
                return;
            }

            if (!int.TryParse(txtExtendY.Text, out extendSize.Height))
            {
                MessageBox.Show("숫자만 입력 가능합니다.");
                return;
            }

            int score = _matchAlgo.MatchScore;
            if (!int.TryParse(txtScore.Text, out score))
            {
                MessageBox.Show("숫자만 입력 가능합니다.");
                return;
            };


            int matchCount = _matchAlgo.MatchCount;
            if (!int.TryParse(txtMatchCount.Text, out matchCount))
            {
                MessageBox.Show("숫자만 입력 가능합니다.");
                return;
            }

            _matchAlgo.ExtSize = extendSize;
            _matchAlgo.MatchScore = score;
            _matchAlgo.MatchCount = matchCount;

            PropertyChanged?.Invoke(this, null);
        }
    }
}
