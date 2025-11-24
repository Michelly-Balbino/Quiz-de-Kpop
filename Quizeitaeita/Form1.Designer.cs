namespace Quizeitaeita
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pictureGrupo = new PictureBox();
            btnOpcao1 = new Button();
            btnOpcao2 = new Button();
            btnOpcao3 = new Button();
            btnOpcao4 = new Button();
            lblpergunta = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureGrupo).BeginInit();
            SuspendLayout();
            // 
            // pictureGrupo
            // 
            pictureGrupo.Image = Properties.Resources.XLOV;
            pictureGrupo.Location = new Point(169, 14);
            pictureGrupo.Margin = new Padding(5);
            pictureGrupo.Name = "pictureGrupo";
            pictureGrupo.Size = new Size(336, 225);
            pictureGrupo.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureGrupo.TabIndex = 0;
            pictureGrupo.TabStop = false;
            // 
            // btnOpcao1
            // 
            btnOpcao1.BackColor = Color.White;
            btnOpcao1.FlatStyle = FlatStyle.Flat;
            btnOpcao1.Font = new Font("Segoe UI", 12F);
            btnOpcao1.Location = new Point(102, 307);
            btnOpcao1.Name = "btnOpcao1";
            btnOpcao1.Size = new Size(211, 53);
            btnOpcao1.TabIndex = 1;
            btnOpcao1.Tag = "1";
            btnOpcao1.Text = "XLOV";
            btnOpcao1.UseVisualStyleBackColor = false;
            btnOpcao1.Click += CheckAnswerEvent;
            // 
            // btnOpcao2
            // 
            btnOpcao2.BackColor = Color.White;
            btnOpcao2.FlatStyle = FlatStyle.Flat;
            btnOpcao2.Font = new Font("Segoe UI", 12F);
            btnOpcao2.Location = new Point(102, 367);
            btnOpcao2.Name = "btnOpcao2";
            btnOpcao2.Size = new Size(211, 56);
            btnOpcao2.TabIndex = 2;
            btnOpcao2.Tag = "2";
            btnOpcao2.Text = "TXT";
            btnOpcao2.UseVisualStyleBackColor = false;
            btnOpcao2.Click += CheckAnswerEvent;
            // 
            // btnOpcao3
            // 
            btnOpcao3.BackColor = Color.White;
            btnOpcao3.FlatStyle = FlatStyle.Flat;
            btnOpcao3.Font = new Font("Segoe UI", 12F);
            btnOpcao3.Location = new Point(351, 307);
            btnOpcao3.Name = "btnOpcao3";
            btnOpcao3.Size = new Size(211, 53);
            btnOpcao3.TabIndex = 3;
            btnOpcao3.Tag = "3";
            btnOpcao3.Text = "XG";
            btnOpcao3.UseVisualStyleBackColor = false;
            btnOpcao3.Click += CheckAnswerEvent;
            // 
            // btnOpcao4
            // 
            btnOpcao4.BackColor = Color.White;
            btnOpcao4.FlatStyle = FlatStyle.Flat;
            btnOpcao4.Font = new Font("Segoe UI", 12F);
            btnOpcao4.Location = new Point(351, 370);
            btnOpcao4.Name = "btnOpcao4";
            btnOpcao4.Size = new Size(211, 53);
            btnOpcao4.TabIndex = 4;
            btnOpcao4.Tag = "4";
            btnOpcao4.Text = "WINNER";
            btnOpcao4.UseVisualStyleBackColor = false;
            btnOpcao4.Click += CheckAnswerEvent;
            // 
            // lblpergunta
            // 
            lblpergunta.BackColor = Color.Transparent;
            lblpergunta.Font = new Font("Segoe UI Symbol", 14.25F);
            lblpergunta.Location = new Point(82, 254);
            lblpergunta.Name = "lblpergunta";
            lblpergunta.Size = new Size(545, 27);
            lblpergunta.TabIndex = 5;
            lblpergunta.Text = "Qual desse grupo de k-pop pertence esses integrantes?";
            lblpergunta.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(696, 490);
            Controls.Add(lblpergunta);
            Controls.Add(btnOpcao4);
            Controls.Add(btnOpcao3);
            Controls.Add(btnOpcao2);
            Controls.Add(btnOpcao1);
            Controls.Add(pictureGrupo);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(5);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quiz Game";
            ((System.ComponentModel.ISupportInitialize)pictureGrupo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureGrupo;
        private Button btnOpcao1;
        private Button btnOpcao2;
        private Button btnOpcao3;
        private Button btnOpcao4;
        private Label lblpergunta;
    }
}
