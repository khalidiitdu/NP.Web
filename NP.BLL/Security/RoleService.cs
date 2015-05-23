using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using NP.BLL.DomainModel.Security;
using NP.DAL.Security;
using NP.DAL.Security.Repository;

namespace NP.BLL.Security
{
    public interface IRoleService
    {
        void CreateRole(RoleModel roleModel);
        List<RoleModel> GetRoleList();
        RoleModel GetRoleById(long Id);
    }

    public class RoleService : IRoleService
    {
        private readonly IRoleRepository _roleRepository;
        public RoleService(IRoleRepository roleRepository)
        {
            _roleRepository = roleRepository;
        }

        public void CreateRole(RoleModel roleModel)
        {
            var role = Mapper.Map<RoleModel, Role>(roleModel);
            _roleRepository.CreateRole(role);
        }

        public List<RoleModel> GetRoleList()
        {

            return Mapper.Map<List<Role>, List<RoleModel>>(_roleRepository.GetRoleList());
        }

        public RoleModel GetRoleById(long Id)
        {
            return Mapper.Map<Role, RoleModel>(_roleRepository.GetRoleById(Id));
        }
    }
}
