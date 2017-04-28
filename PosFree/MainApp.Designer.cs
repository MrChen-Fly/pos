namespace PosFree
{
    partial class MainApp
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
            this.MainPanel = new System.Windows.Forms.Panel();
            this.CenterPanel = new System.Windows.Forms.Panel();
            this.SPXX_View = new System.Windows.Forms.ListView();
            this.SPXX_XH = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SPXX_BM = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SPXX_MC = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SPXX_SL = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SPXX_ZK = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SPXX_JE = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FootPanel = new System.Windows.Forms.Panel();
            this.bd_info = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.hyk_info = new System.Windows.Forms.Panel();
            this.foot_null = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.HeaderPanel = new System.Windows.Forms.Panel();
            this.header_center = new System.Windows.Forms.Panel();
            this.header_right = new System.Windows.Forms.Panel();
            this.header_left = new System.Windows.Forms.Panel();
            this.spxx_input = new System.Windows.Forms.TextBox();
            this.spmc_label = new System.Windows.Forms.Label();
            this.sp_input = new System.Windows.Forms.Label();
            this.label_network = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.MainPanel.SuspendLayout();
            this.CenterPanel.SuspendLayout();
            this.FootPanel.SuspendLayout();
            this.bd_info.SuspendLayout();
            this.foot_null.SuspendLayout();
            this.HeaderPanel.SuspendLayout();
            this.header_center.SuspendLayout();
            this.header_left.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.Controls.Add(this.CenterPanel);
            this.MainPanel.Controls.Add(this.FootPanel);
            this.MainPanel.Controls.Add(this.HeaderPanel);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(1348, 721);
            this.MainPanel.TabIndex = 1;
            // 
            // CenterPanel
            // 
            this.CenterPanel.BackColor = System.Drawing.SystemColors.Control;
            this.CenterPanel.Controls.Add(this.SPXX_View);
            this.CenterPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CenterPanel.Location = new System.Drawing.Point(0, 150);
            this.CenterPanel.Name = "CenterPanel";
            this.CenterPanel.Size = new System.Drawing.Size(1348, 371);
            this.CenterPanel.TabIndex = 2;
            // 
            // SPXX_View
            // 
            this.SPXX_View.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.SPXX_XH,
            this.SPXX_BM,
            this.SPXX_MC,
            this.SPXX_SL,
            this.SPXX_ZK,
            this.SPXX_JE});
            this.SPXX_View.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SPXX_View.Location = new System.Drawing.Point(0, 0);
            this.SPXX_View.Name = "SPXX_View";
            this.SPXX_View.Size = new System.Drawing.Size(1348, 371);
            this.SPXX_View.TabIndex = 0;
            this.SPXX_View.UseCompatibleStateImageBehavior = false;
            this.SPXX_View.View = System.Windows.Forms.View.Details;
            // 
            // SPXX_XH
            // 
            this.SPXX_XH.Text = "序号";
            this.SPXX_XH.Width = 50;
            // 
            // SPXX_BM
            // 
            this.SPXX_BM.Text = "商品编码";
            this.SPXX_BM.Width = 150;
            // 
            // SPXX_MC
            // 
            this.SPXX_MC.Text = "商品名称";
            this.SPXX_MC.Width = 200;
            // 
            // SPXX_SL
            // 
            this.SPXX_SL.Text = "数量";
            this.SPXX_SL.Width = 50;
            // 
            // SPXX_ZK
            // 
            this.SPXX_ZK.Text = "折扣";
            this.SPXX_ZK.Width = 100;
            // 
            // SPXX_JE
            // 
            this.SPXX_JE.Text = "金额";
            this.SPXX_JE.Width = 100;
            // 
            // FootPanel
            // 
            this.FootPanel.BackColor = System.Drawing.SystemColors.Control;
            this.FootPanel.Controls.Add(this.bd_info);
            this.FootPanel.Controls.Add(this.hyk_info);
            this.FootPanel.Controls.Add(this.foot_null);
            this.FootPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.FootPanel.Location = new System.Drawing.Point(0, 521);
            this.FootPanel.Name = "FootPanel";
            this.FootPanel.Size = new System.Drawing.Size(1348, 200);
            this.FootPanel.TabIndex = 1;
            // 
            // bd_info
            // 
            this.bd_info.Controls.Add(this.groupBox1);
            this.bd_info.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bd_info.Location = new System.Drawing.Point(200, 0);
            this.bd_info.Name = "bd_info";
            this.bd_info.Size = new System.Drawing.Size(1148, 160);
            this.bd_info.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1148, 160);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "本单信息";
            // 
            // hyk_info
            // 
            this.hyk_info.Dock = System.Windows.Forms.DockStyle.Left;
            this.hyk_info.Location = new System.Drawing.Point(0, 0);
            this.hyk_info.Name = "hyk_info";
            this.hyk_info.Size = new System.Drawing.Size(200, 160);
            this.hyk_info.TabIndex = 2;
            // 
            // foot_null
            // 
            this.foot_null.Controls.Add(this.label1);
            this.foot_null.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.foot_null.Location = new System.Drawing.Point(0, 160);
            this.foot_null.Name = "foot_null";
            this.foot_null.Size = new System.Drawing.Size(1348, 40);
            this.foot_null.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // HeaderPanel
            // 
            this.HeaderPanel.Controls.Add(this.header_center);
            this.HeaderPanel.Controls.Add(this.header_right);
            this.HeaderPanel.Controls.Add(this.header_left);
            this.HeaderPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.HeaderPanel.Location = new System.Drawing.Point(0, 0);
            this.HeaderPanel.Name = "HeaderPanel";
            this.HeaderPanel.Size = new System.Drawing.Size(1348, 150);
            this.HeaderPanel.TabIndex = 0;
            // 
            // header_center
            // 
            this.header_center.Controls.Add(this.groupBox2);
            this.header_center.Dock = System.Windows.Forms.DockStyle.Fill;
            this.header_center.Location = new System.Drawing.Point(200, 0);
            this.header_center.Name = "header_center";
            this.header_center.Size = new System.Drawing.Size(948, 150);
            this.header_center.TabIndex = 2;
            // 
            // header_right
            // 
            this.header_right.Dock = System.Windows.Forms.DockStyle.Right;
            this.header_right.Location = new System.Drawing.Point(1148, 0);
            this.header_right.Name = "header_right";
            this.header_right.Size = new System.Drawing.Size(200, 150);
            this.header_right.TabIndex = 1;
            // 
            // header_left
            // 
            this.header_left.Controls.Add(this.spxx_input);
            this.header_left.Controls.Add(this.spmc_label);
            this.header_left.Controls.Add(this.sp_input);
            this.header_left.Controls.Add(this.label_network);
            this.header_left.Dock = System.Windows.Forms.DockStyle.Left;
            this.header_left.Location = new System.Drawing.Point(0, 0);
            this.header_left.Name = "header_left";
            this.header_left.Size = new System.Drawing.Size(200, 150);
            this.header_left.TabIndex = 0;
            // 
            // spxx_input
            // 
            this.spxx_input.Location = new System.Drawing.Point(15, 81);
            this.spxx_input.Name = "spxx_input";
            this.spxx_input.Size = new System.Drawing.Size(156, 25);
            this.spxx_input.TabIndex = 3;
            // 
            // spmc_label
            // 
            this.spmc_label.AutoSize = true;
            this.spmc_label.Location = new System.Drawing.Point(12, 123);
            this.spmc_label.Name = "spmc_label";
            this.spmc_label.Size = new System.Drawing.Size(82, 15);
            this.spmc_label.TabIndex = 2;
            this.spmc_label.Text = "商品名称：";
            // 
            // sp_input
            // 
            this.sp_input.AutoSize = true;
            this.sp_input.Location = new System.Drawing.Point(12, 63);
            this.sp_input.Name = "sp_input";
            this.sp_input.Size = new System.Drawing.Size(112, 15);
            this.sp_input.TabIndex = 1;
            this.sp_input.Text = "请输入商品编码";
            // 
            // label_network
            // 
            this.label_network.AutoSize = true;
            this.label_network.Location = new System.Drawing.Point(12, 9);
            this.label_network.Name = "label_network";
            this.label_network.Size = new System.Drawing.Size(67, 15);
            this.label_network.TabIndex = 0;
            this.label_network.Text = "网络状态";
            // 
            // groupBox2
            // 
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(948, 150);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "上单信息";
            // 
            // MainApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1348, 721);
            this.Controls.Add(this.MainPanel);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainApp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Appcation";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.MainPanel.ResumeLayout(false);
            this.CenterPanel.ResumeLayout(false);
            this.FootPanel.ResumeLayout(false);
            this.bd_info.ResumeLayout(false);
            this.foot_null.ResumeLayout(false);
            this.foot_null.PerformLayout();
            this.HeaderPanel.ResumeLayout(false);
            this.header_center.ResumeLayout(false);
            this.header_left.ResumeLayout(false);
            this.header_left.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Panel CenterPanel;
        private System.Windows.Forms.Panel FootPanel;
        private System.Windows.Forms.Panel HeaderPanel;
        private System.Windows.Forms.ListView SPXX_View;
        private System.Windows.Forms.ColumnHeader SPXX_XH;
        private System.Windows.Forms.ColumnHeader SPXX_BM;
        private System.Windows.Forms.ColumnHeader SPXX_MC;
        private System.Windows.Forms.ColumnHeader SPXX_SL;
        private System.Windows.Forms.ColumnHeader SPXX_ZK;
        private System.Windows.Forms.ColumnHeader SPXX_JE;
        private System.Windows.Forms.Panel header_center;
        private System.Windows.Forms.Panel header_right;
        private System.Windows.Forms.Panel header_left;
        private System.Windows.Forms.TextBox spxx_input;
        private System.Windows.Forms.Label spmc_label;
        private System.Windows.Forms.Label sp_input;
        private System.Windows.Forms.Label label_network;
        private System.Windows.Forms.Panel bd_info;
        private System.Windows.Forms.Panel hyk_info;
        private System.Windows.Forms.Panel foot_null;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

