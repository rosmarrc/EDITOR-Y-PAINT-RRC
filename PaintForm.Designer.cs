namespace editor_paint_rrc
{
    partial class PaintForm
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
            colorDialog1 = new ColorDialog();
            panel1 = new Panel();
            btnColor = new Button();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Location = new Point(53, 71);
            panel1.Name = "panel1";
            panel1.Size = new Size(421, 328);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            panel1.MouseDown += panel1_MouseDown_1;
            panel1.MouseMove += panel1_MouseMove;
            panel1.MouseUp += panel1_MouseUp;
            // 
            // btnColor
            // 
            btnColor.Location = new Point(55, 23);
            btnColor.Name = "btnColor";
            btnColor.Size = new Size(138, 23);
            btnColor.TabIndex = 1;
            btnColor.Text = "color";
            btnColor.UseVisualStyleBackColor = true;
            btnColor.Click += btnColor_Click;
            // 
            // PaintForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PaleTurquoise;
            ClientSize = new Size(800, 450);
            Controls.Add(btnColor);
            Controls.Add(panel1);
            Name = "PaintForm";
            Text = "PaintForm";
            FormClosing += PaintForm_FormClosing;
            ResumeLayout(false);
        }

        #endregion

        private ColorDialog colorDialog1;
        private Panel panel1;
        private Button btnColor;
    }
}