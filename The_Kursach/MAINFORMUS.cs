using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace The_Kursach
{
    public partial class MAINFORM : Form
    {
        public bool IsDragging = false;
        public Point ExtraCursorPosition;
        public MAINFORM()
        {
            InitializeComponent();
        }

        private void Block_Menu_Button_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Block_Menu_Button_GoOutsuda_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Block_Menu_MouseDown(object sender, MouseEventArgs e)
        {
            IsDragging = true;
            ExtraCursorPosition = Cursor.Position;
            ExtraCursorPosition.X = this.PointToClient(Cursor.Position).X;
            ExtraCursorPosition.Y = this.PointToClient(Cursor.Position).Y;
        }


        private void Timer_Form_ChangePositionByMouseDragAndDrop_Tick(object sender, EventArgs e)
        {
            if (IsDragging)
            {
                Point _currentCursorPositionOnFormInDragAndDrop = Cursor.Position;
                _currentCursorPositionOnFormInDragAndDrop.X -= ExtraCursorPosition.X;
                _currentCursorPositionOnFormInDragAndDrop.Y -= ExtraCursorPosition.Y;
                this.Location = _currentCursorPositionOnFormInDragAndDrop;
            }

            Refresh(); 
        }

        private void Block_Menu_MouseUp(object sender, MouseEventArgs e)
        {
            IsDragging = false;
        }
    }
}
