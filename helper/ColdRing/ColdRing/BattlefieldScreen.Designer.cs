namespace ColdRing
{
    partial class BattlefieldScreen
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
            System.Windows.Forms.Label label1;
            this.ScaleNumber = new System.Windows.Forms.NumericUpDown();
            this.TrackScale = new System.Windows.Forms.TrackBar();
            this.layout = new System.Windows.Forms.TableLayoutPanel();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.hScrollBar1 = new System.Windows.Forms.HScrollBar();
            this.Cover = new System.Windows.Forms.PictureBox();
            this.toolTipXY = new System.Windows.Forms.ToolTip(this.components);
            tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            label1 = new System.Windows.Forms.Label();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ScaleNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackScale)).BeginInit();
            this.layout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Cover)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            tableLayoutPanel1.Controls.Add(this.ScaleNumber, 2, 0);
            tableLayoutPanel1.Controls.Add(this.TrackScale, 1, 0);
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanel1.Location = new System.Drawing.Point(3, 447);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new System.Drawing.Size(586, 29);
            tableLayoutPanel1.TabIndex = 3;
            // 
            // ScaleNumber
            // 
            this.ScaleNumber.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ScaleNumber.Increment = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.ScaleNumber.Location = new System.Drawing.Point(519, 3);
            this.ScaleNumber.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.ScaleNumber.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.ScaleNumber.Name = "ScaleNumber";
            this.ScaleNumber.Size = new System.Drawing.Size(64, 22);
            this.ScaleNumber.TabIndex = 0;
            this.ScaleNumber.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.ScaleNumber.ValueChanged += new System.EventHandler(this.ScaleNumber_ValueChanged);
            // 
            // TrackScale
            // 
            this.TrackScale.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TrackScale.LargeChange = 50;
            this.TrackScale.Location = new System.Drawing.Point(123, 3);
            this.TrackScale.Maximum = 1000;
            this.TrackScale.Minimum = 50;
            this.TrackScale.Name = "TrackScale";
            this.TrackScale.Size = new System.Drawing.Size(390, 23);
            this.TrackScale.SmallChange = 50;
            this.TrackScale.TabIndex = 1;
            this.TrackScale.TickFrequency = 100;
            this.TrackScale.Value = 100;
            this.TrackScale.Scroll += new System.EventHandler(this.TrackScale_Scroll);
            // 
            // label1
            // 
            label1.Dock = System.Windows.Forms.DockStyle.Fill;
            label1.Location = new System.Drawing.Point(3, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(114, 29);
            label1.TabIndex = 2;
            label1.Text = "Масштаб";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // layout
            // 
            this.layout.ColumnCount = 2;
            this.layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.layout.Controls.Add(this.vScrollBar1, 1, 0);
            this.layout.Controls.Add(this.hScrollBar1, 0, 1);
            this.layout.Controls.Add(tableLayoutPanel1, 0, 2);
            this.layout.Controls.Add(this.Cover, 0, 0);
            this.layout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layout.Location = new System.Drawing.Point(0, 0);
            this.layout.Name = "layout";
            this.layout.RowCount = 3;
            this.layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.layout.Size = new System.Drawing.Size(615, 479);
            this.layout.TabIndex = 0;
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vScrollBar1.LargeChange = 100;
            this.vScrollBar1.Location = new System.Drawing.Point(592, 0);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(23, 421);
            this.vScrollBar1.TabIndex = 0;
            this.vScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vScrollBar1_Scroll);
            // 
            // hScrollBar1
            // 
            this.hScrollBar1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hScrollBar1.LargeChange = 100;
            this.hScrollBar1.Location = new System.Drawing.Point(0, 421);
            this.hScrollBar1.Name = "hScrollBar1";
            this.hScrollBar1.Size = new System.Drawing.Size(592, 23);
            this.hScrollBar1.TabIndex = 1;
            this.hScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBar1_Scroll);
            // 
            // Cover
            // 
            this.Cover.BackColor = System.Drawing.Color.White;
            this.Cover.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Cover.Location = new System.Drawing.Point(3, 3);
            this.Cover.Name = "Cover";
            this.Cover.Size = new System.Drawing.Size(586, 415);
            this.Cover.TabIndex = 4;
            this.Cover.TabStop = false;
            this.Cover.Paint += new System.Windows.Forms.PaintEventHandler(this.Cover_Paint);
            this.Cover.MouseLeave += new System.EventHandler(this.Cover_MouseLeave);
            this.Cover.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Cover_MouseMove);
            // 
            // toolTipXY
            // 
            this.toolTipXY.UseAnimation = false;
            this.toolTipXY.UseFading = false;
            // 
            // BattlefieldScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.layout);
            this.DoubleBuffered = true;
            this.Name = "BattlefieldScreen";
            this.Size = new System.Drawing.Size(615, 479);
            this.Resize += new System.EventHandler(this.BattlefieldScreen_Resize);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ScaleNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackScale)).EndInit();
            this.layout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Cover)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel layout;
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.HScrollBar hScrollBar1;
        private System.Windows.Forms.NumericUpDown ScaleNumber;
        private System.Windows.Forms.TrackBar TrackScale;
        private System.Windows.Forms.PictureBox Cover;
        private System.Windows.Forms.ToolTip toolTipXY;
    }
}
