namespace DoAnCuoiKi
{
    partial class ThanhToanMoMo
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
            this.btnpayMoMo = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSoTien = new System.Windows.Forms.TextBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.entityCommand1 = new System.Data.Entity.Core.EntityClient.EntityCommand();
            this.button1 = new System.Windows.Forms.Button();
            this.picqrcode = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picqrcode)).BeginInit();
            this.SuspendLayout();
            // 
            // btnpayMoMo
            // 
            this.btnpayMoMo.BackColor = System.Drawing.Color.Blue;
            this.btnpayMoMo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnpayMoMo.ForeColor = System.Drawing.Color.White;
            this.btnpayMoMo.Location = new System.Drawing.Point(276, 182);
            this.btnpayMoMo.Margin = new System.Windows.Forms.Padding(4);
            this.btnpayMoMo.Name = "btnpayMoMo";
            this.btnpayMoMo.Size = new System.Drawing.Size(135, 50);
            this.btnpayMoMo.TabIndex = 13;
            this.btnpayMoMo.Text = "Tạo QR";
            this.btnpayMoMo.UseVisualStyleBackColor = false;
            this.btnpayMoMo.Click += new System.EventHandler(this.btnpayMoMo_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(31, 137);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Nhập Số Tiền:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(31, 84);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Số Điện Thoại:";
            // 
            // txtSoTien
            // 
            this.txtSoTien.Location = new System.Drawing.Point(190, 135);
            this.txtSoTien.Margin = new System.Windows.Forms.Padding(4);
            this.txtSoTien.Name = "txtSoTien";
            this.txtSoTien.Size = new System.Drawing.Size(252, 22);
            this.txtSoTien.TabIndex = 6;
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(190, 84);
            this.txtSDT.Margin = new System.Windows.Forms.Padding(4);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(252, 22);
            this.txtSDT.TabIndex = 8;
            // 
            // entityCommand1
            // 
            this.entityCommand1.CommandTimeout = 0;
            this.entityCommand1.CommandTree = null;
            this.entityCommand1.Connection = null;
            this.entityCommand1.EnablePlanCaching = true;
            this.entityCommand1.Transaction = null;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button1.Location = new System.Drawing.Point(294, 257);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 43);
            this.button1.TabIndex = 16;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // picqrcode
            // 
            this.picqrcode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picqrcode.Location = new System.Drawing.Point(534, 28);
            this.picqrcode.Margin = new System.Windows.Forms.Padding(4);
            this.picqrcode.Name = "picqrcode";
            this.picqrcode.Size = new System.Drawing.Size(333, 307);
            this.picqrcode.TabIndex = 15;
            this.picqrcode.TabStop = false;
            // 
            // ThanhToanMoMo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(961, 411);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.picqrcode);
            this.Controls.Add(this.btnpayMoMo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSoTien);
            this.Controls.Add(this.txtSDT);
            this.Name = "ThanhToanMoMo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ThanhToan";
            this.Load += new System.EventHandler(this.ThanhToanMoMo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picqrcode)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnpayMoMo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSoTien;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.PictureBox picqrcode;
        private System.Data.Entity.Core.EntityClient.EntityCommand entityCommand1;
        private System.Windows.Forms.Button button1;
    }
}