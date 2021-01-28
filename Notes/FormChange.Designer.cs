
namespace Notes
{
    partial class FormChange
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_RF_ch = new System.Windows.Forms.TextBox();
            this.tb_RB_ch = new System.Windows.Forms.TextBox();
            this.bt_ok = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(116, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "РБ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(116, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "РФ";
            // 
            // tb_RF_ch
            // 
            this.tb_RF_ch.Location = new System.Drawing.Point(22, 24);
            this.tb_RF_ch.Name = "tb_RF_ch";
            this.tb_RF_ch.Size = new System.Drawing.Size(88, 20);
            this.tb_RF_ch.TabIndex = 7;
            this.tb_RF_ch.TextChanged += new System.EventHandler(this.tb_RF_ch_TextChanged);
            // 
            // tb_RB_ch
            // 
            this.tb_RB_ch.Location = new System.Drawing.Point(22, 66);
            this.tb_RB_ch.Name = "tb_RB_ch";
            this.tb_RB_ch.Size = new System.Drawing.Size(88, 20);
            this.tb_RB_ch.TabIndex = 6;
            this.tb_RB_ch.TextChanged += new System.EventHandler(this.tb_RB_ch_TextChanged);
            // 
            // bt_ok
            // 
            this.bt_ok.Location = new System.Drawing.Point(33, 107);
            this.bt_ok.Name = "bt_ok";
            this.bt_ok.Size = new System.Drawing.Size(65, 25);
            this.bt_ok.TabIndex = 11;
            this.bt_ok.Text = "Ok";
            this.bt_ok.UseVisualStyleBackColor = true;
            this.bt_ok.Click += new System.EventHandler(this.bt_ok_Click);
            // 
            // FormChange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Notes.Properties.Resources.bg;
            this.ClientSize = new System.Drawing.Size(149, 162);
            this.Controls.Add(this.bt_ok);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_RF_ch);
            this.Controls.Add(this.tb_RB_ch);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormChange";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Изменить";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_RF_ch;
        private System.Windows.Forms.TextBox tb_RB_ch;
        private System.Windows.Forms.Button bt_ok;
    }
}