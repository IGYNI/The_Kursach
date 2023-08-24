namespace The_Kursach
{
    partial class MAINFORM
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MAINFORM));
            this.Block_Menu = new System.Windows.Forms.Panel();
            this._currentLabelOfIdOfUser = new System.Windows.Forms.Label();
            this.Block_Menu_Button_GoOutsuda = new System.Windows.Forms.Button();
            this.Block_Menu_Button_Close = new System.Windows.Forms.Button();
            this.Block_Search = new System.Windows.Forms.Panel();
            this.Block_Contacts = new System.Windows.Forms.Panel();
            this.Timer_Form_ChangePositionByMouseDragAndDrop = new System.Windows.Forms.Timer(this.components);
            this.Send_TextBox = new System.Windows.Forms.TextBox();
            this.Send_Btn = new System.Windows.Forms.Button();
            this.Send_Temp_Log = new System.Windows.Forms.Label();
            this.Block_Menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // Block_Menu
            // 
            this.Block_Menu.AutoSize = true;
            this.Block_Menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(3)))), ((int)(((byte)(65)))));
            this.Block_Menu.Controls.Add(this._currentLabelOfIdOfUser);
            this.Block_Menu.Controls.Add(this.Block_Menu_Button_GoOutsuda);
            this.Block_Menu.Controls.Add(this.Block_Menu_Button_Close);
            this.Block_Menu.Location = new System.Drawing.Point(0, 0);
            this.Block_Menu.Name = "Block_Menu";
            this.Block_Menu.Size = new System.Drawing.Size(365, 23);
            this.Block_Menu.TabIndex = 0;
            this.Block_Menu.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Block_Menu_MouseDown);
            this.Block_Menu.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Block_Menu_MouseUp);
            // 
            // _currentLabelOfIdOfUser
            // 
            this._currentLabelOfIdOfUser.AutoSize = true;
            this._currentLabelOfIdOfUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this._currentLabelOfIdOfUser.Location = new System.Drawing.Point(3, 4);
            this._currentLabelOfIdOfUser.Name = "_currentLabelOfIdOfUser";
            this._currentLabelOfIdOfUser.Size = new System.Drawing.Size(35, 13);
            this._currentLabelOfIdOfUser.TabIndex = 3;
            this._currentLabelOfIdOfUser.Text = "label1";
            // 
            // Block_Menu_Button_GoOutsuda
            // 
            this.Block_Menu_Button_GoOutsuda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Block_Menu_Button_GoOutsuda.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(3)))), ((int)(((byte)(65)))));
            this.Block_Menu_Button_GoOutsuda.Image = ((System.Drawing.Image)(resources.GetObject("Block_Menu_Button_GoOutsuda.Image")));
            this.Block_Menu_Button_GoOutsuda.Location = new System.Drawing.Point(326, 0);
            this.Block_Menu_Button_GoOutsuda.Name = "Block_Menu_Button_GoOutsuda";
            this.Block_Menu_Button_GoOutsuda.Size = new System.Drawing.Size(20, 20);
            this.Block_Menu_Button_GoOutsuda.TabIndex = 2;
            this.Block_Menu_Button_GoOutsuda.UseVisualStyleBackColor = true;
            this.Block_Menu_Button_GoOutsuda.Click += new System.EventHandler(this.Block_Menu_Button_GoOutsuda_Click);
            // 
            // Block_Menu_Button_Close
            // 
            this.Block_Menu_Button_Close.Dock = System.Windows.Forms.DockStyle.Right;
            this.Block_Menu_Button_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Block_Menu_Button_Close.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(3)))), ((int)(((byte)(65)))));
            this.Block_Menu_Button_Close.Image = ((System.Drawing.Image)(resources.GetObject("Block_Menu_Button_Close.Image")));
            this.Block_Menu_Button_Close.Location = new System.Drawing.Point(345, 0);
            this.Block_Menu_Button_Close.Name = "Block_Menu_Button_Close";
            this.Block_Menu_Button_Close.Size = new System.Drawing.Size(20, 23);
            this.Block_Menu_Button_Close.TabIndex = 0;
            this.Block_Menu_Button_Close.UseVisualStyleBackColor = true;
            this.Block_Menu_Button_Close.Click += new System.EventHandler(this.Block_Menu_Button_Close_Click);
            // 
            // Block_Search
            // 
            this.Block_Search.AutoSize = true;
            this.Block_Search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(4)))), ((int)(((byte)(123)))));
            this.Block_Search.Location = new System.Drawing.Point(-1, 20);
            this.Block_Search.Name = "Block_Search";
            this.Block_Search.Size = new System.Drawing.Size(365, 33);
            this.Block_Search.TabIndex = 1;
            // 
            // Block_Contacts
            // 
            this.Block_Contacts.AutoSize = true;
            this.Block_Contacts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(25)))), ((int)(((byte)(148)))));
            this.Block_Contacts.Location = new System.Drawing.Point(0, 53);
            this.Block_Contacts.Name = "Block_Contacts";
            this.Block_Contacts.Size = new System.Drawing.Size(365, 206);
            this.Block_Contacts.TabIndex = 2;
            // 
            // Timer_Form_ChangePositionByMouseDragAndDrop
            // 
            this.Timer_Form_ChangePositionByMouseDragAndDrop.Enabled = true;
            this.Timer_Form_ChangePositionByMouseDragAndDrop.Interval = 10;
            this.Timer_Form_ChangePositionByMouseDragAndDrop.Tick += new System.EventHandler(this.Timer_Form_ChangePositionByMouseDragAndDrop_Tick);
            // 
            // Send_TextBox
            // 
            this.Send_TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Send_TextBox.Location = new System.Drawing.Point(0, 846);
            this.Send_TextBox.Name = "Send_TextBox";
            this.Send_TextBox.Size = new System.Drawing.Size(325, 29);
            this.Send_TextBox.TabIndex = 3;
            this.Send_TextBox.TextChanged += new System.EventHandler(this.Send_TextBox_TextChanged);
            // 
            // Send_Btn
            // 
            this.Send_Btn.Location = new System.Drawing.Point(324, 846);
            this.Send_Btn.Name = "Send_Btn";
            this.Send_Btn.Size = new System.Drawing.Size(40, 29);
            this.Send_Btn.TabIndex = 4;
            this.Send_Btn.Text = " Senf";
            this.Send_Btn.UseVisualStyleBackColor = true;
            this.Send_Btn.Click += new System.EventHandler(this.Send_Btn_Click);
            // 
            // Send_Temp_Log
            // 
            this.Send_Temp_Log.AutoSize = true;
            this.Send_Temp_Log.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Send_Temp_Log.ForeColor = System.Drawing.Color.Yellow;
            this.Send_Temp_Log.Location = new System.Drawing.Point(2, 262);
            this.Send_Temp_Log.Name = "Send_Temp_Log";
            this.Send_Temp_Log.Size = new System.Drawing.Size(0, 16);
            this.Send_Temp_Log.TabIndex = 5;
            // 
            // MAINFORM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(9)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(365, 945);
            this.Controls.Add(this.Send_Temp_Log);
            this.Controls.Add(this.Send_Btn);
            this.Controls.Add(this.Send_TextBox);
            this.Controls.Add(this.Block_Contacts);
            this.Controls.Add(this.Block_Search);
            this.Controls.Add(this.Block_Menu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MAINFORM";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MAINFORM_Load);
            this.Block_Menu.ResumeLayout(false);
            this.Block_Menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Block_Menu;
        private System.Windows.Forms.Panel Block_Search;
        private System.Windows.Forms.Panel Block_Contacts;
        private System.Windows.Forms.Button Block_Menu_Button_Close;
        private System.Windows.Forms.Button Block_Menu_Button_GoOutsuda;
        private System.Windows.Forms.Timer Timer_Form_ChangePositionByMouseDragAndDrop;
        private System.Windows.Forms.Label _currentLabelOfIdOfUser;
        private System.Windows.Forms.TextBox Send_TextBox;
        private System.Windows.Forms.Button Send_Btn;
        private System.Windows.Forms.Label Send_Temp_Log;
    }
}

