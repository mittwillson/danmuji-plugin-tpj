using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.IO;

namespace DMPlugin_TPJ
{
    public partial class TPJ_Main : Form
    {

        private int time = 0;
        public bool tp_start = false;
        private bool tp_item_lock = false;
        private string messageboxCaption = "投票基不想跟你说话, 并向你扔了一个消息框";

        public List<TP_ITEM> tpItem = new List<TP_ITEM> { };
        public List<TP_USER_ITEM> tpUserItem = new List<TP_USER_ITEM> { };

        private Config item_config = null;

        private TPJ _tpj;

        public TPJ_Main(TPJ tpj)
        {
            InitializeComponent();
            this._tpj = tpj;
        }

        private void TP_start()
        {
            this.btn_tp_start.Enabled = false;
            this.btn_tp_stop.Enabled = true;
            this.lb_tp_result.Text = "等待结果";
            this.tp_start = true;

            bool is_timer = false;

            this.TP_cleanList();
            if (this.cb_tp_is_timer.Checked == true)
            {
                do
                {
                    is_timer = true;
                    this.time = int.Parse(this.tb_tp_time.Text);
                    if (this.time <= 0)
                    {
                        this.cb_tp_is_timer.Checked = false;
                        is_timer = false;
                        this.time = 0;
                        break;
                    }
                    else
                    {
                        this.TP_timerStart();
                    }
                } while (false);
                if (is_timer == false)
                {
                    // 
                }
            }

        }

        private void TP_stop()
        {
            this.btn_tp_start.Enabled = true;
            this.btn_tp_stop.Enabled = false;
            this.tp_start = false;
            long count, last_count;
            string last_name;
            this.lb_tp_result.Text = this.TP_getResult(out count, out last_name, out last_count);
            string _out = "投票结束, 结果为: 【" + this.lb_tp_result.Text + "】, 票数为: " + count + ", 与之相近的 【" + last_name + "】 票数为: " + last_count;
            this._tpj.AddDM(_out);
            this._tpj.Log(_out);
        }

        private void TP_timerTitle()
        {
            this.btn_tp_start.Text = "倒计时: " + this.time + " s";
            if (this.time <= 5)
                this._tpj.AddDM("投票倒计时: " + this.time + " 秒");
        }

        private void TP_timerStart()
        {
            // this.time_tp.Interval = 1000 * 1; // 秒为单位
            this.time_tp.Start();
        }

        private void TP_timerStop()
        {
            this.time_tp.Stop();
            this.btn_tp_start.Text = "开始投票";
            this.TP_stop();
        }

        private void TP_cleanList()
        {
            this.dgv_tp_info.Rows.Clear();
            // this.tpItem.Clear(); // 智障啊 清空JB的票项
        }

        private string TP_getResult(out long Count,out string lastName, out long lastCount)
        {
            TP_ITEM current = new TP_ITEM(0, "", -1);
            TP_ITEM last = null;
            foreach (TP_ITEM i in this.tpItem)
            {
                if (i.count > current.count)
                {
                    last = current;
                    current = i;
                }
            }
            Count = current.count;
            if (current != null)
            {
                lastName = current.item;
                lastCount = current.count;
            }
            else
            {
                lastCount = 0;
                lastName = "";
            }
            return current.item;
        }

        private string TP_getResult(out long Count)
        {
            long lastCount = 0;
            string lastName = "";
            return this.TP_getResult(out Count, out lastName, out lastCount);
        }
        
        private string TP_getResult()
        {
            long c = 0;
            return this.TP_getResult(out c);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.time--;
            this.TP_timerTitle();
            if (this.time <= 0)
            {
                TP_timerStop();
            }
        }

        private void btn_add_tp_lock_Click(object sender, EventArgs e)
        {
            this.dgw_add_tp_RowPostPaint(null, null);
            tp_item_lock = !tp_item_lock;
            if (tp_item_lock == true)
            {
                this.btn_add_tp_lock.Text = "解锁票项";
                this.setTPItem();
            }
            else
            {
                this.btn_add_tp_lock.Text = "锁定票项";
            }
        }

        private void setTPItem()
        {
            this.tpItem.Clear();
            foreach (DataGridViewRow row in this.dgw_add_tp.Rows)
            {
                if (row.Cells[1].Value == null || row.Cells[1].Value.ToString().Trim() == string.Empty)
                    continue;
                this.tpItem.Add(new TP_ITEM(int.Parse(row.Cells[0].Value.ToString()), row.Cells[1].Value.ToString().Trim(), 0));
            }
        }

        private void AddTP_Lock()
        {
            this.dgw_add_tp.AllowUserToAddRows = false;
            this.dgw_add_tp.AllowUserToDeleteRows = false;
        }

        private void AddTP_Unlock()
        {
            this.dgw_add_tp.AllowUserToAddRows = true;
            this.dgw_add_tp.AllowUserToDeleteRows = true;
        }

        private void dgw_add_tp_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            foreach (DataGridViewRow row in this.dgw_add_tp.Rows)
            {
                if (row.Cells[1].Value == null || row.Cells[1].Value.ToString().Trim() == string.Empty)
                    continue;
                row.Cells[0].Value = row.Index + 1;
            }
        }

        private void btn_add_tp_clean_Click(object sender, EventArgs e)
        {
            if (this.tp_start == true)
            {
                MessageBox.Show("先停止投票再清空票项啊喂!", this.messageboxCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                this.dgw_add_tp.Rows.Clear();
                this.tpItem.Clear();
                this.AddTP_Unlock();
            }
        }

        private void btn_tp_start_Click(object sender, EventArgs e)
        {
            if (this.tp_item_lock == true)
            {
                this.TP_start();
            }
            else if(this._tpj.plugin_status == false)
            {
                MessageBox.Show("插件还没开启, 接收不到弹幕", this.messageboxCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("还没有票项, 怎么投, 快去补票!!!", this.messageboxCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void btn_tp_stop_Click(object sender, EventArgs e)
        {
            if (this.cb_tp_is_timer.Checked == true)
                this.TP_timerStop();
            else
                this.TP_stop();
        }

        public TP_ITEM findTPItem(int _id)
        {
            foreach (TP_ITEM i in this.tpItem)
            {
                if (i.id == _id)
                    return i;
            }
            return null;
        }

        public TP_ITEM findTPItem(string _fullname)
        {
            foreach (TP_ITEM i in this.tpItem)
            {
                if (i.item == _fullname)
                    return i;
            }
            return null;
        }

        public List<TP_USER_ITEM> findTPUserItems(string _user)
        {
            List<TP_USER_ITEM> tpU = new List<TP_USER_ITEM> { };
            foreach (TP_USER_ITEM i in this.tpUserItem)
            {
                if (i.user_name == _user)
                    tpU.Add(i);
            }
            return tpU;
        }

        public int getCountInTPUserItems(string _user)
        {
            int ret = 0;
            foreach (TP_USER_ITEM i in this.tpUserItem)
            {
                if (i.user_name == _user)
                    ret++;
            }
            return ret;
        }

        public bool addUserItem(string _user, int _id)
        {
            if (this.IsDenyUserBill(_user)) // 黑名单
                return false;
            if (this.getSettingDenyUserManyBill() == true && this.IsManyBillByUser(_user)) // 重复投票
                return false;
            if (this.getCountInTPUserItems(_user) >= this.getSettingUserMaxBillCount()) // 票数达限
                return false;
            TP_ITEM tpI = this.findTPItem(_id);
            if (tpI != null)
            {
                this.tpUserItem.Add(new TP_USER_ITEM(tpI.id, _user));
                this.tpItem[this.tpItem.IndexOf(tpI)].count++;
                this.showTPInfo();
                if (this.getSettingSuccessSendDM())
                    this._tpj.AddDM("用户[" + _user.Trim() + "] 投票 [" + tpI.item + "] 成功");
                return true;
            }
            return false;
        }

        public bool addUserItem(string _user, string _full_name)
        {
            if (this.IsDenyUserBill(_user))
                return false;
            if (this.getSettingDenyUserManyBill() == true && this.IsManyBillByUser(_user))
                return false;
            if (this.getCountInTPUserItems(_user) >= this.getSettingUserMaxBillCount())
                return false;
            TP_ITEM tpI = this.findTPItem(_full_name);
            if (tpI != null)
            {
                this.tpUserItem.Add(new TP_USER_ITEM(tpI.id, _user));
                this.tpItem[this.tpItem.IndexOf(tpI)].count++;
                this.showTPInfo();
                if (this.getSettingSuccessSendDM())
                    this._tpj.AddDM("用户[" + _user.Trim() + "] 投票 [" + tpI.item + "] 成功");
                return true;
            }
            return false;
        }

        public bool IsDenyUserBill(string _user)
        {
            foreach (DataGridViewRow row in this.dgv_black_home.Rows)
            {
                if (row.Cells[0].Value != null && row.Cells[0].Value.ToString().Trim() == _user)
                    return true;
            }
            return false;
        }

        public bool IsManyBillByUser(string _user)
        {
            Dictionary<string, int> c = new Dictionary<string,int>();
            foreach(TP_USER_ITEM i in this.tpUserItem)
            {
                if(i.user_name == _user)
                {
                    if (c.ContainsKey(i.user_name) == false)
                        c.Add(i.user_name, 1);
                    else
                        c[i.user_name]++;
                }
            }
            foreach(KeyValuePair<string, int> i in c)
            {
                if (i.Value > 1)
                    return true;
            }
            return false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (this.tb_setting_user_max_bill.Text == null || (new Regex(@"^\d*$")).Match(this.tb_setting_user_max_bill.Text).Success == false || Convert.ToInt64(this.tb_setting_user_max_bill.Text.ToString()) <= 0)
                this.tb_setting_user_max_bill.Text = "1";
        }

        public bool getSettingAllowUseFullName()
        {
            return this.cb_setting_allow_fullname.Checked;
        }

        public bool getSettingDenyUserManyBill()
        {
            return this.cb_setting_deny_user_many_bill.Checked;
        }

        public int getSettingUserMaxBillCount()
        {
            return int.Parse(this.tb_setting_user_max_bill.Text);
        }

        public bool getSettingSuccessSendDM()
        {
            return this.cb_setting_success_send_dm.Checked;
        }

        public bool getSettingCountDownSendDM()
        {
            return this.cb_setting_count_down_send_dm.Checked;
        }
        private void showTPInfo()
        {
            this.dgv_tp_info.Rows.Clear();
            foreach (TP_USER_ITEM i in this.tpUserItem)
            {
                TP_ITEM current = this.findTPItem(i.tp_id);
                this.dgv_tp_info.Rows.Add(i.user_name, current == null ? Convert.ToString(i.tp_id) : current.item);
            }
        }

        private void TPJ_Main_Load(object sender, EventArgs e)
        {
            config_load_config();
        }

        private void config_load_config()
        {
            if (Global_Variable.config.get("deny_user_many_bill", "1") == "1")
            {
                this.cb_setting_deny_user_many_bill.Checked = true;
            }
            else
            {
                this.cb_setting_deny_user_many_bill.Checked = false;
            }
            this.tb_setting_user_max_bill.Text = Global_Variable.config.get("user_max_bill", "1");
            if (Global_Variable.config.get("allow_fullname", "0") == "1")
            {
                this.cb_setting_allow_fullname.Checked = true;
            }
            else
            {
                this.cb_setting_allow_fullname.Checked = false;
            }
            if (Global_Variable.config.get("allow_user_add_item", "0") == "1")
            {
                this.cb_setting_allow_user_add_item.Checked = true;
            }
            else
            {
                this.cb_setting_allow_user_add_item.Checked = false;
            }
            if (Global_Variable.config.get("success_send_dm", "1") == "1")
            {
                this.cb_setting_success_send_dm.Checked = true;
            }
            else
            {
                this.cb_setting_success_send_dm.Checked = false;
            }
            if (Global_Variable.config.get("count_down_send_dm", "1") == "1")
            {
                this.cb_setting_count_down_send_dm.Checked = true;
            }
            else
            {
                this.cb_setting_count_down_send_dm.Checked = false;
            }
            this.config_read_ban_list();
        }

        private void config_save_ban_list()
        {
            string _ban_list = "";
            foreach(DataGridViewRow i in this.dgv_black_home.Rows)
            {
                if (i.Cells[0].Value != null && i.Cells[0].Value.ToString().Trim() != string.Empty)
                    _ban_list += "@" + i.Cells[0].Value.ToString().Trim();
            }
            Global_Variable.config.set("ban_list", _ban_list);
            Global_Variable.config.save();
        }

        private void config_read_ban_list()
        {
            try
            {
                string _ban_list = Global_Variable.config.get("ban_list", "");
                Regex re = new Regex(@"@(.+?)(?=$| |@)");
                Match result = null;
                while ((result = re.Match(_ban_list, result != null ? result.Index + result.Length : 0)).Success)
                {
                    this.dgv_black_home.Rows.Add(result.Groups[1].ToString());
                }
            }
            catch
            {
                return;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Global_Variable.config.set("deny_user_many_bill", this.getSettingDenyUserManyBill() ? "1" : "0");
            Global_Variable.config.set("user_max_bill", Convert.ToString(this.getSettingUserMaxBillCount()));
            Global_Variable.config.set("allow_fullname", this.getSettingAllowUseFullName() ? "1" : "0");
            Global_Variable.config.set("allow_user_add_item", this.cb_setting_allow_user_add_item.Checked ? "1" : "0");
            Global_Variable.config.set("success_send_dm", this.cb_setting_success_send_dm.Checked ? "1" : "0");
            Global_Variable.config.set("count_down_send_dm", this.cb_setting_count_down_send_dm.Checked ? "1" : "0");

            Global_Variable.config.save();
            this.config_save_ban_list();
        }

        private void 从列表中删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.dgv_black_home.SelectedRows.Count <= 0)
                return;
            this.dgv_black_home.Rows.Remove(this.dgv_black_home.SelectedRows[0]);
        }

        private void 清空小黑屋ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.dgv_black_home.Rows.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(this.item_config == null)
            {
                if (!Directory.Exists(this._tpj._path + @"User"))
                    Directory.CreateDirectory(this._tpj._path + @"User");
                this.openFileDialog1.InitialDirectory = this._tpj._path + @"User\";
                if(this.saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    this.item_config = new Config(this.saveFileDialog1.FileName, true);
                    this.config_items_write();
                }
            }
            else
            {
                this.config_items_write();
            }
        }

        private void config_items_write()
        {
            if (this.item_config == null)
                return;
            string _out = "";
            foreach(DataGridViewRow i in this.dgw_add_tp.Rows)
            {
                if(i != null && i.Cells.Count > 1 && i.Cells[1] != null && i.Cells[1].Value != null && i.Cells[1].Value.ToString().Trim() != string.Empty)
                    _out += "@" + i.Cells[1].Value.ToString().Trim();
            }
            this.item_config.set("data", _out);
            this.item_config.save();
        }

        private void config_items_read()
        {
            if (this.item_config == null)
                return;
            try
            {
                string _ban_list = this.item_config.get("data", "");
                Regex re = new Regex(@"@(.+?)(?=$| |@)");
                Match result = null;
                while ((result = re.Match(_ban_list, result != null ? result.Index + result.Length : 0)).Success)
                {
                    this.dgw_add_tp.Rows.Add(null, result.Groups[1].ToString());
                }
            }
            catch
            {
                return;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!Directory.Exists(this._tpj._path + @"User"))
                Directory.CreateDirectory(this._tpj._path + @"User");
            this.openFileDialog1.InitialDirectory = this._tpj._path + @"User\";
            if(this.openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if(this.item_config != null)
                {
                    this.item_config = null;
                    GC.Collect();
                }
                this.item_config = new Config(this.openFileDialog1.FileName, true);
                this.config_items_read();
            }
        }

    }
}
