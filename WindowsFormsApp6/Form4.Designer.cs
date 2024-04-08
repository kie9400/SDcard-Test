namespace WindowsFormsApp6
{
    partial class Form4
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label = new System.Windows.Forms.Label();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.포트닫기 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(81, 9);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(83, 20);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(89, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 12);
            this.label1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "포트선택";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(81, 103);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(183, 53);
            this.button1.TabIndex = 3;
            this.button1.Text = "저장하기";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(7, 38);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(69, 12);
            this.label.TabIndex = 4;
            this.label.Text = "저장할 내용";
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(81, 35);
            this.txt1.Multiline = true;
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(388, 59);
            this.txt1.TabIndex = 5;
            // 
            // 포트닫기
            // 
            this.포트닫기.Location = new System.Drawing.Point(170, 9);
            this.포트닫기.Name = "포트닫기";
            this.포트닫기.Size = new System.Drawing.Size(96, 20);
            this.포트닫기.TabIndex = 13;
            this.포트닫기.Text = "연결";
            this.포트닫기.UseVisualStyleBackColor = true;
            this.포트닫기.Click += new System.EventHandler(this.포트닫기_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 168);
            this.Controls.Add(this.포트닫기);
            this.Controls.Add(this.txt1);
            this.Controls.Add(this.label);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form4";
            this.Text = "파일 저장 테스트";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.Button 포트닫기;
    }
}

