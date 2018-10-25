namespace MVC
{
    partial class Form1
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
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.carbohidratosTextBox = new System.Windows.Forms.TextBox();
            this.nombreLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.comidasList = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.grasasTextBox = new System.Windows.Forms.TextBox();
            this.proteinasTextBox = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.Location = new System.Drawing.Point(160, 49);
            this.nombreTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(148, 26);
            this.nombreTextBox.TabIndex = 0;
            this.nombreTextBox.TextChanged += new System.EventHandler(this.nombreTextBox_TextChanged);
            // 
            // carbohidratosTextBox
            // 
            this.carbohidratosTextBox.Location = new System.Drawing.Point(160, 109);
            this.carbohidratosTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.carbohidratosTextBox.Name = "carbohidratosTextBox";
            this.carbohidratosTextBox.Size = new System.Drawing.Size(148, 26);
            this.carbohidratosTextBox.TabIndex = 1;
            this.carbohidratosTextBox.TextChanged += new System.EventHandler(this.emailTextBox_TextChanged);
            // 
            // nombreLabel
            // 
            this.nombreLabel.AutoSize = true;
            this.nombreLabel.Location = new System.Drawing.Point(33, 54);
            this.nombreLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nombreLabel.Name = "nombreLabel";
            this.nombreLabel.Size = new System.Drawing.Size(65, 20);
            this.nombreLabel.TabIndex = 2;
            this.nombreLabel.Text = "Nombre";
            this.nombreLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(33, 112);
            this.emailLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(109, 20);
            this.emailLabel.TabIndex = 3;
            this.emailLabel.Text = "Carbohidratos";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(119, 309);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 35);
            this.button1.TabIndex = 4;
            this.button1.Text = "Agregar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comidasList
            // 
            this.comidasList.FormattingEnabled = true;
            this.comidasList.ItemHeight = 20;
            this.comidasList.Location = new System.Drawing.Point(414, 99);
            this.comidasList.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comidasList.Name = "comidasList";
            this.comidasList.Size = new System.Drawing.Size(670, 304);
            this.comidasList.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 230);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Grasas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 172);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Proteinas";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // grasasTextBox
            // 
            this.grasasTextBox.Location = new System.Drawing.Point(160, 227);
            this.grasasTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grasasTextBox.Name = "grasasTextBox";
            this.grasasTextBox.Size = new System.Drawing.Size(148, 26);
            this.grasasTextBox.TabIndex = 7;
            this.grasasTextBox.TextChanged += new System.EventHandler(this.grasasTextBox_TextChanged);
            // 
            // proteinasTextBox
            // 
            this.proteinasTextBox.Location = new System.Drawing.Point(160, 172);
            this.proteinasTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.proteinasTextBox.Name = "proteinasTextBox";
            this.proteinasTextBox.Size = new System.Drawing.Size(148, 26);
            this.proteinasTextBox.TabIndex = 6;
            this.proteinasTextBox.TextChanged += new System.EventHandler(this.proteinasTextBox_TextChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(693, 426);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 35);
            this.button2.TabIndex = 10;
            this.button2.Text = "Eliminar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(715, 55);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Listado";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.grasasTextBox);
            this.Controls.Add(this.proteinasTextBox);
            this.Controls.Add(this.comidasList);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.nombreLabel);
            this.Controls.Add(this.carbohidratosTextBox);
            this.Controls.Add(this.nombreTextBox);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.TextBox carbohidratosTextBox;
        private System.Windows.Forms.Label nombreLabel;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox comidasList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox grasasTextBox;
        private System.Windows.Forms.TextBox proteinasTextBox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
    }
}

