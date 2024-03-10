using Microsoft.EntityFrameworkCore;
using NydahlsWebshop1000.Data;
using NydahlsWebshop1000.Models;

namespace NydahlsWebshop1000.Repository;
public class UserRepository
{
    private readonly ApplicationDbContext _context;
    public UserRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task UpdateUser(ApplicationUser hippoLoverUser)
    {
        _context.Update(hippoLoverUser);
        await _context.SaveChangesAsync();
    }

    public async Task<ApplicationUser> GetUserCartItemsInfo(ApplicationUser hippoLoverUser)
    {
       return await _context.Users.Include(u => u.CartItems).FirstAsync(u => u.Id == hippoLoverUser.Id);
    }

    public async Task AddCartItemToUser(ApplicationUser hippoLoverUser, CartItem cartItem)
    {
        if (hippoLoverUser != null)
        {
            hippoLoverUser.CartItems.Add(cartItem);
            await UpdateUser(hippoLoverUser);
            //nollställ cartItem
            cartItem = new CartItem { Name = "", Price = 0 };
        }
    }
}
