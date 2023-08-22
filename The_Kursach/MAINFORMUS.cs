using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using The_Kursach.SendMessageMechanism.NetForSend;

namespace The_Kursach
{
    public partial class MAINFORM : Form
    {
        public int _current_IDOfUser;
        public string Server_Ip = "127.0.0.11";
        public int Server_Port = 1337;

        private string NameOf_DirectoryWithTXT = "LogInfo",
                       TxtWithLog = "LogInfo.txt";

        public bool IsDragging = false;
        public Point ExtraCursorPosition;

        private ToServer _server;



        public MAINFORM()
        {
            
            InitializeComponent();
        }

        private void MAINFORM_Load(object sender, EventArgs e)
        {
            _server.ConnectToServer(Server_Ip, Server_Port);// ПОДКЛЮЧЕНИЕ К СЕРВЕРУ

            //ПРОВЕРКА ИЛИ СОЗДАНИЕ ЛОГИНА
            if (!Login_Check_Created())
            {
                Random random = new Random();
                _current_IDOfUser = random.Next(0, 99999);
                Login_Create(_current_IDOfUser);

            }
            else
                _current_IDOfUser = Login_Get_ID();
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

        private void Login_Create(int id)
        {
            if (!Directory.Exists(NameOf_DirectoryWithTXT))
            {
                string path = Path.Combine(Environment.CurrentDirectory, NameOf_DirectoryWithTXT);
                Directory.CreateDirectory(path);
            }
            StreamWriter writer = File.CreateText($"{NameOf_DirectoryWithTXT}\x002F{TxtWithLog}");
            using (writer)
            { 
                writer.WriteLine(_current_IDOfUser);
            }
             

        }

        private bool Login_Check_Created()
        {
            if (Directory.Exists(NameOf_DirectoryWithTXT))
            {
                if(File.Exists($"{NameOf_DirectoryWithTXT}'\x002F'{TxtWithLog}"))
                    return true;
                else
                    return false;
            }
            else
                return false;
        }

        

        private int Login_Get_ID() => System.Convert.ToInt32( File.ReadAllText($"{NameOf_DirectoryWithTXT}'\x002F'{TxtWithLog}"));
        

    }
}
