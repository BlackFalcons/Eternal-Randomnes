
namespace Eternal_Randomness
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.FromNumber = new System.Windows.Forms.MaskedTextBox();
            this.ToNumber = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.RandomNumberText = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RevealerBox = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.RevealerCheckbox = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // FromNumber
            // 
            this.FromNumber.Location = new System.Drawing.Point(12, 31);
            this.FromNumber.Name = "FromNumber";
            this.FromNumber.Size = new System.Drawing.Size(100, 20);
            this.FromNumber.TabIndex = 0;
            this.FromNumber.Text = "1";
            this.FromNumber.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            // 
            // ToNumber
            // 
            this.ToNumber.Location = new System.Drawing.Point(135, 31);
            this.ToNumber.Name = "ToNumber";
            this.ToNumber.Size = new System.Drawing.Size(100, 20);
            this.ToNumber.TabIndex = 1;
            this.ToNumber.Text = "10";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "From number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(132, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "To number";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 57);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(223, 32);
            this.button1.TabIndex = 4;
            this.button1.Text = "Generate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.GetRandomNumber);
            // 
            // RandomNumberText
            // 
            this.RandomNumberText.Font = new System.Drawing.Font("Microsoft Sans Serif", 27F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RandomNumberText.ForeColor = System.Drawing.SystemColors.Highlight;
            this.RandomNumberText.Location = new System.Drawing.Point(6, 16);
            this.RandomNumberText.Name = "RandomNumberText";
            this.RandomNumberText.Size = new System.Drawing.Size(217, 40);
            this.RandomNumberText.TabIndex = 5;
            this.RandomNumberText.Text = "0";
            this.RandomNumberText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.RandomNumberText.Click += new System.EventHandler(this.RandomNumberText_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RevealerBox);
            this.groupBox1.Controls.Add(this.RandomNumberText);
            this.groupBox1.Location = new System.Drawing.Point(12, 95);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(229, 69);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // RevealerBox
            // 
            this.RevealerBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RevealerBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RevealerBox.ForeColor = System.Drawing.SystemColors.Highlight;
            this.RevealerBox.Location = new System.Drawing.Point(6, 16);
            this.RevealerBox.Name = "RevealerBox";
            this.RevealerBox.Size = new System.Drawing.Size(217, 40);
            this.RevealerBox.TabIndex = 6;
            this.RevealerBox.Text = "Click to reveal!";
            this.RevealerBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.RevealerBox.Visible = false;
            this.RevealerBox.Click += new System.EventHandler(this.RevealerCheckboxHide);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.RevealerCheckbox);
            this.groupBox2.Location = new System.Drawing.Point(247, 15);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(113, 149);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Settings";
            // 
            // RevealerCheckbox
            // 
            this.RevealerCheckbox.AutoSize = true;
            this.RevealerCheckbox.Location = new System.Drawing.Point(6, 19);
            this.RevealerCheckbox.Name = "RevealerCheckbox";
            this.RevealerCheckbox.Size = new System.Drawing.Size(93, 17);
            this.RevealerCheckbox.TabIndex = 0;
            this.RevealerCheckbox.Text = "Click to reveal";
            this.RevealerCheckbox.UseVisualStyleBackColor = true;
            this.RevealerCheckbox.CheckedChanged += new System.EventHandler(this.RevealerCheckbox_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 10.25F);
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(130, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Developed by TechDrY";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 196);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ToNumber);
            this.Controls.Add(this.FromNumber);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Eternal Randomiser";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox FromNumber;
        private System.Windows.Forms.MaskedTextBox ToNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label RandomNumberText;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox RevealerCheckbox;
        private System.Windows.Forms.Label RevealerBox;
        private System.Windows.Forms.Label label3;
    }
}

