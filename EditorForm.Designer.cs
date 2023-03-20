namespace editor_paint_rrc
{
    partial class EditorForm
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
            richTextBox1 = new RichTextBox();
            btn_abrir = new Button();
            btn_guardar = new Button();
            openFileDialog1 = new OpenFileDialog();
            saveFileDialog1 = new SaveFileDialog();
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(36, 75);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(697, 336);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            // 
            // btn_abrir
            // 
            btn_abrir.BackColor = Color.SkyBlue;
            btn_abrir.FlatStyle = FlatStyle.Flat;
            btn_abrir.Font = new Font("Comic Sans MS", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn_abrir.Location = new Point(42, 21);
            btn_abrir.Name = "btn_abrir";
            btn_abrir.Size = new Size(156, 48);
            btn_abrir.TabIndex = 1;
            btn_abrir.Text = "Abrir archivo";
            btn_abrir.UseVisualStyleBackColor = false;
            btn_abrir.Click += Btn_abrir_Click;
            // 
            // btn_guardar
            // 
            btn_guardar.BackColor = Color.SkyBlue;
            btn_guardar.FlatStyle = FlatStyle.Flat;
            btn_guardar.Font = new Font("Comic Sans MS", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn_guardar.Location = new Point(204, 21);
            btn_guardar.Name = "btn_guardar";
            btn_guardar.Size = new Size(156, 48);
            btn_guardar.TabIndex = 2;
            btn_guardar.Text = "Guardar Archivo";
            btn_guardar.UseVisualStyleBackColor = false;
            btn_guardar.Click += btn_guardar_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // EditorForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PaleTurquoise;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_guardar);
            Controls.Add(btn_abrir);
            Controls.Add(richTextBox1);
            Name = "EditorForm";
            Text = "EditorForm";
            FormClosing += EditorForm_FormClosing;
            Load += EditorForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox richTextBox1;
        private Button btn_abrir;
        private Button btn_guardar;
        private OpenFileDialog openFileDialog1;
        private SaveFileDialog saveFileDialog1;
    }
}