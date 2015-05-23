using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NP.DAL.Security;

namespace NP.DAL.Security.Repository
{
    public interface IRoleRepository
    {
        void CreateRole(Role role);
        List<Role> GetRoleList();
        Role GetRoleById(long Id);
    }

    public class RoleRepository : IRoleRepository
    {
        private NPSecurity  _npSecurity = new NPSecurity();
        public void CreateRole(Role role)
        {
            _npSecurity.Roles.Add(role);
            _npSecurity.SaveChanges();
        }

        public List<Role> GetRoleList()
        {
           return _npSecurity.Roles.ToList();
        }

        public Role GetRoleById(long Id)
        {
            return _npSecurity.Roles.ToList().Where(p=>p.Id==Id).FirstOrDefault();
        }
    }
}
