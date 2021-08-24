
namespace bt1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.laaaaa = new System.Windows.Forms.Label();
            this.txtdayvuanhap = new System.Windows.Forms.TextBox();
            this.txtnhapso = new System.Windows.Forms.TextBox();
            this.txttongle = new System.Windows.Forms.TextBox();
            this.txttongphantutrongday = new System.Windows.Forms.TextBox();
            this.txttongchan = new System.Windows.Forms.TextBox();
            this.btnnhap = new System.Windows.Forms.Button();
            this.btntieptuc = new System.Windows.Forms.Button();
            this.btnthoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(208, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(329, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập Dãy Số Và Tính Tổng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(81, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nhập Số :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(68, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Dãy vừa nhập : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(68, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(195, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tổng các phần tử trong dãy : ";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(68, 269);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 17);
            this.label7.TabIndex = 4;
            this.label7.Text = "Tổng chẵn :";
            // 
            // laaaaa
            // 
            this.laaaaa.AutoSize = true;
            this.laaaaa.Location = new System.Drawing.Point(307, 269);
            this.laaaaa.Name = "laaaaa";
            this.laaaaa.Size = new System.Drawing.Size(68, 17);
            this.laaaaa.TabIndex = 5;
            this.laaaaa.Text = "Tổng lẻ : ";
            // 
            // txtdayvuanhap
            // 
            this.txtdayvuanhap.Location = new System.Drawing.Point(203, 148);
            this.txtdayvuanhap.Name = "txtdayvuanhap";
            this.txtdayvuanhap.Size = new System.Drawing.Size(298, 22);
            this.txtdayvuanhap.TabIndex = 6;
            // 
            // txtnhapso
            // 
            this.txtnhapso.Location = new System.Drawing.Point(180, 100);
            this.txtnhapso.Name = "txtnhapso";
            this.txtnhapso.Size = new System.Drawing.Size(171, 22);
            this.txtnhapso.TabIndex = 7;
            // 
            // txttongle
            // 
            this.txttongle.Location = new System.Drawing.Point(381, 269);
            this.txttongle.Name = "txttongle";
            this.txttongle.Size = new System.Drawing.Size(120, 22);
            this.txttongle.TabIndex = 8;
            // 
            // txttongphantutrongday
            // 
            this.txttongphantutrongday.Location = new System.Drawing.Point(269, 204);
            this.txttongphantutrongday.Name = "txttongphantutrongday";
            this.txttongphantutrongday.Size = new System.Drawing.Size(232, 22);
            this.txttongphantutrongday.TabIndex = 11;
            // 
            // txttongchan
            // 
            this.txttongchan.Location = new System.Drawing.Point(158, 264);
            this.txttongchan.Name = "txttongchan";
            this.txttongchan.Size = new System.Drawing.Size(119, 22);
            this.txttongchan.TabIndex = 12;
            // 
            // btnnhap
            // 
            this.btnnhap.Location = new System.Drawing.Point(402, 96);
            this.btnnhap.Name = "btnnhap";
            this.btnnhap.Size = new System.Drawing.Size(75, 31);
            this.btnnhap.TabIndex = 13;
            this.btnnhap.Text = "Nhập";
            this.btnnhap.UseVisualStyleBackColor = true;
            this.btnnhap.Click += new System.EventHandler(this.btnnhap_Click);
            // 
            // btntieptuc
            // 
            this.btntieptuc.Location = new System.Drawing.Point(158, 332);
            this.btntieptuc.Name = "btntieptuc";
            this.btntieptuc.Size = new System.Drawing.Size(75, 23);
            this.btntieptuc.TabIndex = 14;
            this.btntieptuc.Text = "Tiếp tục";
            this.btntieptuc.UseVisualStyleBackColor = true;
            this.btntieptuc.Click += new System.EventHandler(this.btntieptuc_Click);
            // 
            // btnthoat
            // 
            this.btnthoat.Location = new System.Drawing.Point(337, 332);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(75, 23);
            this.btnthoat.TabIndex = 15;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.btntieptuc);
            this.Controls.Add(this.btnnhap);
            this.Controls.Add(this.txttongchan);
            this.Controls.Add(this.txttongphantutrongday);
            this.Controls.Add(this.txttongle);
            this.Controls.Add(this.txtnhapso);
            this.Controls.Add(this.txtdayvuanhap);
            this.Controls.Add(this.laaaaa);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label laaaaa;
        private System.Windows.Forms.TextBox txtdayvuanhap;
        private System.Windows.Forms.TextBox txtnhapso;
        private System.Windows.Forms.TextBox txttongle;
        private System.Windows.Forms.TextBox txttongphantutrongday;
        private System.Windows.Forms.TextBox txttongchan;
        private System.Windows.Forms.Button btnnhap;
        private System.Windows.Forms.Button btntieptuc;
        private System.Windows.Forms.Button btnthoat;
    }
}

