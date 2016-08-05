using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Localization;

namespace Liuhl.AbpDemo.Mapping
{
    public class LanguageTextMap : EntityTypeConfiguration<ApplicationLanguageText>
    {
        public LanguageTextMap()
        {
            ToTable("LanguageTexts");
        }
    }
}
