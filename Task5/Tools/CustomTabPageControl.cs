using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ISorterProject;

namespace Task5.Tools
{
    public partial class CustomTabPageControl : UserControl
    {
        public CustomTabPageControl()
        {
            InitializeComponent();
        }

        public string SorterName
        {
            get
            {
                return lbSorterName.Text;
            }
            set
            {
                lbSorterName.Text = value;
            }
        }
        public string SwapCount
        {
            get
            {
                return lbSwapCount.Text;
            }
            set
            {
                lbSwapCount.Text = value;
            }
        }
        public string ElementsCount
        {
            get
            {
                return lbElementsCount.Text;
            }
            set
            {
                lbElementsCount.Text = value;
            }
        }
        public string SortingTime
        {
            get
            {
                return lbSortingTime.Text;
            }
            set
            {
                lbSortingTime.Text = value;
            }
        }
        public Label SwapCountTxtLabel
        {
            get
            {
                return lbSwapCountText;
            }
        }
        public Label ElementsCountTxtLabel
        {
            get
            {
                return lbElementsCountText;
            }
        }
        public Label SortingTimeTxtLabel
        {
            get
            {
                return lbSortingTimeText;
            }
        }
        public Button RatioSwapSizeButton
        {
            get
            {
                return btRatioSwapSize;
            }
        }
        public Button RatioTimeSizeButton
        {
            get
            {
                return btRatioTimeSize;
            }
        }

        private void Label_MouseEnter(object sender, EventArgs e)
        {
            Label label = (Label)sender;

            label.ForeColor = Color.DeepSkyBlue;
        }
        private void Label_MouseLeave(object sender, EventArgs e)
        {
            Label label = (Label)sender;

            label.ForeColor = Control.DefaultForeColor;
        }
    }

    public class CustomTabPage : TabPage
    {
        private CustomTabPageControl _control;

        public CustomTabPage()
        {
            _control = new CustomTabPageControl();
            _control.Parent = this;
            _control.Dock = DockStyle.Fill;
        }

        public CustomTabPageControl TabPageControl
        {
            get
            {
                return _control;
            }
            set
            {
                _control = value;
            }
        }
    }
}
