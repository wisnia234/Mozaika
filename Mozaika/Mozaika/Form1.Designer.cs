
namespace Mozaika
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxFormats = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxThumbnailFormats = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.listBoxLayout = new System.Windows.Forms.ListBox();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.progressBarInitialize = new System.Windows.Forms.ProgressBar();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(295, 171);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Format:";
            // 
            // comboBoxFormats
            // 
            this.comboBoxFormats.FormattingEnabled = true;
            this.comboBoxFormats.Location = new System.Drawing.Point(132, 30);
            this.comboBoxFormats.Name = "comboBoxFormats";
            this.comboBoxFormats.Size = new System.Drawing.Size(238, 21);
            this.comboBoxFormats.TabIndex = 2;
            this.comboBoxFormats.SelectedIndexChanged += new System.EventHandler(this.comboBoxFormats_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Format miniatury:";
            // 
            // comboBoxThumbnailFormats
            // 
            this.comboBoxThumbnailFormats.FormattingEnabled = true;
            this.comboBoxThumbnailFormats.Location = new System.Drawing.Point(132, 57);
            this.comboBoxThumbnailFormats.Name = "comboBoxThumbnailFormats";
            this.comboBoxThumbnailFormats.Size = new System.Drawing.Size(238, 21);
            this.comboBoxThumbnailFormats.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Układ:";
            // 
            // listBoxLayout
            // 
            this.listBoxLayout.FormattingEnabled = true;
            this.listBoxLayout.Items.AddRange(new object[] {
            "Poziomy",
            "Pionowy"});
            this.listBoxLayout.Location = new System.Drawing.Point(132, 108);
            this.listBoxLayout.Name = "listBoxLayout";
            this.listBoxLayout.Size = new System.Drawing.Size(71, 30);
            this.listBoxLayout.TabIndex = 6;
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(23, 321);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(765, 23);
            this.progressBar.TabIndex = 9;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // progressBarInitialize
            // 
            this.progressBarInitialize.Location = new System.Drawing.Point(23, 251);
            this.progressBarInitialize.Name = "progressBarInitialize";
            this.progressBarInitialize.Size = new System.Drawing.Size(765, 23);
            this.progressBarInitialize.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 224);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "iniclajizacja obrazu ozaiki";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(33, 291);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "tworzenie mozaiki";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.progressBarInitialize);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.listBoxLayout);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxThumbnailFormats);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxFormats);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxFormats;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxThumbnailFormats;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listBoxLayout;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ProgressBar progressBarInitialize;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

