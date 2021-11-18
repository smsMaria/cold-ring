namespace ColdRing
{
    partial class LineSetting
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
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label3;
            this.lineColor = new System.Windows.Forms.Panel();
            this.lineSize = new System.Windows.Forms.NumericUpDown();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.typeLine = new System.Windows.Forms.ComboBox();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.lineSize)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            label2.Location = new System.Drawing.Point(12, 9);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(87, 26);
            label2.TabIndex = 8;
            label2.Text = "Цвет линии";
            label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            label1.Location = new System.Drawing.Point(12, 50);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(87, 26);
            label1.TabIndex = 9;
            label1.Text = "Тип линии";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            label3.Location = new System.Drawing.Point(12, 87);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(129, 25);
            label3.TabIndex = 11;
            label3.Text = "Толщина линии";
            label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lineColor
            // 
            this.lineColor.BackColor = System.Drawing.Color.White;
            this.lineColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lineColor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lineColor.Location = new System.Drawing.Point(140, 9);
            this.lineColor.Name = "lineColor";
            this.lineColor.Size = new System.Drawing.Size(87, 26);
            this.lineColor.TabIndex = 7;
            this.lineColor.Click += new System.EventHandler(this.OnEditColor);
            // 
            // lineSize
            // 
            this.lineSize.Location = new System.Drawing.Point(140, 89);
            this.lineSize.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.lineSize.Name = "lineSize";
            this.lineSize.Size = new System.Drawing.Size(87, 22);
            this.lineSize.TabIndex = 12;
            this.lineSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.lineSize.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.lineSize.ValueChanged += new System.EventHandler(this.lineSize_ValueChanged);
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(18, 125);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(87, 34);
            this.buttonCancel.TabIndex = 14;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // buttonSave
            // 
            this.buttonSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonSave.Location = new System.Drawing.Point(121, 125);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(106, 34);
            this.buttonSave.TabIndex = 13;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            // 
            // typeLine
            // 
            this.typeLine.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.typeLine.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.typeLine.FormattingEnabled = true;
            this.typeLine.Location = new System.Drawing.Point(140, 50);
            this.typeLine.Name = "typeLine";
            this.typeLine.Size = new System.Drawing.Size(87, 23);
            this.typeLine.TabIndex = 15;
            this.typeLine.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.comboBox1_DrawItem);
            // 
            // colorDialog
            // 
            this.colorDialog.FullOpen = true;
            // 
            // LineSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(240, 171);
            this.Controls.Add(this.typeLine);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.lineSize);
            this.Controls.Add(label3);
            this.Controls.Add(label1);
            this.Controls.Add(label2);
            this.Controls.Add(this.lineColor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "LineSetting";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Настройка линии сетки";
            ((System.ComponentModel.ISupportInitialize)(this.lineSize)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel lineColor;
        private System.Windows.Forms.NumericUpDown lineSize;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.ComboBox typeLine;
        private System.Windows.Forms.ColorDialog colorDialog;
    }
}