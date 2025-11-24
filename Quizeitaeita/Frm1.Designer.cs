namespace Quizeitaeita
{
    partial class Frm1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm1));
            label1 = new Label();
            label2 = new Label();
            btnIniciar = new Button();
            btnFechar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Century Gothic", 39.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(161, 85);
            label1.Name = "label1";
            label1.Size = new Size(394, 63);
            label1.TabIndex = 0;
            label1.Text = "Quiz de K-Pop";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Symbol", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(161, 165);
            label2.Name = "label2";
            label2.Size = new Size(382, 20);
            label2.TabIndex = 1;
            label2.Text = "Será que você realmente conhece algum desses grupos?";
            label2.Click += label2_Click;
            // 
            // btnIniciar
            // 
            btnIniciar.BackColor = Color.White;
            btnIniciar.FlatStyle = FlatStyle.Flat;
            btnIniciar.Font = new Font("Segoe UI", 12F);
            btnIniciar.Location = new Point(261, 237);
            btnIniciar.Name = "btnIniciar";
            btnIniciar.Size = new Size(122, 30);
            btnIniciar.TabIndex = 2;
            btnIniciar.Text = "Inicar";
            btnIniciar.UseVisualStyleBackColor = false;
            btnIniciar.Click += btnIniciar_Click;
            // 
            // btnFechar
            // 
            btnFechar.BackColor = Color.White;
            btnFechar.FlatStyle = FlatStyle.Flat;
            btnFechar.Font = new Font("Segoe UI", 12F);
            btnFechar.Location = new Point(261, 273);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(122, 30);
            btnFechar.TabIndex = 3;
            btnFechar.Text = "Fechar";
            btnFechar.UseVisualStyleBackColor = false;
            btnFechar.Click += btnFechar_Click;
            // 
            // Frm1
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(680, 451);
            Controls.Add(btnFechar);
            Controls.Add(btnIniciar);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(5, 5, 5, 5);
            Name = "Frm1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Frm1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button btnIniciar;
        private Button btnFechar;
    }
}