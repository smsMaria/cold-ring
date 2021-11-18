namespace ColdRing
{
    partial class AddDemonForm
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
            System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
            System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
            System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
            System.Windows.Forms.Label label1;
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonCansel = new System.Windows.Forms.Button();
            this.InputY = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.InputX = new System.Windows.Forms.TextBox();
            this.Status = new System.Windows.Forms.Label();
            tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            label1 = new System.Windows.Forms.Label();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 3);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 0, 1);
            tableLayoutPanel1.Controls.Add(this.Status, 0, 2);
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanel1.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            tableLayoutPanel1.Size = new System.Drawing.Size(281, 213);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(this.buttonOK, 1, 0);
            tableLayoutPanel2.Controls.Add(this.buttonCansel, 0, 0);
            tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanel2.Location = new System.Drawing.Point(3, 176);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new System.Drawing.Size(275, 34);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // buttonOK
            // 
            this.buttonOK.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonOK.Location = new System.Drawing.Point(140, 3);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(132, 28);
            this.buttonOK.TabIndex = 2;
            this.buttonOK.TabStop = false;
            this.buttonOK.Text = "Добавить";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // buttonCansel
            // 
            this.buttonCansel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonCansel.Location = new System.Drawing.Point(3, 3);
            this.buttonCansel.Name = "buttonCansel";
            this.buttonCansel.Size = new System.Drawing.Size(131, 28);
            this.buttonCansel.TabIndex = 3;
            this.buttonCansel.TabStop = false;
            this.buttonCansel.Text = "Отмена";
            this.buttonCansel.UseVisualStyleBackColor = true;
            this.buttonCansel.Click += new System.EventHandler(this.buttonCansel_Click);
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.36364F));
            tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 83.63636F));
            tableLayoutPanel3.Controls.Add(this.InputY, 1, 1);
            tableLayoutPanel3.Controls.Add(this.label2, 0, 0);
            tableLayoutPanel3.Controls.Add(this.label3, 0, 1);
            tableLayoutPanel3.Controls.Add(this.InputX, 1, 0);
            tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanel3.Location = new System.Drawing.Point(3, 28);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            tableLayoutPanel3.Size = new System.Drawing.Size(275, 98);
            tableLayoutPanel3.TabIndex = 1;
            // 
            // InputY
            // 
            this.InputY.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InputY.Location = new System.Drawing.Point(48, 52);
            this.InputY.Name = "InputY";
            this.InputY.Size = new System.Drawing.Size(224, 22);
            this.InputY.TabIndex = 1;
            this.InputY.Text = "0";
            this.InputY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.InputY.Enter += new System.EventHandler(this.InputX_Click);
            this.InputY.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.InputX_KeyPress);
            this.InputY.Leave += new System.EventHandler(this.InputY_Leave);
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 49);
            this.label2.TabIndex = 10;
            this.label2.Text = "x";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(3, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 49);
            this.label3.TabIndex = 1;
            this.label3.Text = "y";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // InputX
            // 
            this.InputX.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InputX.Location = new System.Drawing.Point(48, 3);
            this.InputX.Name = "InputX";
            this.InputX.Size = new System.Drawing.Size(224, 22);
            this.InputX.TabIndex = 0;
            this.InputX.Text = "0";
            this.InputX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.InputX.Enter += new System.EventHandler(this.InputX_Click);
            this.InputX.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.InputX_KeyPress);
            this.InputX.Leave += new System.EventHandler(this.InputY_Leave);
            // 
            // Status
            // 
            this.Status.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Status.Location = new System.Drawing.Point(3, 129);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(275, 44);
            this.Status.TabIndex = 2;
            this.Status.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.Dock = System.Windows.Forms.DockStyle.Fill;
            label1.Location = new System.Drawing.Point(3, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(275, 25);
            label1.TabIndex = 3;
            label1.Text = "Укажите координаты нового демона:";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // AddDemonForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 213);
            this.ControlBox = false;
            this.Controls.Add(tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddDemonForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавление демона";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AddDemonForm_KeyDown);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonCansel;
        private System.Windows.Forms.TextBox InputY;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox InputX;
        private System.Windows.Forms.Label Status;
    }
}