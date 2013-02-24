/****************************************************
 * 用户类 ，主要用户登录
 * 创建日期：2013-02-23 
 * 作者:何必都
 * 最近修改日期：2013-02-23 
 ****************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
namespace VideoSite.EF.Model
{

    /// <summary>
    /// 用户类
    /// </summary>
    public class User
    {
        public int UserId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public int UserInfoId { get; set; }
        public string Extra { get; set; }
        public virtual ICollection<Record> Record { get; set; }
    }
}
