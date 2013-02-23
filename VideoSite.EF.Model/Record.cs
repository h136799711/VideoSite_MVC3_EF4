/****************************************************
 * 记录类，表示一条用户发布的记录
 * 创建日期：2013-02-23 
 * 作者:何必都
 * 最近修改日期：2013-02-23 
 ****************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VideoSite.EF.Model
{

    public class Record
    {
        public int RecordID {get;set;}
        public DateTime PublishTime { get; set; }
        public string Content { get; set; }
        public string TagIdList { get; set; }
        public string CommentsIdList { get; set; }
        public DateTime ModifyDate { get; set; }
        public string Extra { get; set; }
    }
}