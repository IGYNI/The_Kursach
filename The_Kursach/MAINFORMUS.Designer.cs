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
            this.Block_Menu_Button_GoOutsuda = new System.Windows.Forms.Button();
            this.Block_Menu_Button_Close = new System.Windows.Forms.Button();
            this.Block_Search = new System.Windows.Forms.Panel();
            this.Block_Contacts = new System.Windows.Forms.Panel();
            this.Timer_Form_ChangePositionByMouseDragAndDrop = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.DebugLabel = new System.Windows.Forms.Label();
            this.Block_Menu.SuspendLayout();
            this.Block_Contacts.SuspendLayout();
            this.SuspendLayout();
            // 
            // Block_Menu
            // 
            this.Block_Menu.AutoSize = true;
            this.Block_Menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(3)))), ((int)(((byte)(65)))));
            this.Block_Menu.Controls.Add(this.Block_Menu_Button_GoOutsuda);
            this.Block_Menu.Controls.Add(this.Block_Menu_Button_Close);
            this.Block_Menu.Location = new System.Drawing.Point(0, 0);
            this.Block_Menu.Name = "Block_Menu";
            this.Block_Menu.Size = new System.Drawing.Size(365, 23);
            this.Block_Menu.TabIndex = 0;
            this.Block_Menu.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Block_Menu_MouseDown);
            this.Block_Menu.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Block_Menu_MouseUp);
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
            this.Block_Contacts.Controls.Add(this.DebugLabel);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            // 
            // DebugLabel
            // 
            this.DebugLabel.AutoSize = true;
            this.DebugLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DebugLabel.Location = new System.Drawing.Point(83, 78);
            this.DebugLabel.Name = "DebugLabel";
            this.DebugLabel.Size = new System.Drawing.Size(109, 39);
            this.DebugLabel.TabIndex = 0;
            this.DebugLabel.Text = "label2";
            // 
            // MAINFORM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(9)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(365, 945);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Block_Contacts);
            this.Controls.Add(this.Block_Search);
            this.Controls.Add(this.Block_Menu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MAINFORM";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MAINFORM_Load);
            this.Block_Menu.ResumeLayout(false);
            this.Block_Contacts.ResumeLayout(false);
            this.Block_Contacts.PerformLayout();
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
        private System.Windows.Forms.Label DebugLabel;
        private System.Windows.Forms.Label label1;
    }
}

