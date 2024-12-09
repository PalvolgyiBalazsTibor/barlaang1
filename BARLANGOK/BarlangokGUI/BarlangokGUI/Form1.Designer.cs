namespace BarlangokGUI
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
            label1 = new Label();
            azonosito_txtbox = new TextBox();
            btnKereses = new Button();
            label2 = new Label();
            label3 = new Label();
            Hosszusag_txtbox = new TextBox();
            label4 = new Label();
            melyseg_txtbox = new TextBox();
            adatokmentese_btn = new Button();
            neve = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 16);
            label1.Name = "label1";
            label1.Size = new Size(63, 15);
            label1.TabIndex = 0;
            label1.Text = "Azonosító:";
            // 
            // azonosito_txtbox
            // 
            azonosito_txtbox.Location = new Point(81, 13);
            azonosito_txtbox.Name = "azonosito_txtbox";
            azonosito_txtbox.Size = new Size(100, 23);
            azonosito_txtbox.TabIndex = 1;
            // 
            // btnKereses
            // 
            btnKereses.Location = new Point(214, 16);
            btnKereses.Name = "btnKereses";
            btnKereses.Size = new Size(125, 23);
            btnKereses.TabIndex = 2;
            btnKereses.Text = "Barlang keresése";
            btnKereses.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 54);
            label2.Name = "label2";
            label2.Size = new Size(78, 15);
            label2.TabIndex = 3;
            label2.Text = "Barlang neve:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 91);
            label3.Name = "label3";
            label3.Size = new Size(66, 15);
            label3.TabIndex = 4;
            label3.Text = "Hosszúság:";
            // 
            // Hosszusag_txtbox
            // 
            Hosszusag_txtbox.Location = new Point(84, 88);
            Hosszusag_txtbox.Name = "Hosszusag_txtbox";
            Hosszusag_txtbox.Size = new Size(100, 23);
            Hosszusag_txtbox.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 124);
            label4.Name = "label4";
            label4.Size = new Size(54, 15);
            label4.TabIndex = 6;
            label4.Text = "Mélység:";
            // 
            // melyseg_txtbox
            // 
            melyseg_txtbox.Location = new Point(84, 124);
            melyseg_txtbox.Name = "melyseg_txtbox";
            melyseg_txtbox.Size = new Size(100, 23);
            melyseg_txtbox.TabIndex = 7;
            // 
            // adatokmentese_btn
            // 
            adatokmentese_btn.Enabled = false;
            adatokmentese_btn.Location = new Point(214, 116);
            adatokmentese_btn.Name = "adatokmentese_btn";
            adatokmentese_btn.Size = new Size(125, 23);
            adatokmentese_btn.TabIndex = 8;
            adatokmentese_btn.Text = "Adatok mentése";
            adatokmentese_btn.UseVisualStyleBackColor = true;
            // 
            // neve
            // 
            neve.AutoSize = true;
            neve.Location = new Point(96, 54);
            neve.Name = "neve";
            neve.Size = new Size(0, 15);
            neve.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(374, 171);
            Controls.Add(neve);
            Controls.Add(adatokmentese_btn);
            Controls.Add(melyseg_txtbox);
            Controls.Add(label4);
            Controls.Add(Hosszusag_txtbox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnKereses);
            Controls.Add(azonosito_txtbox);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Barlangok";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox azonosito_txtbox;
        private Button btnKereses;
        private Label label2;
        private Label label3;
        private TextBox Hosszusag_txtbox;
        private Label label4;
        private TextBox melyseg_txtbox;
        private Button adatokmentese_btn;
        private Label neve;
    }
}
