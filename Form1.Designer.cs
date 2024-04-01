namespace ooap_lab1_withoutpattern
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.drawBoard = new System.Windows.Forms.PictureBox();
            this.rectangleButton = new System.Windows.Forms.Button();
            this.circleButton = new System.Windows.Forms.Button();
            this.triangleButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.drawBoard)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.triangleButton);
            this.panel1.Controls.Add(this.circleButton);
            this.panel1.Controls.Add(this.rectangleButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(976, 91);
            this.panel1.TabIndex = 0;
            // 
            // drawBoard
            // 
            this.drawBoard.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.drawBoard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.drawBoard.Location = new System.Drawing.Point(0, 91);
            this.drawBoard.Name = "drawBoard";
            this.drawBoard.Size = new System.Drawing.Size(976, 408);
            this.drawBoard.TabIndex = 1;
            this.drawBoard.TabStop = false;
            this.drawBoard.MouseDown += new System.Windows.Forms.MouseEventHandler(this.drawBoard_MouseDown);
            this.drawBoard.MouseUp += new System.Windows.Forms.MouseEventHandler(this.drawBoard_MouseUp);
            // 
            // rectangleButton
            // 
            this.rectangleButton.Image = global::ooap_lab1_withoutpattern.Properties.Resources.rectangle_icon;
            this.rectangleButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.rectangleButton.Location = new System.Drawing.Point(799, 22);
            this.rectangleButton.Name = "rectangleButton";
            this.rectangleButton.Size = new System.Drawing.Size(97, 47);
            this.rectangleButton.TabIndex = 0;
            this.rectangleButton.Text = "Прямоугольник";
            this.rectangleButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.rectangleButton.UseVisualStyleBackColor = true;
            this.rectangleButton.Click += new System.EventHandler(this.rectangleButton_Click);
            // 
            // circleButton
            // 
            this.circleButton.Image = global::ooap_lab1_withoutpattern.Properties.Resources.circle_icon;
            this.circleButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.circleButton.Location = new System.Drawing.Point(669, 22);
            this.circleButton.Name = "circleButton";
            this.circleButton.Size = new System.Drawing.Size(97, 47);
            this.circleButton.TabIndex = 1;
            this.circleButton.Text = "Круг";
            this.circleButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.circleButton.UseVisualStyleBackColor = true;
            this.circleButton.Click += new System.EventHandler(this.circleButton_Click);
            // 
            // triangleButton
            // 
            this.triangleButton.Image = global::ooap_lab1_withoutpattern.Properties.Resources.triangle_icon;
            this.triangleButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.triangleButton.Location = new System.Drawing.Point(542, 22);
            this.triangleButton.Name = "triangleButton";
            this.triangleButton.Size = new System.Drawing.Size(97, 47);
            this.triangleButton.TabIndex = 2;
            this.triangleButton.Text = "Треугольник";
            this.triangleButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.triangleButton.UseVisualStyleBackColor = true;
            this.triangleButton.Click += new System.EventHandler(this.triangleButton_Click);
            // 
            // button1
            // 
            this.button1.Image = global::ooap_lab1_withoutpattern.Properties.Resources.erase_icon;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(416, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 47);
            this.button1.TabIndex = 3;
            this.button1.Text = "Очистить";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(976, 499);
            this.Controls.Add(this.drawBoard);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.drawBoard)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox drawBoard;
        private System.Windows.Forms.Button triangleButton;
        private System.Windows.Forms.Button circleButton;
        private System.Windows.Forms.Button rectangleButton;
        private System.Windows.Forms.Button button1;
    }
}

