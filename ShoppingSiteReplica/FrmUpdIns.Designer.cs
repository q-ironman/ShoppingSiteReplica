
namespace ShoppingSiteReplica
{
    partial class FrmUpdIns
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CatNametextBox = new System.Windows.Forms.TextBox();
            this.ParCattextBox = new System.Windows.Forms.TextBox();
            this.upInsBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(94, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(95, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(207, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Parent Name(Optional):";
            // 
            // CatNametextBox
            // 
            this.CatNametextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CatNametextBox.Location = new System.Drawing.Point(308, 71);
            this.CatNametextBox.Name = "CatNametextBox";
            this.CatNametextBox.Size = new System.Drawing.Size(100, 28);
            this.CatNametextBox.TabIndex = 3;
            // 
            // ParCattextBox
            // 
            this.ParCattextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ParCattextBox.Location = new System.Drawing.Point(308, 104);
            this.ParCattextBox.Name = "ParCattextBox";
            this.ParCattextBox.Size = new System.Drawing.Size(100, 28);
            this.ParCattextBox.TabIndex = 4;
            // 
            // upInsBtn
            // 
            this.upInsBtn.Location = new System.Drawing.Point(308, 150);
            this.upInsBtn.Name = "upInsBtn";
            this.upInsBtn.Size = new System.Drawing.Size(100, 34);
            this.upInsBtn.TabIndex = 5;
            this.upInsBtn.Text = "button1";
            this.upInsBtn.UseVisualStyleBackColor = true;
            this.upInsBtn.Click += new System.EventHandler(this.upInsBtn_Click);
            // 
            // FrmUpdIns
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.upInsBtn);
            this.Controls.Add(this.ParCattextBox);
            this.Controls.Add(this.CatNametextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmUpdIns";
            this.Text = "FrmUpdIns";
            this.Load += new System.EventHandler(this.FrmUpdIns_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox CatNametextBox;
        private System.Windows.Forms.TextBox ParCattextBox;
        private System.Windows.Forms.Button upInsBtn;
    }
}