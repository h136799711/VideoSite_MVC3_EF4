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
namespace VideoSite.EF.Model
{
    public class User
    {
        public int UserId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public int UserInfoId { get; set; }
        public string Extra { get; set; }
    }
}
