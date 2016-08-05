using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Authorization.Users;

namespace Liuhl.AbpDemo.Mapping
{
    public class UserLoginMap : EntityTypeConfiguration<UserLogin>
    {
        public UserLoginMap()
        {
            ToTable("UserLogins");
        }
    }
}
