namespace Capathon_BackEnd.Data
{
    public class AuthRepository : IAuthRepository
    {
    //     private readonly CapathonBroadwayContext _context;
    //     public AuthRepository(CapathonBroadwayContext context ){
    //         _context = context;
    //     }
    //     public Task<ServiceResponse<string>> Login(string username, string password)
    //     {
    //         throw new NotImplementedException();
    //     }

    //     public async Task<ServiceResponse<int>> Register(User user, string password)
    //     {
    //         CreatePasswordHash(password, out byte[] passwordHash, out byte[] passwordSalt);

    //         user.PasswordHash = passwordHash;
    //         user.PasswordSalt = passwordSalt;

    //         _context.Users.Add(user);
    //         await _context.SaveChangesAsync();
    //         var response = new ServiceResponse<int>();
    //         response.Data = user.UId;
    //         return response;
    //     }

    //     public Task<bool> UserExists(string username)
    //     {
    //         throw new NotImplementedException();
    //     }

    //     private void CreatePasswordHash(string password, out byte[] passwordHash, out byte[] passwordSalt){

    //         using(var hmac = new System.Security.Cryptography.HMACSHA512()){
    //             passwordSalt = hmac.Key;
    //             passwordHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
    //         }
    //     }
    }
}