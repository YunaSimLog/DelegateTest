namespace DelegateTestCode
{
    partial class Form1
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
            this.btnApply = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.rdoMode1 = new System.Windows.Forms.RadioButton();
            this.rdoMode2 = new System.Windows.Forms.RadioButton();
            this.gbSelectionMode = new System.Windows.Forms.GroupBox();
            this.rdoMode3 = new System.Windows.Forms.RadioButton();
            this.lbResult = new System.Windows.Forms.Label();
            this.gbSelectionFunc = new System.Windows.Forms.GroupBox();
            this.rdoFunction3 = new System.Windows.Forms.RadioButton();
            this.rdoFunction1 = new System.Windows.Forms.RadioButton();
            this.rdoFunction2 = new System.Windows.Forms.RadioButton();
            this.gbSelectionMode.SuspendLayout();
            this.gbSelectionFunc.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnApply
            // 
            this.btnApply.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnApply.Location = new System.Drawing.Point(12, 152);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(142, 34);
            this.btnApply.TabIndex = 0;
            this.btnApply.Text = "적용";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Location = new System.Drawing.Point(174, 152);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(142, 34);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "닫기";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // rdoMode1
            // 
            this.rdoMode1.AutoSize = true;
            this.rdoMode1.Checked = true;
            this.rdoMode1.Location = new System.Drawing.Point(19, 29);
            this.rdoMode1.Name = "rdoMode1";
            this.rdoMode1.Size = new System.Drawing.Size(61, 16);
            this.rdoMode1.TabIndex = 2;
            this.rdoMode1.TabStop = true;
            this.rdoMode1.Text = "Mode1";
            this.rdoMode1.UseVisualStyleBackColor = true;
            // 
            // rdoMode2
            // 
            this.rdoMode2.AutoSize = true;
            this.rdoMode2.Location = new System.Drawing.Point(19, 51);
            this.rdoMode2.Name = "rdoMode2";
            this.rdoMode2.Size = new System.Drawing.Size(61, 16);
            this.rdoMode2.TabIndex = 3;
            this.rdoMode2.Text = "Mode2";
            this.rdoMode2.UseVisualStyleBackColor = true;
            // 
            // gbSelectionMode
            // 
            this.gbSelectionMode.Controls.Add(this.rdoMode3);
            this.gbSelectionMode.Controls.Add(this.rdoMode1);
            this.gbSelectionMode.Controls.Add(this.rdoMode2);
            this.gbSelectionMode.Location = new System.Drawing.Point(12, 12);
            this.gbSelectionMode.Name = "gbSelectionMode";
            this.gbSelectionMode.Size = new System.Drawing.Size(108, 107);
            this.gbSelectionMode.TabIndex = 4;
            this.gbSelectionMode.TabStop = false;
            this.gbSelectionMode.Text = "모드 선택";
            // 
            // rdoMode3
            // 
            this.rdoMode3.AutoSize = true;
            this.rdoMode3.Location = new System.Drawing.Point(19, 73);
            this.rdoMode3.Name = "rdoMode3";
            this.rdoMode3.Size = new System.Drawing.Size(61, 16);
            this.rdoMode3.TabIndex = 4;
            this.rdoMode3.Text = "Mode3";
            this.rdoMode3.UseVisualStyleBackColor = true;
            // 
            // lbResult
            // 
            this.lbResult.AutoSize = true;
            this.lbResult.Location = new System.Drawing.Point(12, 130);
            this.lbResult.Name = "lbResult";
            this.lbResult.Size = new System.Drawing.Size(29, 12);
            this.lbResult.TabIndex = 5;
            this.lbResult.Text = "결과";
            // 
            // gbSelectionFunc
            // 
            this.gbSelectionFunc.Controls.Add(this.rdoFunction3);
            this.gbSelectionFunc.Controls.Add(this.rdoFunction1);
            this.gbSelectionFunc.Controls.Add(this.rdoFunction2);
            this.gbSelectionFunc.Location = new System.Drawing.Point(126, 12);
            this.gbSelectionFunc.Name = "gbSelectionFunc";
            this.gbSelectionFunc.Size = new System.Drawing.Size(108, 107);
            this.gbSelectionFunc.TabIndex = 5;
            this.gbSelectionFunc.TabStop = false;
            this.gbSelectionFunc.Text = "동작 선택";
            // 
            // rdoFunction3
            // 
            this.rdoFunction3.AutoSize = true;
            this.rdoFunction3.Location = new System.Drawing.Point(19, 73);
            this.rdoFunction3.Name = "rdoFunction3";
            this.rdoFunction3.Size = new System.Drawing.Size(77, 16);
            this.rdoFunction3.TabIndex = 4;
            this.rdoFunction3.Text = "Function3";
            this.rdoFunction3.UseVisualStyleBackColor = true;
            // 
            // rdoFunction1
            // 
            this.rdoFunction1.AutoSize = true;
            this.rdoFunction1.Checked = true;
            this.rdoFunction1.Location = new System.Drawing.Point(19, 29);
            this.rdoFunction1.Name = "rdoFunction1";
            this.rdoFunction1.Size = new System.Drawing.Size(77, 16);
            this.rdoFunction1.TabIndex = 2;
            this.rdoFunction1.TabStop = true;
            this.rdoFunction1.Text = "Function1";
            this.rdoFunction1.UseVisualStyleBackColor = true;
            // 
            // rdoFunction2
            // 
            this.rdoFunction2.AutoSize = true;
            this.rdoFunction2.Location = new System.Drawing.Point(19, 51);
            this.rdoFunction2.Name = "rdoFunction2";
            this.rdoFunction2.Size = new System.Drawing.Size(77, 16);
            this.rdoFunction2.TabIndex = 3;
            this.rdoFunction2.Text = "Function2";
            this.rdoFunction2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 202);
            this.Controls.Add(this.gbSelectionFunc);
            this.Controls.Add(this.lbResult);
            this.Controls.Add(this.gbSelectionMode);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnApply);
            this.Name = "Form1";
            this.Text = "DelegateTest";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbSelectionMode.ResumeLayout(false);
            this.gbSelectionMode.PerformLayout();
            this.gbSelectionFunc.ResumeLayout(false);
            this.gbSelectionFunc.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.RadioButton rdoMode1;
        private System.Windows.Forms.RadioButton rdoMode2;
        private System.Windows.Forms.GroupBox gbSelectionMode;
        private System.Windows.Forms.RadioButton rdoMode3;
        private System.Windows.Forms.Label lbResult;
        private System.Windows.Forms.GroupBox gbSelectionFunc;
        private System.Windows.Forms.RadioButton rdoFunction3;
        private System.Windows.Forms.RadioButton rdoFunction1;
        private System.Windows.Forms.RadioButton rdoFunction2;
    }
}

