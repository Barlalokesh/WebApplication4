using WebApplication4.Models;

namespace WebApplication4.DAL
{
    public class RoleRepo
    {
        private readonly CartDbContext _cartDbContext;

        public RoleRepo(CartDbContext CartDbContext)
        {
            _cartDbContext = CartDbContext;
        }
        public List<Role> getRoles()
        {
            var data= _cartDbContext.Roles.ToList();
            return data;    
        }
        public Role ?getRoleById(int id) 
        {
            var data = _cartDbContext.Roles.FirstOrDefault(m=>m.Id==id);
            return data;
        }

        public bool AddRoles(Role role)
        {
            try
            {
                _cartDbContext.Roles.Add(role);
                _cartDbContext.SaveChanges();
                return true;
            }
            catch (Exception) 
            {
                return false;
            }

        }

    }
}
