namespace WindowsFormsApp1
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
            this.btnAttack = new System.Windows.Forms.Button();
            this.btnDodge = new System.Windows.Forms.Button();
            this.btnSpell = new System.Windows.Forms.Button();
            this.txtDescription = new System.Windows.Forms.RichTextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtHealth = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAttack
            // 
            this.btnAttack.Location = new System.Drawing.Point(12, 355);
            this.btnAttack.Name = "btnAttack";
            this.btnAttack.Size = new System.Drawing.Size(75, 23);
            this.btnAttack.TabIndex = 0;
            this.btnAttack.Text = "Attack";
            this.btnAttack.UseVisualStyleBackColor = true;
            this.btnAttack.Click += new System.EventHandler(this.btnAttack_Click);
            // 
            // btnDodge
            // 
            this.btnDodge.Location = new System.Drawing.Point(12, 413);
            this.btnDodge.Name = "btnDodge";
            this.btnDodge.Size = new System.Drawing.Size(75, 23);
            this.btnDodge.TabIndex = 1;
            this.btnDodge.Text = "Dodge";
            this.btnDodge.UseVisualStyleBackColor = true;
            this.btnDodge.Click += new System.EventHandler(this.btnDodge_Click);
            // 
            // btnSpell
            // 
            this.btnSpell.Location = new System.Drawing.Point(12, 384);
            this.btnSpell.Name = "btnSpell";
            this.btnSpell.Size = new System.Drawing.Size(75, 23);
            this.btnSpell.TabIndex = 2;
            this.btnSpell.Text = "Spell";
            this.btnSpell.UseVisualStyleBackColor = true;
            this.btnSpell.Click += new System.EventHandler(this.btnSpell_Click);
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(239, 12);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(364, 302);
            this.txtDescription.TabIndex = 4;
            this.txtDescription.Text = "";
            this.txtDescription.TextChanged += new System.EventHandler(this.txtDescription_TextChanged);
            // 
            // btnExit
            // 
            this.btnExit.Enabled = false;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnExit.Location = new System.Drawing.Point(296, 355);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(235, 73);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit Dragon Cave!";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Visible = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtHealth
            // 
            this.txtHealth.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F);
            this.txtHealth.ForeColor = System.Drawing.Color.Red;
            this.txtHealth.Location = new System.Drawing.Point(133, 12);
            this.txtHealth.Name = "txtHealth";
            this.txtHealth.Size = new System.Drawing.Size(100, 41);
            this.txtHealth.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 37);
            this.label1.TabIndex = 7;
            this.label1.Text = "Health";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 535);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtHealth);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.btnSpell);
            this.Controls.Add(this.btnDodge);
            this.Controls.Add(this.btnAttack);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAttack;
        private System.Windows.Forms.Button btnDodge;
        private System.Windows.Forms.Button btnSpell;
        private System.Windows.Forms.RichTextBox txtDescription;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtHealth;
        private System.Windows.Forms.Label label1;
    }
}

