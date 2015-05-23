using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using NP.BLL.DomainModel.Security;
using NP.DAL.Security;

namespace NP.BLL.AutoMapper
{
    public class DatabaseToDomain : Profile
    {
        protected override void Configure()
        {
            CreateMap<Role,RoleModel>();
        }
    }
}
