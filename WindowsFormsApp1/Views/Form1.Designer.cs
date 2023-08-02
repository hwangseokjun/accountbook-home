
namespace WindowsFormsApp1.Views
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
            this.dgv_report = new System.Windows.Forms.DataGridView();
            this.dtp_from = new System.Windows.Forms.DateTimePicker();
            this.dtp_to = new System.Windows.Forms.DateTimePicker();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_search = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tp_category = new System.Windows.Forms.TabPage();
            this.dgv_category = new System.Windows.Forms.DataGridView();
            this.tp_store = new System.Windows.Forms.TabPage();
            this.dgv_store = new System.Windows.Forms.DataGridView();
            this.tp_expenseType = new System.Windows.Forms.TabPage();
            this.dgv_expenseType = new System.Windows.Forms.DataGridView();
            this.txt_income = new System.Windows.Forms.TextBox();
            this.dtp_input = new System.Windows.Forms.DateTimePicker();
            this.txt_description = new System.Windows.Forms.TextBox();
            this.cbx_category = new System.Windows.Forms.ComboBox();
            this.cbx_store = new System.Windows.Forms.ComboBox();
            this.cbx_expenseType = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_expense = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_save = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.파일ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbl_income = new System.Windows.Forms.Label();
            this.lbl_expense = new System.Windows.Forms.Label();
            this.lbl_expenseAmount = new System.Windows.Forms.Label();
            this.lbl_incomeAmount = new System.Windows.Forms.Label();
            this.lbl_remain = new System.Windows.Forms.Label();
            this.lbl_remainAmount = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_report)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tp_category.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_category)).BeginInit();
            this.tp_store.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_store)).BeginInit();
            this.tp_expenseType.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_expenseType)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_report
            // 
            this.dgv_report.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_report.Location = new System.Drawing.Point(9, 74);
            this.dgv_report.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_report.Name = "dgv_report";
            this.dgv_report.RowHeadersWidth = 62;
            this.dgv_report.RowTemplate.Height = 23;
            this.dgv_report.Size = new System.Drawing.Size(814, 752);
            this.dgv_report.TabIndex = 0;
            this.dgv_report.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_report_CellClick);
            // 
            // dtp_from
            // 
            this.dtp_from.Location = new System.Drawing.Point(9, 30);
            this.dtp_from.Margin = new System.Windows.Forms.Padding(4);
            this.dtp_from.Name = "dtp_from";
            this.dtp_from.Size = new System.Drawing.Size(264, 28);
            this.dtp_from.TabIndex = 1;
            // 
            // dtp_to
            // 
            this.dtp_to.Location = new System.Drawing.Point(283, 30);
            this.dtp_to.Margin = new System.Windows.Forms.Padding(4);
            this.dtp_to.Name = "dtp_to";
            this.dtp_to.Size = new System.Drawing.Size(298, 28);
            this.dtp_to.TabIndex = 2;
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(591, 30);
            this.btn_delete.Margin = new System.Windows.Forms.Padding(4);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(107, 34);
            this.btn_delete.TabIndex = 5;
            this.btn_delete.Text = "삭제";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(706, 30);
            this.btn_search.Margin = new System.Windows.Forms.Padding(4);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(107, 34);
            this.btn_search.TabIndex = 6;
            this.btn_search.Text = "검색";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tp_category);
            this.tabControl1.Controls.Add(this.tp_store);
            this.tabControl1.Controls.Add(this.tp_expenseType);
            this.tabControl1.Location = new System.Drawing.Point(849, 586);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(279, 306);
            this.tabControl1.TabIndex = 8;
            // 
            // tp_category
            // 
            this.tp_category.Controls.Add(this.dgv_category);
            this.tp_category.Location = new System.Drawing.Point(4, 28);
            this.tp_category.Margin = new System.Windows.Forms.Padding(4);
            this.tp_category.Name = "tp_category";
            this.tp_category.Padding = new System.Windows.Forms.Padding(4);
            this.tp_category.Size = new System.Drawing.Size(271, 274);
            this.tp_category.TabIndex = 0;
            this.tp_category.Text = "분류";
            this.tp_category.UseVisualStyleBackColor = true;
            // 
            // dgv_category
            // 
            this.dgv_category.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_category.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_category.Location = new System.Drawing.Point(4, 4);
            this.dgv_category.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_category.Name = "dgv_category";
            this.dgv_category.RowHeadersWidth = 62;
            this.dgv_category.RowTemplate.Height = 23;
            this.dgv_category.Size = new System.Drawing.Size(263, 266);
            this.dgv_category.TabIndex = 0;
            // 
            // tp_store
            // 
            this.tp_store.Controls.Add(this.dgv_store);
            this.tp_store.Location = new System.Drawing.Point(4, 28);
            this.tp_store.Margin = new System.Windows.Forms.Padding(4);
            this.tp_store.Name = "tp_store";
            this.tp_store.Padding = new System.Windows.Forms.Padding(4);
            this.tp_store.Size = new System.Drawing.Size(271, 415);
            this.tp_store.TabIndex = 1;
            this.tp_store.Text = "구매처";
            this.tp_store.UseVisualStyleBackColor = true;
            // 
            // dgv_store
            // 
            this.dgv_store.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_store.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_store.Location = new System.Drawing.Point(4, 4);
            this.dgv_store.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_store.Name = "dgv_store";
            this.dgv_store.RowHeadersWidth = 62;
            this.dgv_store.RowTemplate.Height = 23;
            this.dgv_store.Size = new System.Drawing.Size(263, 407);
            this.dgv_store.TabIndex = 0;
            // 
            // tp_expenseType
            // 
            this.tp_expenseType.Controls.Add(this.dgv_expenseType);
            this.tp_expenseType.Location = new System.Drawing.Point(4, 28);
            this.tp_expenseType.Margin = new System.Windows.Forms.Padding(4);
            this.tp_expenseType.Name = "tp_expenseType";
            this.tp_expenseType.Padding = new System.Windows.Forms.Padding(4);
            this.tp_expenseType.Size = new System.Drawing.Size(271, 415);
            this.tp_expenseType.TabIndex = 2;
            this.tp_expenseType.Text = "지출분류";
            this.tp_expenseType.UseVisualStyleBackColor = true;
            // 
            // dgv_expenseType
            // 
            this.dgv_expenseType.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_expenseType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_expenseType.Location = new System.Drawing.Point(4, 4);
            this.dgv_expenseType.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_expenseType.Name = "dgv_expenseType";
            this.dgv_expenseType.RowHeadersWidth = 62;
            this.dgv_expenseType.RowTemplate.Height = 23;
            this.dgv_expenseType.Size = new System.Drawing.Size(263, 407);
            this.dgv_expenseType.TabIndex = 0;
            // 
            // txt_income
            // 
            this.txt_income.Location = new System.Drawing.Point(11, 237);
            this.txt_income.Margin = new System.Windows.Forms.Padding(4);
            this.txt_income.Name = "txt_income";
            this.txt_income.Size = new System.Drawing.Size(253, 28);
            this.txt_income.TabIndex = 10;
            // 
            // dtp_input
            // 
            this.dtp_input.Location = new System.Drawing.Point(11, 58);
            this.dtp_input.Margin = new System.Windows.Forms.Padding(4);
            this.dtp_input.Name = "dtp_input";
            this.dtp_input.Size = new System.Drawing.Size(253, 28);
            this.dtp_input.TabIndex = 11;
            // 
            // txt_description
            // 
            this.txt_description.Location = new System.Drawing.Point(11, 178);
            this.txt_description.Margin = new System.Windows.Forms.Padding(4);
            this.txt_description.Name = "txt_description";
            this.txt_description.Size = new System.Drawing.Size(253, 28);
            this.txt_description.TabIndex = 12;
            // 
            // cbx_category
            // 
            this.cbx_category.FormattingEnabled = true;
            this.cbx_category.Location = new System.Drawing.Point(11, 122);
            this.cbx_category.Margin = new System.Windows.Forms.Padding(4);
            this.cbx_category.Name = "cbx_category";
            this.cbx_category.Size = new System.Drawing.Size(253, 26);
            this.cbx_category.TabIndex = 13;
            // 
            // cbx_store
            // 
            this.cbx_store.FormattingEnabled = true;
            this.cbx_store.Location = new System.Drawing.Point(11, 354);
            this.cbx_store.Margin = new System.Windows.Forms.Padding(4);
            this.cbx_store.Name = "cbx_store";
            this.cbx_store.Size = new System.Drawing.Size(253, 26);
            this.cbx_store.TabIndex = 14;
            // 
            // cbx_expenseType
            // 
            this.cbx_expenseType.FormattingEnabled = true;
            this.cbx_expenseType.Location = new System.Drawing.Point(11, 414);
            this.cbx_expenseType.Margin = new System.Windows.Forms.Padding(4);
            this.cbx_expenseType.Name = "cbx_expenseType";
            this.cbx_expenseType.Size = new System.Drawing.Size(253, 26);
            this.cbx_expenseType.TabIndex = 15;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_expense);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btn_save);
            this.groupBox1.Controls.Add(this.txt_description);
            this.groupBox1.Controls.Add(this.dtp_input);
            this.groupBox1.Controls.Add(this.cbx_category);
            this.groupBox1.Controls.Add(this.cbx_store);
            this.groupBox1.Controls.Add(this.cbx_expenseType);
            this.groupBox1.Controls.Add(this.txt_income);
            this.groupBox1.Location = new System.Drawing.Point(851, 80);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(279, 498);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "입력하기";
            // 
            // txt_expense
            // 
            this.txt_expense.Location = new System.Drawing.Point(11, 296);
            this.txt_expense.Margin = new System.Windows.Forms.Padding(4);
            this.txt_expense.Name = "txt_expense";
            this.txt_expense.Size = new System.Drawing.Size(253, 28);
            this.txt_expense.TabIndex = 24;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 388);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 18);
            this.label7.TabIndex = 23;
            this.label7.Text = "지출분류";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 332);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 18);
            this.label6.TabIndex = 22;
            this.label6.Text = "구매처";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 156);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 18);
            this.label5.TabIndex = 21;
            this.label5.Text = "상세";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 214);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 18);
            this.label4.TabIndex = 20;
            this.label4.Text = "수입금액";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 273);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 18);
            this.label3.TabIndex = 19;
            this.label3.Text = "지출금액";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 99);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 18);
            this.label2.TabIndex = 18;
            this.label2.Text = "분류";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 18);
            this.label1.TabIndex = 17;
            this.label1.Text = "입력일자";
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(64, 453);
            this.btn_save.Margin = new System.Windows.Forms.Padding(4);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(146, 36);
            this.btn_save.TabIndex = 16;
            this.btn_save.Text = "저장하기";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.파일ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1139, 33);
            this.menuStrip1.TabIndex = 17;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 파일ToolStripMenuItem
            // 
            this.파일ToolStripMenuItem.Name = "파일ToolStripMenuItem";
            this.파일ToolStripMenuItem.Size = new System.Drawing.Size(64, 29);
            this.파일ToolStripMenuItem.Text = "파일";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtp_from);
            this.groupBox2.Controls.Add(this.dtp_to);
            this.groupBox2.Controls.Add(this.btn_delete);
            this.groupBox2.Controls.Add(this.dgv_report);
            this.groupBox2.Controls.Add(this.btn_search);
            this.groupBox2.Location = new System.Drawing.Point(17, 58);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(826, 834);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "보기";
            // 
            // lbl_income
            // 
            this.lbl_income.AutoSize = true;
            this.lbl_income.Location = new System.Drawing.Point(23, 896);
            this.lbl_income.Name = "lbl_income";
            this.lbl_income.Size = new System.Drawing.Size(44, 18);
            this.lbl_income.TabIndex = 19;
            this.lbl_income.Text = "수입";
            // 
            // lbl_expense
            // 
            this.lbl_expense.AutoSize = true;
            this.lbl_expense.Location = new System.Drawing.Point(270, 896);
            this.lbl_expense.Name = "lbl_expense";
            this.lbl_expense.Size = new System.Drawing.Size(44, 18);
            this.lbl_expense.TabIndex = 20;
            this.lbl_expense.Text = "지출";
            // 
            // lbl_expenseAmount
            // 
            this.lbl_expenseAmount.AutoSize = true;
            this.lbl_expenseAmount.Location = new System.Drawing.Point(320, 896);
            this.lbl_expenseAmount.Name = "lbl_expenseAmount";
            this.lbl_expenseAmount.Size = new System.Drawing.Size(64, 18);
            this.lbl_expenseAmount.TabIndex = 21;
            this.lbl_expenseAmount.Text = "label10";
            // 
            // lbl_incomeAmount
            // 
            this.lbl_incomeAmount.AutoSize = true;
            this.lbl_incomeAmount.Location = new System.Drawing.Point(73, 896);
            this.lbl_incomeAmount.Name = "lbl_incomeAmount";
            this.lbl_incomeAmount.Size = new System.Drawing.Size(64, 18);
            this.lbl_incomeAmount.TabIndex = 22;
            this.lbl_incomeAmount.Text = "label11";
            // 
            // lbl_remain
            // 
            this.lbl_remain.AutoSize = true;
            this.lbl_remain.Location = new System.Drawing.Point(538, 896);
            this.lbl_remain.Name = "lbl_remain";
            this.lbl_remain.Size = new System.Drawing.Size(44, 18);
            this.lbl_remain.TabIndex = 23;
            this.lbl_remain.Text = "잔여";
            // 
            // lbl_remainAmount
            // 
            this.lbl_remainAmount.AutoSize = true;
            this.lbl_remainAmount.Location = new System.Drawing.Point(588, 896);
            this.lbl_remainAmount.Name = "lbl_remainAmount";
            this.lbl_remainAmount.Size = new System.Drawing.Size(150, 18);
            this.lbl_remainAmount.TabIndex = 24;
            this.lbl_remainAmount.Text = "lbl_remainAmount";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1139, 933);
            this.Controls.Add(this.lbl_remainAmount);
            this.Controls.Add(this.lbl_remain);
            this.Controls.Add(this.lbl_incomeAmount);
            this.Controls.Add(this.lbl_expenseAmount);
            this.Controls.Add(this.lbl_expense);
            this.Controls.Add(this.lbl_income);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_report)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tp_category.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_category)).EndInit();
            this.tp_store.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_store)).EndInit();
            this.tp_expenseType.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_expenseType)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_report;
        private System.Windows.Forms.DateTimePicker dtp_from;
        private System.Windows.Forms.DateTimePicker dtp_to;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tp_category;
        private System.Windows.Forms.TabPage tp_store;
        private System.Windows.Forms.TabPage tp_expenseType;
        private System.Windows.Forms.TextBox txt_income;
        private System.Windows.Forms.DateTimePicker dtp_input;
        private System.Windows.Forms.TextBox txt_description;
        private System.Windows.Forms.ComboBox cbx_category;
        private System.Windows.Forms.ComboBox cbx_store;
        private System.Windows.Forms.ComboBox cbx_expenseType;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgv_category;
        private System.Windows.Forms.DataGridView dgv_store;
        private System.Windows.Forms.DataGridView dgv_expenseType;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 파일ToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt_expense;
        private System.Windows.Forms.Label lbl_income;
        private System.Windows.Forms.Label lbl_expense;
        private System.Windows.Forms.Label lbl_expenseAmount;
        private System.Windows.Forms.Label lbl_incomeAmount;
        private System.Windows.Forms.Label lbl_remain;
        private System.Windows.Forms.Label lbl_remainAmount;
    }
}