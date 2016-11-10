using QQChat.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QQChat.Base
{
    public class ManagerBase
    {
        public QQChatContext context = null;
        public ManagerBase(QQChatContext context)
        {
            this.context = context;
        }
        /// <summary>
        /// 提交数据
        /// </summary>
        /// <returns></returns>
        public bool Commit()
        {
            try
            {
                context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
