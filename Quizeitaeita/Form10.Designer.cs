namespace Quizeitaeita
{
    partial class Form10
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
            lblpergunta = new Label();
            btnOpcao4 = new Button();
            btnOpcao3 = new Button();
            btnOpcao2 = new Button();
            btnOpcao1 = new Button();
            pictureGrupo = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureGrupo).BeginInit();
            SuspendLayout();
            // 
            // lblpergunta
            // 
            lblpergunta.Location = new Point(71, 285);
            lblpergunta.Name = "lblpergunta";
            lblpergunta.Size = new Size(555, 27);
            lblpergunta.TabIndex = 49;
            lblpergunta.Text = "Qual desse grupo de k-pop pertence esses integrantes?";
            lblpergunta.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnOpcao4
            // 
            btnOpcao4.Location = new Point(303, 389);
            btnOpcao4.Name = "btnOpcao4";
            btnOpcao4.Size = new Size(226, 57);
            btnOpcao4.TabIndex = 48;
            btnOpcao4.Tag = "4";
            btnOpcao4.Text = "WINNER";
            btnOpcao4.UseVisualStyleBackColor = true;
            // 
            // btnOpcao3
            // 
            btnOpcao3.Location = new Point(303, 326);
            btnOpcao3.Name = "btnOpcao3";
            btnOpcao3.Size = new Size(226, 57);
            btnOpcao3.TabIndex = 47;
            btnOpcao3.Tag = "3";
            btnOpcao3.Text = "XG";
            btnOpcao3.UseVisualStyleBackColor = true;
            // 
            // btnOpcao2
            // 
            btnOpcao2.Location = new Point(71, 386);
            btnOpcao2.Name = "btnOpcao2";
            btnOpcao2.Size = new Size(226, 60);
            btnOpcao2.TabIndex = 46;
            btnOpcao2.Tag = "2";
            btnOpcao2.Text = "TXT";
            btnOpcao2.UseVisualStyleBackColor = true;
            // 
            // btnOpcao1
            // 
            btnOpcao1.Location = new Point(71, 326);
            btnOpcao1.Name = "btnOpcao1";
            btnOpcao1.Size = new Size(226, 57);
            btnOpcao1.TabIndex = 45;
            btnOpcao1.Tag = "1";
            btnOpcao1.Text = "XLOV";
            btnOpcao1.UseVisualStyleBackColor = true;
            // 
            // pictureGrupo
            // 
            pictureGrupo.Image = Properties.Resources._2NE1;
            pictureGrupo.Location = new Point(143, 45);
            pictureGrupo.Margin = new Padding(5);
            pictureGrupo.Name = "pictureGrupo";
            pictureGrupo.Size = new Size(336, 225);
            pictureGrupo.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureGrupo.TabIndex = 44;
            pictureGrupo.TabStop = false;
            // 
            // Form10
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
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
            Name = "Form10";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form10";
            ((System.ComponentModel.ISupportInitialize)pictureGrupo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label lblpergunta;
        private Button btnOpcao4;
        private Button btnOpcao3;
        private Button btnOpcao2;
        private Button btnOpcao1;
        private PictureBox pictureGrupo;
    }
}