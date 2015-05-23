using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NP.DAL.Security;

namespace NP.BLL.DomainModel.Security
{
    public class RoleModel
    {
        public int Id { get; set; }
        public string RoleName { get; set; }
        public string RoleResponsibility { get; set; }

        public virtual ICollection<UserInformation> UserInformations { get; set; }
    }
}
