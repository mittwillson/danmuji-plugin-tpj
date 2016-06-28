using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DMPlugin_TPJ
{
    public class TP_ITEM
    {
        private int _id;
        private string _item;
        private long _count;
        public TP_ITEM(int _id, string _item, long _count)
        {
            this.id = _id;
            this.item = _item;
            this.count = _count;
        }

        public int id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        public string item
        {
            get { return this._item; }
            set { this._item = value; }
        }

        public long count
        {
            get { return this._count; }
            set { this._count = value; }
        }
    };

    public class TP_USER_ITEM
    {
        private string _user_name;
        private int _tp_id;
        public TP_USER_ITEM(int _id, string _username)
        {
            this._tp_id = _id;
            this._user_name = _username;
        }
        public TP_ITEM getItem(List<TP_ITEM> _items)
        {
            foreach (TP_ITEM i in _items)
            {
                if (i.id == this.tp_id)
                    return i;
            }
            return null;
        }

        public string user_name
        {
            get { return this._user_name; }
            set { this._user_name = value; }
        }

        public int tp_id
        {
            get { return this._tp_id; }
            set { this._tp_id = value; }
        }
    }
}
