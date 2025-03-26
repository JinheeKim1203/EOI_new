using EOI_new.Algorithm;
using EOI_new.Core;
using EOI_new.Grab;
using EOI_new.Setting;
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
using static EOI_new.Algorithm.FmInspAlgorithm;
using static System.Windows.Forms.MonthCalendar;

namespace EOI_new.Property
{
    public partial class FmInspProp : UserControl
    {

        public FmInspProp()
        {
            InitializeComponent();
        }

        public void LoadInspParam()
        {

            //#BINARY FILTER#8 이진화 필터값을 GUI에 로딩
            InspWindow inspWindow = Global.Inst.InspStage.InspWindow;
            if (inspWindow is null)
                return;

            //#INSP WORKER#13 inspWindow에서 이진화 알고리즘 찾는 코드
            FmInspAlgorithm fmAlgo = (FmInspAlgorithm)inspWindow.FindInspAlgorithm(InspectType.InspFm);
            if (fmAlgo is null)
                return;

            int diffGv = fmAlgo.DifferanceGv;
            txtDiffGv.Text = diffGv.ToString();

            OpenCvSharp.Size size = fmAlgo.size;

            txtSizeX.Text = size.Width.ToString();
            txtSizeY.Text = size.Height.ToString();

            //컬러 타입을 콤보박스에 추가
            cbDiffGvColor.DataSource = Enum.GetValues(typeof(DiffGVColor)).Cast<DiffGVColor>().ToList();


        }
    }
}
