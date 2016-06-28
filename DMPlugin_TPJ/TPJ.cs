using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using BilibiliDM_PluginFramework;
using System.Text.RegularExpressions;

namespace DMPlugin_TPJ
{
    public class TPJ : BilibiliDM_PluginFramework.DMPlugin
    {
        public TPJ_Main tpj_main = null;
        public string _path = "";

        private bool _plugin_status = false;
        public bool plugin_status
        {
            get { return this._plugin_status; }
            set { this._plugin_status = value; }
        }
        public TPJ()
        {
            this.Connected += TPJ_Connected;
            this.Disconnected += TPJ_Disconnected;
            this.ReceivedDanmaku += TPJ_ReceivedDanmaku;
            this.ReceivedRoomCount += TPJ_ReceivedRoomCount;
            this.PluginAuth = "拓海真一";
            this.PluginName = "投票基";
            this.PluginCont = "MittWillson@icloud.com";
            this.PluginVer = "0.0.1";
            this.PluginDesc = "到底是搞基还是搞基还是搞基呢, 投票来决定一下吧";
            try
            {
                /////// 应该在最前初始化 而并非强制要求构造函数内
                this._path = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\弹幕姬\Plugins\Configs\TPJ\";
                Global_Variable.config = new Config(this._path + @"GlobalConfig.ini", true);
            }catch(Exception e)
            {
                this.Log("插件初始化意外失败, 请联系插件作者 "+this.PluginAuth+", 错误:" + e.Message);
            }
        }


        private void TPJ_ReceivedRoomCount(object sender, BilibiliDM_PluginFramework.ReceivedRoomCountArgs e)
        {
        }

        private void TPJ_ReceivedDanmaku(object sender, BilibiliDM_PluginFramework.ReceivedDanmakuArgs e)
        {
            if (e.Danmaku.MsgType == MsgTypeEnum.Comment)
            {
                do
                {
                    string msg_value = e.Danmaku.CommentText.Trim();
                    if (msg_value.Count() <= 1) // 必须拥有至少 标识符+命令+参数 个字符
                        break;
                    char dm_type = msg_value[0];
                    string dm_value = msg_value.Substring(1);
                    if (dm_value.Count() <= 0)
                        break;
                    switch (dm_type)
                    {
                        case '@': // 用户投票
                            {
                                if (this.tpj_main.tp_start == false)
                                    goto default;
                                this.addUserItem((short)(this.tpj_main.getSettingAllowUseFullName() ? 0 : 1), e.Danmaku.CommentUser, dm_value);
                            }
                            break;
                        case '#': // 用户添加票项
                            goto default;
                        //break;
                        case '%': // 房管
                            break;
                        case '$':
                            goto default;
                        //break;
                        default:
                            goto _END;
                    }
                } while (false);
            _END: ;
            }
            else
            {
                // Drop This Msg
            }
        }

        private void TPJ_Disconnected(object sender, BilibiliDM_PluginFramework.DisconnectEvtArgs e)
        {
            
        }

        private void TPJ_Connected(object sender, BilibiliDM_PluginFramework.ConnectedEvtArgs e)
        {
        }

        public override void Admin()
        {
            base.Admin();
            this.createTPJMain();
            this.tpj_main.Show();
        }

        public override void Stop()
        {
            base.Stop();
            this.plugin_status = false;
        }

        public override void Start()
        {
            base.Start();
            this.plugin_status = true;
            this.createTPJMain();
        }

        private void createTPJMain()
        {
            if (this.tpj_main == null || this.tpj_main.IsDisposed)
            {
                if (this.tpj_main != null)
                    this.tpj_main.Dispose();
                this.tpj_main = new TPJ_Main(this);
            }
        }

        private void disposeTPJMain()
        {
            if (this.tpj_main != null)
            {
                this.tpj_main.Dispose();
                this.tpj_main = null;
            }
        }

        private void addUserItem(short type, string user, string item)
        {
            Regex reg_1;
            if (type == 0)
            {
                // FullName 投票方式
                reg_1 = new Regex(@"(.*)$");
                Match result_1 = reg_1.Match(item);
                if (result_1.Success == true)
                {
                    string full_name = result_1.Groups[1].Value;
                    full_name = full_name == null ? "" : full_name.Trim();
                    if (full_name == string.Empty)
                        return;
                    if (!this.tpj_main.addUserItem(user.Trim(), full_name)) // 如果失败则选择使用ID投票方式
                        this.addUserItem(1, user, item);

                }
            }
            else if(type == 1)
            {
                // Id 投票方式
                reg_1 = new Regex(@"(\d+)(?:$| )");
                Match result_1 = reg_1.Match(item);
                if (result_1.Success == true)
                {
                    int id = int.Parse(result_1.Groups[1].Value);
                    if (id > 0)
                    {
                        this.tpj_main.addUserItem(user.Trim(), id);
                    }
                }
            }
        }
    }

}
