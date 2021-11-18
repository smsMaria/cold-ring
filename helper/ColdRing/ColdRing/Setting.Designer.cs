namespace ColdRing
{
    partial class Setting
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label4;
            this.colorBack = new System.Windows.Forms.Panel();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.WallColor = new System.Windows.Forms.Panel();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.pictureGridLine = new System.Windows.Forms.PictureBox();
            this.pictureMainGridLine = new System.Windows.Forms.PictureBox();
            this.demonSetting = new ColdRing.ObjectSetting();
            this.SandroSetting = new ColdRing.ObjectSetting();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureGridLine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureMainGridLine)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.Location = new System.Drawing.Point(420, 73);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(93, 26);
            label1.TabIndex = 5;
            label1.Text = "Цвет стены";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            label2.Location = new System.Drawing.Point(420, 27);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(87, 26);
            label2.TabIndex = 6;
            label2.Text = "Цвет фона";
            label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            label3.Location = new System.Drawing.Point(420, 121);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(93, 26);
            label3.TabIndex = 9;
            label3.Text = "Линии сетки";
            label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            label4.Location = new System.Drawing.Point(420, 149);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(93, 52);
            label4.TabIndex = 10;
            label4.Text = "Ведущие линии сетки";
            label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // colorBack
            // 
            this.colorBack.BackColor = System.Drawing.Color.White;
            this.colorBack.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.colorBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.colorBack.Location = new System.Drawing.Point(516, 27);
            this.colorBack.Name = "colorBack";
            this.colorBack.Size = new System.Drawing.Size(87, 26);
            this.colorBack.TabIndex = 3;
            this.colorBack.Click += new System.EventHandler(this.OnEditColor);
            // 
            // colorDialog
            // 
            this.colorDialog.FullOpen = true;
            // 
            // WallColor
            // 
            this.WallColor.BackColor = System.Drawing.Color.Blue;
            this.WallColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.WallColor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.WallColor.Location = new System.Drawing.Point(516, 73);
            this.WallColor.Name = "WallColor";
            this.WallColor.Size = new System.Drawing.Size(87, 26);
            this.WallColor.TabIndex = 4;
            this.WallColor.Click += new System.EventHandler(this.OnEditColor);
            // 
            // buttonSave
            // 
            this.buttonSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonSave.Location = new System.Drawing.Point(516, 235);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(106, 34);
            this.buttonSave.TabIndex = 7;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(413, 235);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(87, 34);
            this.buttonCancel.TabIndex = 8;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // pictureGridLine
            // 
            this.pictureGridLine.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureGridLine.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureGridLine.Location = new System.Drawing.Point(516, 121);
            this.pictureGridLine.Name = "pictureGridLine";
            this.pictureGridLine.Size = new System.Drawing.Size(87, 26);
            this.pictureGridLine.TabIndex = 11;
            this.pictureGridLine.TabStop = false;
            this.pictureGridLine.Click += new System.EventHandler(this.OnOpenLineSetting);
            // 
            // pictureMainGridLine
            // 
            this.pictureMainGridLine.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureMainGridLine.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureMainGridLine.Location = new System.Drawing.Point(516, 163);
            this.pictureMainGridLine.Name = "pictureMainGridLine";
            this.pictureMainGridLine.Size = new System.Drawing.Size(87, 26);
            this.pictureMainGridLine.TabIndex = 12;
            this.pictureMainGridLine.TabStop = false;
            this.pictureMainGridLine.Click += new System.EventHandler(this.OnOpenLineSetting);
            // 
            // demonSetting
            // 
            this.demonSetting.Color = System.Drawing.Color.Black;
            this.demonSetting.FileName = "";
            this.demonSetting.IsColor = true;
            this.demonSetting.Location = new System.Drawing.Point(12, 149);
            this.demonSetting.Name = "demonSetting";
            this.demonSetting.Size = new System.Drawing.Size(386, 120);
            this.demonSetting.TabIndex = 1;
            this.demonSetting.Title = "Обозначение демонов";
            // 
            // SandroSetting
            // 
            this.SandroSetting.Color = System.Drawing.Color.Blue;
            this.SandroSetting.FileName = "";
            this.SandroSetting.IsColor = true;
            this.SandroSetting.Location = new System.Drawing.Point(12, 12);
            this.SandroSetting.Name = "SandroSetting";
            this.SandroSetting.Size = new System.Drawing.Size(386, 120);
            this.SandroSetting.TabIndex = 0;
            this.SandroSetting.Title = "Обозначение Сандро";
            // 
            // Setting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 285);
            this.Controls.Add(this.pictureMainGridLine);
            this.Controls.Add(this.pictureGridLine);
            this.Controls.Add(label4);
            this.Controls.Add(label3);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(label2);
            this.Controls.Add(label1);
            this.Controls.Add(this.WallColor);
            this.Controls.Add(this.colorBack);
            this.Controls.Add(this.demonSetting);
            this.Controls.Add(this.SandroSetting);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Setting";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Настройка";
            ((System.ComponentModel.ISupportInitialize)(this.pictureGridLine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureMainGridLine)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.Button buttonSave;
        public ObjectSetting SandroSetting;
        public ObjectSetting demonSetting;
        public System.Windows.Forms.Panel colorBack;
        public System.Windows.Forms.Panel WallColor;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.PictureBox pictureGridLine;
        private System.Windows.Forms.PictureBox pictureMainGridLine;
    }
}