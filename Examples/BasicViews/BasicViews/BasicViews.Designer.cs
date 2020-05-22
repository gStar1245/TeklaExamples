namespace BasicViews
{
    partial class BasicViews
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
            this.BtnCreate = new System.Windows.Forms.Button();
            this.createTopView = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.create3dView = new System.Windows.Forms.CheckBox();
            this.createEndView = new System.Windows.Forms.CheckBox();
            this.createFrontView = new System.Windows.Forms.CheckBox();
            this.openDrawings = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnCreate
            // 
            this.BtnCreate.Location = new System.Drawing.Point(12, 45);
            this.BtnCreate.Name = "BtnCreate";
            this.BtnCreate.Size = new System.Drawing.Size(66, 22);
            this.BtnCreate.TabIndex = 4;
            this.BtnCreate.Text = "Create";
            this.BtnCreate.UseVisualStyleBackColor = true;
            // 
            // createTopView
            // 
            this.createTopView.AutoSize = true;
            this.createTopView.Location = new System.Drawing.Point(15, 28);
            this.createTopView.Name = "createTopView";
            this.createTopView.Size = new System.Drawing.Size(76, 16);
            this.createTopView.TabIndex = 1;
            this.createTopView.Text = "Top view";
            this.createTopView.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.create3dView);
            this.groupBox1.Controls.Add(this.createEndView);
            this.groupBox1.Controls.Add(this.createFrontView);
            this.groupBox1.Controls.Add(this.createTopView);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox1.Location = new System.Drawing.Point(125, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(175, 169);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Views to be created";
            // 
            // create3dView
            // 
            this.create3dView.AutoSize = true;
            this.create3dView.Location = new System.Drawing.Point(15, 91);
            this.create3dView.Name = "create3dView";
            this.create3dView.Size = new System.Drawing.Size(67, 16);
            this.create3dView.TabIndex = 4;
            this.create3dView.Text = "3d view";
            this.create3dView.UseVisualStyleBackColor = true;
            // 
            // createEndView
            // 
            this.createEndView.AutoSize = true;
            this.createEndView.Location = new System.Drawing.Point(15, 70);
            this.createEndView.Name = "createEndView";
            this.createEndView.Size = new System.Drawing.Size(76, 16);
            this.createEndView.TabIndex = 3;
            this.createEndView.Text = "End view";
            this.createEndView.UseVisualStyleBackColor = true;
            // 
            // createFrontView
            // 
            this.createFrontView.AutoSize = true;
            this.createFrontView.Location = new System.Drawing.Point(15, 49);
            this.createFrontView.Name = "createFrontView";
            this.createFrontView.Size = new System.Drawing.Size(82, 16);
            this.createFrontView.TabIndex = 2;
            this.createFrontView.Text = "Front view";
            this.createFrontView.UseVisualStyleBackColor = true;
            // 
            // openDrawings
            // 
            this.openDrawings.AutoSize = true;
            this.openDrawings.Location = new System.Drawing.Point(12, 73);
            this.openDrawings.Name = "openDrawings";
            this.openDrawings.Size = new System.Drawing.Size(110, 16);
            this.openDrawings.TabIndex = 6;
            this.openDrawings.Text = "Open drawings";
            this.openDrawings.UseVisualStyleBackColor = true;
            // 
            // BasicViews
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 169);
            this.Controls.Add(this.BtnCreate);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.openDrawings);
            this.Name = "BasicViews";
            this.Text = "Create basic Views";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnCreate;
        private System.Windows.Forms.CheckBox createTopView;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox create3dView;
        private System.Windows.Forms.CheckBox createEndView;
        private System.Windows.Forms.CheckBox createFrontView;
        private System.Windows.Forms.CheckBox openDrawings;
    }
}

