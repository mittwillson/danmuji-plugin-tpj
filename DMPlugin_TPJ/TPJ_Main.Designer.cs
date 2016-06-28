namespace DMPlugin_TPJ
{
    partial class TPJ_Main
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
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage_Main = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lb_tp_result = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cb_tp_is_timer = new System.Windows.Forms.CheckBox();
            this.tb_tp_time = new System.Windows.Forms.TextBox();
            this.btn_tp_stop = new System.Windows.Forms.Button();
            this.btn_tp_start = new System.Windows.Forms.Button();
            this.dgv_tp_info = new System.Windows.Forms.DataGridView();
            this.tabPage_addProject = new System.Windows.Forms.TabPage();
            this.btn_add_tp_clean = new System.Windows.Forms.Button();
            this.btn_add_tp_lock = new System.Windows.Forms.Button();
            this.dgw_add_tp = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.item = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgv_black_home = new System.Windows.Forms.DataGridView();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage_admin = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cb_setting_allow_user_add_item = new System.Windows.Forms.CheckBox();
            this.cb_setting_allow_fullname = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.tb_setting_user_max_bill = new System.Windows.Forms.TextBox();
            this.cb_setting_deny_user_many_bill = new System.Windows.Forms.CheckBox();
            this.time_tp = new System.Windows.Forms.Timer(this.components);
            this.user_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tp_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cb_setting_success_send_dm = new System.Windows.Forms.CheckBox();
            this.cb_setting_count_down_send_dm = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.从列表中删除ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.清空小黑屋ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.tPITEMBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tPITEMBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage_Main.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tp_info)).BeginInit();
            this.tabPage_addProject.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_add_tp)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_black_home)).BeginInit();
            this.tabPage_admin.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tPITEMBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tPITEMBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage_Main);
            this.tabControl1.Controls.Add(this.tabPage_addProject);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage_admin);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(551, 387);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage_Main
            // 
            this.tabPage_Main.Controls.Add(this.groupBox2);
            this.tabPage_Main.Controls.Add(this.groupBox1);
            this.tabPage_Main.Controls.Add(this.btn_tp_stop);
            this.tabPage_Main.Controls.Add(this.btn_tp_start);
            this.tabPage_Main.Controls.Add(this.dgv_tp_info);
            this.tabPage_Main.Location = new System.Drawing.Point(4, 22);
            this.tabPage_Main.Name = "tabPage_Main";
            this.tabPage_Main.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Main.Size = new System.Drawing.Size(543, 361);
            this.tabPage_Main.TabIndex = 0;
            this.tabPage_Main.Text = "投票信息";
            this.tabPage_Main.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox2.Controls.Add(this.lb_tp_result);
            this.groupBox2.Location = new System.Drawing.Point(399, 178);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(136, 174);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "投票结果";
            // 
            // lb_tp_result
            // 
            this.lb_tp_result.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_tp_result.Font = new System.Drawing.Font("宋体", 12F);
            this.lb_tp_result.Location = new System.Drawing.Point(3, 17);
            this.lb_tp_result.Name = "lb_tp_result";
            this.lb_tp_result.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lb_tp_result.Size = new System.Drawing.Size(130, 154);
            this.lb_tp_result.TabIndex = 0;
            this.lb_tp_result.Text = "等待投票";
            this.lb_tp_result.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox1.Controls.Add(this.cb_tp_is_timer);
            this.groupBox1.Controls.Add(this.tb_tp_time);
            this.groupBox1.Location = new System.Drawing.Point(399, 96);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(136, 79);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "计时投票(s)";
            // 
            // cb_tp_is_timer
            // 
            this.cb_tp_is_timer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cb_tp_is_timer.AutoSize = true;
            this.cb_tp_is_timer.Location = new System.Drawing.Point(32, 51);
            this.cb_tp_is_timer.Name = "cb_tp_is_timer";
            this.cb_tp_is_timer.Size = new System.Drawing.Size(72, 16);
            this.cb_tp_is_timer.TabIndex = 4;
            this.cb_tp_is_timer.Text = "计时投票";
            this.cb_tp_is_timer.UseVisualStyleBackColor = true;
            // 
            // tb_tp_time
            // 
            this.tb_tp_time.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_tp_time.Location = new System.Drawing.Point(8, 20);
            this.tb_tp_time.Name = "tb_tp_time";
            this.tb_tp_time.Size = new System.Drawing.Size(122, 21);
            this.tb_tp_time.TabIndex = 3;
            this.tb_tp_time.Text = "60";
            this.tb_tp_time.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_tp_stop
            // 
            this.btn_tp_stop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_tp_stop.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_tp_stop.Enabled = false;
            this.btn_tp_stop.Location = new System.Drawing.Point(399, 51);
            this.btn_tp_stop.Name = "btn_tp_stop";
            this.btn_tp_stop.Size = new System.Drawing.Size(136, 39);
            this.btn_tp_stop.TabIndex = 2;
            this.btn_tp_stop.Text = "停止投票";
            this.btn_tp_stop.UseVisualStyleBackColor = true;
            this.btn_tp_stop.Click += new System.EventHandler(this.btn_tp_stop_Click);
            // 
            // btn_tp_start
            // 
            this.btn_tp_start.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_tp_start.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_tp_start.Location = new System.Drawing.Point(399, 7);
            this.btn_tp_start.Name = "btn_tp_start";
            this.btn_tp_start.Size = new System.Drawing.Size(136, 39);
            this.btn_tp_start.TabIndex = 1;
            this.btn_tp_start.Text = "开始投票";
            this.btn_tp_start.UseVisualStyleBackColor = true;
            this.btn_tp_start.Click += new System.EventHandler(this.btn_tp_start_Click);
            // 
            // dgv_tp_info
            // 
            this.dgv_tp_info.AllowUserToAddRows = false;
            this.dgv_tp_info.AllowUserToDeleteRows = false;
            this.dgv_tp_info.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_tp_info.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_tp_info.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.user_name,
            this.tp_id});
            this.dgv_tp_info.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgv_tp_info.Location = new System.Drawing.Point(3, 3);
            this.dgv_tp_info.MultiSelect = false;
            this.dgv_tp_info.Name = "dgv_tp_info";
            this.dgv_tp_info.RowHeadersVisible = false;
            this.dgv_tp_info.RowTemplate.Height = 23;
            this.dgv_tp_info.Size = new System.Drawing.Size(385, 355);
            this.dgv_tp_info.TabIndex = 0;
            // 
            // tabPage_addProject
            // 
            this.tabPage_addProject.Controls.Add(this.button3);
            this.tabPage_addProject.Controls.Add(this.button2);
            this.tabPage_addProject.Controls.Add(this.btn_add_tp_clean);
            this.tabPage_addProject.Controls.Add(this.btn_add_tp_lock);
            this.tabPage_addProject.Controls.Add(this.dgw_add_tp);
            this.tabPage_addProject.Location = new System.Drawing.Point(4, 22);
            this.tabPage_addProject.Name = "tabPage_addProject";
            this.tabPage_addProject.Size = new System.Drawing.Size(543, 361);
            this.tabPage_addProject.TabIndex = 1;
            this.tabPage_addProject.Text = "票项";
            this.tabPage_addProject.UseVisualStyleBackColor = true;
            // 
            // btn_add_tp_clean
            // 
            this.btn_add_tp_clean.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_add_tp_clean.Location = new System.Drawing.Point(467, 53);
            this.btn_add_tp_clean.Name = "btn_add_tp_clean";
            this.btn_add_tp_clean.Size = new System.Drawing.Size(75, 33);
            this.btn_add_tp_clean.TabIndex = 2;
            this.btn_add_tp_clean.Text = "清空票项";
            this.btn_add_tp_clean.UseVisualStyleBackColor = true;
            this.btn_add_tp_clean.Click += new System.EventHandler(this.btn_add_tp_clean_Click);
            // 
            // btn_add_tp_lock
            // 
            this.btn_add_tp_lock.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_add_tp_lock.Location = new System.Drawing.Point(467, 3);
            this.btn_add_tp_lock.Name = "btn_add_tp_lock";
            this.btn_add_tp_lock.Size = new System.Drawing.Size(75, 33);
            this.btn_add_tp_lock.TabIndex = 1;
            this.btn_add_tp_lock.Text = "锁定票项";
            this.btn_add_tp_lock.UseVisualStyleBackColor = true;
            this.btn_add_tp_lock.Click += new System.EventHandler(this.btn_add_tp_lock_Click);
            // 
            // dgw_add_tp
            // 
            this.dgw_add_tp.AllowUserToOrderColumns = true;
            this.dgw_add_tp.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgw_add_tp.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgw_add_tp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgw_add_tp.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.item});
            this.dgw_add_tp.Location = new System.Drawing.Point(8, 3);
            this.dgw_add_tp.Name = "dgw_add_tp";
            this.dgw_add_tp.RowTemplate.Height = 23;
            this.dgw_add_tp.Size = new System.Drawing.Size(458, 349);
            this.dgw_add_tp.TabIndex = 0;
            this.dgw_add_tp.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgw_add_tp_RowPostPaint);
            // 
            // id
            // 
            this.id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            // 
            // item
            // 
            this.item.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.item.DataPropertyName = "item";
            this.item.HeaderText = "投票名称";
            this.item.Name = "item";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgv_black_home);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(543, 361);
            this.tabPage1.TabIndex = 3;
            this.tabPage1.Text = "小黑屋";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgv_black_home
            // 
            this.dgv_black_home.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_black_home.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column4});
            this.dgv_black_home.ContextMenuStrip = this.contextMenuStrip1;
            this.dgv_black_home.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_black_home.Location = new System.Drawing.Point(3, 3);
            this.dgv_black_home.Name = "dgv_black_home";
            this.dgv_black_home.RowTemplate.Height = 23;
            this.dgv_black_home.Size = new System.Drawing.Size(537, 355);
            this.dgv_black_home.TabIndex = 0;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.HeaderText = "用户名";
            this.Column4.Name = "Column4";
            // 
            // tabPage_admin
            // 
            this.tabPage_admin.Controls.Add(this.label1);
            this.tabPage_admin.Controls.Add(this.groupBox3);
            this.tabPage_admin.Location = new System.Drawing.Point(4, 22);
            this.tabPage_admin.Name = "tabPage_admin";
            this.tabPage_admin.Size = new System.Drawing.Size(543, 361);
            this.tabPage_admin.TabIndex = 2;
            this.tabPage_admin.Text = "投票设置";
            this.tabPage_admin.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.cb_setting_count_down_send_dm);
            this.groupBox3.Controls.Add(this.cb_setting_success_send_dm);
            this.groupBox3.Controls.Add(this.cb_setting_allow_user_add_item);
            this.groupBox3.Controls.Add(this.cb_setting_allow_fullname);
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Controls.Add(this.cb_setting_deny_user_many_bill);
            this.groupBox3.Location = new System.Drawing.Point(8, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(373, 349);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "用户设置";
            // 
            // cb_setting_allow_user_add_item
            // 
            this.cb_setting_allow_user_add_item.AutoSize = true;
            this.cb_setting_allow_user_add_item.Enabled = false;
            this.cb_setting_allow_user_add_item.Location = new System.Drawing.Point(6, 112);
            this.cb_setting_allow_user_add_item.Name = "cb_setting_allow_user_add_item";
            this.cb_setting_allow_user_add_item.Size = new System.Drawing.Size(120, 16);
            this.cb_setting_allow_user_add_item.TabIndex = 3;
            this.cb_setting_allow_user_add_item.Text = "允许用户添加票项";
            this.cb_setting_allow_user_add_item.UseVisualStyleBackColor = true;
            // 
            // cb_setting_allow_fullname
            // 
            this.cb_setting_allow_fullname.AutoSize = true;
            this.cb_setting_allow_fullname.Location = new System.Drawing.Point(6, 90);
            this.cb_setting_allow_fullname.Name = "cb_setting_allow_fullname";
            this.cb_setting_allow_fullname.Size = new System.Drawing.Size(156, 16);
            this.cb_setting_allow_fullname.TabIndex = 2;
            this.cb_setting_allow_fullname.Text = "允许投票使用完整投票名";
            this.cb_setting_allow_fullname.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.tb_setting_user_max_bill);
            this.groupBox4.Location = new System.Drawing.Point(6, 42);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(131, 42);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "允许投票次数";
            // 
            // tb_setting_user_max_bill
            // 
            this.tb_setting_user_max_bill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_setting_user_max_bill.Location = new System.Drawing.Point(3, 17);
            this.tb_setting_user_max_bill.Name = "tb_setting_user_max_bill";
            this.tb_setting_user_max_bill.Size = new System.Drawing.Size(125, 21);
            this.tb_setting_user_max_bill.TabIndex = 0;
            this.tb_setting_user_max_bill.Text = "1";
            this.tb_setting_user_max_bill.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_setting_user_max_bill.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // cb_setting_deny_user_many_bill
            // 
            this.cb_setting_deny_user_many_bill.AutoSize = true;
            this.cb_setting_deny_user_many_bill.Checked = true;
            this.cb_setting_deny_user_many_bill.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_setting_deny_user_many_bill.Location = new System.Drawing.Point(6, 20);
            this.cb_setting_deny_user_many_bill.Name = "cb_setting_deny_user_many_bill";
            this.cb_setting_deny_user_many_bill.Size = new System.Drawing.Size(96, 16);
            this.cb_setting_deny_user_many_bill.TabIndex = 0;
            this.cb_setting_deny_user_many_bill.Text = "禁止重复投票";
            this.cb_setting_deny_user_many_bill.UseVisualStyleBackColor = true;
            // 
            // time_tp
            // 
            this.time_tp.Interval = 1000;
            this.time_tp.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // user_name
            // 
            this.user_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.user_name.DataPropertyName = "user_name";
            this.user_name.HeaderText = "投票人";
            this.user_name.Name = "user_name";
            this.user_name.ReadOnly = true;
            // 
            // tp_id
            // 
            this.tp_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tp_id.DataPropertyName = "tp_id";
            this.tp_id.HeaderText = "投票项";
            this.tp_id.Name = "tp_id";
            this.tp_id.ReadOnly = true;
            // 
            // cb_setting_success_send_dm
            // 
            this.cb_setting_success_send_dm.AutoSize = true;
            this.cb_setting_success_send_dm.Checked = true;
            this.cb_setting_success_send_dm.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_setting_success_send_dm.Location = new System.Drawing.Point(6, 134);
            this.cb_setting_success_send_dm.Name = "cb_setting_success_send_dm";
            this.cb_setting_success_send_dm.Size = new System.Drawing.Size(120, 16);
            this.cb_setting_success_send_dm.TabIndex = 4;
            this.cb_setting_success_send_dm.Text = "投票成功发送弹幕";
            this.cb_setting_success_send_dm.UseVisualStyleBackColor = true;
            // 
            // cb_setting_count_down_send_dm
            // 
            this.cb_setting_count_down_send_dm.AutoSize = true;
            this.cb_setting_count_down_send_dm.Checked = true;
            this.cb_setting_count_down_send_dm.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_setting_count_down_send_dm.Location = new System.Drawing.Point(6, 156);
            this.cb_setting_count_down_send_dm.Name = "cb_setting_count_down_send_dm";
            this.cb_setting_count_down_send_dm.Size = new System.Drawing.Size(108, 16);
            this.cb_setting_count_down_send_dm.TabIndex = 5;
            this.cb_setting_count_down_send_dm.Text = "倒计时发送弹幕";
            this.cb_setting_count_down_send_dm.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 320);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "存档";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Location = new System.Drawing.Point(387, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 184);
            this.label1.TabIndex = 1;
            this.label1.Text = "什么? XX设计的太辣鸡? XX很不方便? XX出BUG了? XX崩了? 觉得作者太弱智? 你确定不是你的问题嘛? 你确定不是你的问题的话还不快来联系作者PY交易" +
    "!\r\nEmail: \r\n  MittWillson@icloud.com\r\nQQ: \r\n  757549561\r\n赞助请打到支付宝:\r\n  757549561@" +
    "qq.com \r\n  (*春艳) 灰常感谢";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.从列表中删除ToolStripMenuItem,
            this.清空小黑屋ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(149, 48);
            // 
            // 从列表中删除ToolStripMenuItem
            // 
            this.从列表中删除ToolStripMenuItem.Name = "从列表中删除ToolStripMenuItem";
            this.从列表中删除ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.从列表中删除ToolStripMenuItem.Text = "从列表中删除";
            this.从列表中删除ToolStripMenuItem.Click += new System.EventHandler(this.从列表中删除ToolStripMenuItem_Click);
            // 
            // 清空小黑屋ToolStripMenuItem
            // 
            this.清空小黑屋ToolStripMenuItem.Name = "清空小黑屋ToolStripMenuItem";
            this.清空小黑屋ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.清空小黑屋ToolStripMenuItem.Text = "清空小黑屋";
            this.清空小黑屋ToolStripMenuItem.Click += new System.EventHandler(this.清空小黑屋ToolStripMenuItem_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(467, 113);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 30);
            this.button2.TabIndex = 3;
            this.button2.Text = "存档";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.Location = new System.Drawing.Point(467, 170);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 31);
            this.button3.TabIndex = 4;
            this.button3.Text = "读档";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "存档文件|*.ini";
            this.openFileDialog1.Title = "传说的骚年啊, 选择你的复活点吧";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "存档文件|*.ini";
            this.saveFileDialog1.Title = "传说的骚年啊, 选择你的存档点吧";
            // 
            // tPITEMBindingSource
            // 
            this.tPITEMBindingSource.DataSource = typeof(DMPlugin_TPJ.TP_ITEM);
            // 
            // tPITEMBindingSource1
            // 
            this.tPITEMBindingSource1.DataSource = typeof(DMPlugin_TPJ.TP_ITEM);
            // 
            // TPJ_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 387);
            this.Controls.Add(this.tabControl1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TPJ_Main";
            this.Text = "投票基  /* V  */  --- 好基友, 一被子 @拓海真一";
            this.Load += new System.EventHandler(this.TPJ_Main_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage_Main.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tp_info)).EndInit();
            this.tabPage_addProject.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgw_add_tp)).EndInit();
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_black_home)).EndInit();
            this.tabPage_admin.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tPITEMBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tPITEMBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage_Main;
        private System.Windows.Forms.TabPage tabPage_addProject;
        private System.Windows.Forms.TabPage tabPage_admin;
        private System.Windows.Forms.DataGridView dgw_add_tp;
        private System.Windows.Forms.Button btn_add_tp_lock;
        private System.Windows.Forms.DataGridView dgv_tp_info;
        private System.Windows.Forms.Button btn_tp_start;
        private System.Windows.Forms.Button btn_tp_stop;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tb_tp_time;
        private System.Windows.Forms.CheckBox cb_tp_is_timer;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lb_tp_result;
        private System.Windows.Forms.Timer time_tp;
        private System.Windows.Forms.Button btn_add_tp_clean;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox cb_setting_deny_user_many_bill;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox tb_setting_user_max_bill;
        private System.Windows.Forms.CheckBox cb_setting_allow_fullname;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dgv_black_home;
        private System.Windows.Forms.CheckBox cb_setting_allow_user_add_item;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.BindingSource tPITEMBindingSource;
        private System.Windows.Forms.BindingSource tPITEMBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn item;
        private System.Windows.Forms.DataGridViewTextBoxColumn user_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn tp_id;
        private System.Windows.Forms.CheckBox cb_setting_success_send_dm;
        private System.Windows.Forms.CheckBox cb_setting_count_down_send_dm;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 从列表中删除ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 清空小黑屋ToolStripMenuItem;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}