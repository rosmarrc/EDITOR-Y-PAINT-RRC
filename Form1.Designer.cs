namespace editor_paint_rrc
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btn_editor = new Button();
            btn_paint = new Button();
            SuspendLayout();
            // 
            // btn_editor
            // 
            btn_editor.BackColor = Color.SkyBlue;
            btn_editor.FlatStyle = FlatStyle.Flat;
            btn_editor.Font = new Font("Coluna Rounded", 24F, FontStyle.Bold, GraphicsUnit.Point);
            btn_editor.Location = new Point(111, 165);
            btn_editor.Name = "btn_editor";
            btn_editor.Size = new Size(214, 102);
            btn_editor.TabIndex = 0;
            btn_editor.Text = "Editor de Textos";
            btn_editor.UseVisualStyleBackColor = false;
            btn_editor.Click += button1_Click;
            // 
            // btn_paint
            // 
            btn_paint.BackColor = Color.SkyBlue;
            btn_paint.FlatStyle = FlatStyle.Flat;
            btn_paint.Font = new Font("Coluna Rounded", 24F, FontStyle.Bold, GraphicsUnit.Point);
            btn_paint.Location = new Point(442, 165);
            btn_paint.Name = "btn_paint";
            btn_paint.Size = new Size(214, 102);
            btn_paint.TabIndex = 1;
            btn_paint.Text = "Paint";
            btn_paint.UseVisualStyleBackColor = false;
            btn_paint.Click += button1_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PowderBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_paint);
            Controls.Add(btn_editor);
            Name = "Form1";
            Text = "Apps de RRC";
            FormClosing += Form1_FormClosing;
            ResumeLayout(false);
        }

        #endregion

        private Button btn_editor;
        private Button btn_paint;

    }
}