namespace OsVisualTools
{
    partial class FormCatalog
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            HZH_Controls.Controls.NavigationMenuItem navigationMenuItem1 = new HZH_Controls.Controls.NavigationMenuItem();
            HZH_Controls.Controls.NavigationMenuItem navigationMenuItem2 = new HZH_Controls.Controls.NavigationMenuItem();
            HZH_Controls.Controls.NavigationMenuItem navigationMenuItem3 = new HZH_Controls.Controls.NavigationMenuItem();
            HZH_Controls.Controls.NavigationMenuItem navigationMenuItem4 = new HZH_Controls.Controls.NavigationMenuItem();
            this.ucNavigationMenu = new HZH_Controls.Controls.UCNavigationMenu();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ucNavigationMenu
            // 
            this.ucNavigationMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(61)))), ((int)(((byte)(73)))));
            this.ucNavigationMenu.Font = new System.Drawing.Font("微软雅黑", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ucNavigationMenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            navigationMenuItem1.AnchorRight = false;
            navigationMenuItem1.DataSource = null;
            navigationMenuItem1.HasSplitLintAtTop = false;
            navigationMenuItem1.Icon = null;
            navigationMenuItem1.Items = null;
            navigationMenuItem1.ItemWidth = 100;
            navigationMenuItem1.ShowTip = false;
            navigationMenuItem1.Text = "菜单1";
            navigationMenuItem1.TipText = null;
            navigationMenuItem2.AnchorRight = false;
            navigationMenuItem2.DataSource = null;
            navigationMenuItem2.HasSplitLintAtTop = false;
            navigationMenuItem2.Icon = null;
            navigationMenuItem2.Items = null;
            navigationMenuItem2.ItemWidth = 100;
            navigationMenuItem2.ShowTip = false;
            navigationMenuItem2.Text = "菜单2";
            navigationMenuItem2.TipText = null;
            navigationMenuItem3.AnchorRight = true;
            navigationMenuItem3.DataSource = null;
            navigationMenuItem3.HasSplitLintAtTop = false;
            navigationMenuItem3.Icon = null;
            navigationMenuItem3.Items = null;
            navigationMenuItem3.ItemWidth = 100;
            navigationMenuItem3.ShowTip = false;
            navigationMenuItem3.Text = "菜单3";
            navigationMenuItem3.TipText = null;
            navigationMenuItem4.AnchorRight = true;
            navigationMenuItem4.DataSource = null;
            navigationMenuItem4.HasSplitLintAtTop = false;
            navigationMenuItem4.Icon = null;
            navigationMenuItem4.Items = null;
            navigationMenuItem4.ItemWidth = 100;
            navigationMenuItem4.ShowTip = false;
            navigationMenuItem4.Text = "菜单4";
            navigationMenuItem4.TipText = null;
            this.ucNavigationMenu.Items = new HZH_Controls.Controls.NavigationMenuItem[] {
        navigationMenuItem1,
        navigationMenuItem2,
        navigationMenuItem3,
        navigationMenuItem4};
            this.ucNavigationMenu.Location = new System.Drawing.Point(0, -2);
            this.ucNavigationMenu.Name = "ucNavigationMenu";
            this.ucNavigationMenu.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.ucNavigationMenu.Size = new System.Drawing.Size(527, 82);
            this.ucNavigationMenu.TabIndex = 4;
            this.ucNavigationMenu.TipColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(87)))), ((int)(((byte)(34)))));
            this.ucNavigationMenu.ClickItemed += new System.EventHandler(this.ucNavigationMenu_ClickItemed);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(151, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 26);
            this.label1.TabIndex = 5;
            this.label1.Text = "操作系统实验可视化工具";
            // 
            // FormCatalog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 291);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ucNavigationMenu);
            this.Name = "FormCatalog";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private HZH_Controls.Controls.UCNavigationMenu ucNavigationMenu;
        private System.Windows.Forms.Label label1;
    }
}

