/****************************************************
 * 评论类
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
    /// <summary>
    /// 评论类
    /// </summary>
    public class Comment
    {
        public int CommentId { get; set; }
        public int RecordId { get; set; }
        public string CommentName {get;set;}
        public string Content {get;set;}
        public string Extra { get; set; }

    }
}
