namespace Projeto_Cem_primeiros_números_inteiros
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
            istNumeros = new ListBox();
            btnFor = new Button();
            btnWhile = new Button();
            btnDo = new Button();
            btnLimpar = new Button();
            SuspendLayout();
            // 
            // istNumeros
            // 
            istNumeros.FormattingEnabled = true;
            istNumeros.ItemHeight = 15;
            istNumeros.Location = new Point(12, 12);
            istNumeros.Name = "istNumeros";
            istNumeros.Size = new Size(120, 184);
            istNumeros.TabIndex = 0;
            // 
            // btnFor
            // 
            btnFor.Location = new Point(155, 12);
            btnFor.Name = "btnFor";
            btnFor.Size = new Size(75, 23);
            btnFor.TabIndex = 1;
            btnFor.Text = "Laço For";
            btnFor.UseVisualStyleBackColor = true;
            btnFor.Click += btnFor_Click;
            // 
            // btnWhile
            // 
            btnWhile.Location = new Point(155, 52);
            btnWhile.Name = "btnWhile";
            btnWhile.Size = new Size(75, 23);
            btnWhile.TabIndex = 2;
            btnWhile.Text = "Laço While";
            btnWhile.UseVisualStyleBackColor = true;
            btnWhile.Click += button2_Click;
            // 
            // btnDo
            // 
            btnDo.Location = new Point(155, 94);
            btnDo.Name = "btnDo";
            btnDo.Size = new Size(75, 23);
            btnDo.TabIndex = 3;
            btnDo.Text = "Laço Do-While";
            btnDo.UseVisualStyleBackColor = true;
            btnDo.Click += button3_Click;
            // 
            // btnLimpar
            // 
            btnLimpar.Location = new Point(155, 139);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(75, 23);
            btnLimpar.TabIndex = 4;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = true;
            btnLimpar.Click += button4_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(299, 222);
            Controls.Add(btnLimpar);
            Controls.Add(btnDo);
            Controls.Add(btnWhile);
            Controls.Add(btnFor);
            Controls.Add(istNumeros);
            Name = "Form1";
            Text = "Números Inteiros";
            ResumeLayout(false);
        }

        #endregion

        private ListBox istNumeros;
        private Button btnFor;
        private Button btnWhile;
        private Button btnDo;
        private Button btnLimpar;
    }
}