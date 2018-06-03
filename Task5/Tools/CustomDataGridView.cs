using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task5.Tools
{
    public class CustomDataGridView : DataGridView
    {
        private Tuple<int, int> _firstCellToRedraw = null;
        private Tuple<int, int> _secondCellToRedraw = null;
        
        public CustomDataGridView()
        {
            DoubleBuffered = true;
        }

        public Tuple<int, int> FirstCellToRedraw
        {
            get
            {
                return _firstCellToRedraw;
            }
            set
            {
                _firstCellToRedraw = value;                             
            }
        }
        public Tuple<int, int> SecondCellToRedraw
        {
            get
            {
                return _secondCellToRedraw;
            }
            set
            {
                _secondCellToRedraw = value;                
            }
        }
    }
}
