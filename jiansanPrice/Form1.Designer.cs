namespace jiansanPrice
{
    partial class Form1
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.sumPerson = new System.Windows.Forms.TextBox();
            this.sumPrice = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.afterPrice = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.submitButton = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.帮会 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.人数 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.每个帮的价格 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.调剂后价格 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::jiansanPrice.Properties.Resources.splash;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(713, 107);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(221, 456);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "总人数";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // sumPerson
            // 
            this.sumPerson.Location = new System.Drawing.Point(292, 454);
            this.sumPerson.Name = "sumPerson";
            this.sumPerson.Size = new System.Drawing.Size(100, 21);
            this.sumPerson.TabIndex = 3;
            // 
            // sumPrice
            // 
            this.sumPrice.Location = new System.Drawing.Point(88, 454);
            this.sumPrice.Name = "sumPrice";
            this.sumPrice.Size = new System.Drawing.Size(100, 21);
            this.sumPrice.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(16, 456);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "总金钱";
            // 
            // afterPrice
            // 
            this.afterPrice.Location = new System.Drawing.Point(481, 454);
            this.afterPrice.Name = "afterPrice";
            this.afterPrice.Size = new System.Drawing.Size(100, 21);
            this.afterPrice.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(409, 456);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 19);
            this.label3.TabIndex = 6;
            this.label3.Text = "调剂后";
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(605, 452);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(75, 23);
            this.submitButton.TabIndex = 8;
            this.submitButton.Text = "按我按我";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToOrderColumns = true;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.帮会,
            this.人数,
            this.每个帮的价格,
            this.调剂后价格});
            this.dataGridView.Location = new System.Drawing.Point(12, 134);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowTemplate.Height = 23;
            this.dataGridView.Size = new System.Drawing.Size(713, 306);
            this.dataGridView.TabIndex = 9;
            // 
            // 帮会
            // 
            this.帮会.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.帮会.HeaderText = "帮会";
            this.帮会.MinimumWidth = 100;
            this.帮会.Name = "帮会";
            // 
            // 人数
            // 
            this.人数.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.人数.HeaderText = "人数";
            this.人数.Name = "人数";
            // 
            // 每个帮的价格
            // 
            this.每个帮的价格.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.每个帮的价格.HeaderText = "每个帮的价格";
            this.每个帮的价格.Name = "每个帮的价格";
            // 
            // 调剂后价格
            // 
            this.调剂后价格.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.调剂后价格.HeaderText = "调剂后价格";
            this.调剂后价格.Name = "调剂后价格";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 504);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.afterPrice);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.sumPrice);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.sumPerson);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "青衫隐强势招人工资计算器";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox sumPerson;
        private System.Windows.Forms.TextBox sumPrice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox afterPrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn 帮会;
        private System.Windows.Forms.DataGridViewTextBoxColumn 人数;
        private System.Windows.Forms.DataGridViewTextBoxColumn 每个帮的价格;
        private System.Windows.Forms.DataGridViewTextBoxColumn 调剂后价格;
    }
}

