namespace DelegateTestCode_20231212
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
            this.gbSelection = new System.Windows.Forms.GroupBox();
            this.rdoMode3 = new System.Windows.Forms.RadioButton();
            this.lbResult = new System.Windows.Forms.Label();
            this.gbSelection.SuspendLayout();
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
            // gbSelection
            // 
            this.gbSelection.Controls.Add(this.rdoMode3);
            this.gbSelection.Controls.Add(this.rdoMode1);
            this.gbSelection.Controls.Add(this.rdoMode2);
            this.gbSelection.Location = new System.Drawing.Point(12, 12);
            this.gbSelection.Name = "gbSelection";
            this.gbSelection.Size = new System.Drawing.Size(142, 107);
            this.gbSelection.TabIndex = 4;
            this.gbSelection.TabStop = false;
            this.gbSelection.Text = "선택";
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 202);
            this.Controls.Add(this.lbResult);
            this.Controls.Add(this.gbSelection);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnApply);
            this.Name = "Form1";
            this.Text = "DelegateTest";
            this.gbSelection.ResumeLayout(false);
            this.gbSelection.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.RadioButton rdoMode1;
        private System.Windows.Forms.RadioButton rdoMode2;
        private System.Windows.Forms.GroupBox gbSelection;
        private System.Windows.Forms.RadioButton rdoMode3;
        private System.Windows.Forms.Label lbResult;
    }
}

