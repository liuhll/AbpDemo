using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Authorization.Users;
using Abp.Localization;

namespace Liuhl.AbpDemo.Mapping
{
    public class LanguageMap : EntityTypeConfiguration<ApplicationLanguage>
    {
        public LanguageMap()
        {
            ToTable("Languages");
        }
    }
   
}
