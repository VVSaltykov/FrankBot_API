using FrankBot_API.Models;
using Microsoft.EntityFrameworkCore;
using FrankBot_API.Exceptions;
using FrankBot_API.Interfaces;

namespace FrankBot_API.Repositories
{
    public class UserRepositore: IUserRepositore
    {
        private static readonly AppDbContext appDBContext;
        public async Task<bool> UserIsRegisteredAsync(long chatId)
        {
            try
            {
                await GetUserByChatIdAsync(chatId);
                return true;
            }
            catch (NullException)
            {
                return false;
            }
        }
        public async Task<Users> GetUserByChatIdAsync(long chatId)
        {
            var user = await appDBContext.User.Where(u => u.ChatId == chatId).FirstOrDefaultAsync();
            if (user == null)
            {
                throw new NullException();
            }
            return user;
        }
        public async Task<Users> GetUserByIdAsync(int Id)
        {
            var user = await appDBContext.User.Where(u => u.Id == Id).FirstOrDefaultAsync();
            if (user == null)
            {
                throw new NullException();
            }
            return user;
        }
        public async Task AddUserAsync(int Id)
        {
            try
            {
                var user = await appDBContext.User.Where(u => u.Id == Id).FirstOrDefaultAsync();
                await appDBContext.User.AddAsync(user);
                await appDBContext.SaveChangesAsync();
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public async Task DeleteUserAsync(int Id)
        {
            var user = await appDBContext.User.Where(u => u.Id == Id).FirstOrDefaultAsync();
            appDBContext.User.Remove(user);
            await appDBContext.SaveChangesAsync();
        }
        public async Task MoneyAddAsync(long chatId, string message)
        {
            var user = await GetUserByChatIdAsync(chatId);
            user.Money = message;
            await appDBContext.SaveChangesAsync();
        }
        public async Task<decimal> CalculationUSDAsync(long chatId)
        {
            var user = await GetUserByChatIdAsync(chatId);
            decimal calc = CurrentRepositore.USDReader() / decimal.Parse(user.Money);
            return calc;
        }
        public async Task<decimal> CalculationAUDAsync(long chatId)
        {
            var user = await GetUserByChatIdAsync(chatId);
            decimal calc = CurrentRepositore.AUDReader() / decimal.Parse(user.Money);
            return calc;
        }
        public async Task<decimal> CalculationAZNAsync(long chatId)
        {
            var user = await GetUserByChatIdAsync(chatId);
            decimal calc = CurrentRepositore.AZNReader() / decimal.Parse(user.Money);
            return calc;
        }
        public async Task<decimal> CalculationGBPAsync(long chatId)
        {
            var user = await GetUserByChatIdAsync(chatId);
            decimal calc = CurrentRepositore.GBPReader() / decimal.Parse(user.Money);
            return calc;
        }
        public async Task<decimal> CalculationAMDAsync(long chatId)
        {
            var user = await GetUserByChatIdAsync(chatId);
            decimal calc = CurrentRepositore.AMDReader() / decimal.Parse(user.Money);
            return calc;
        }
        public async Task<decimal> CalculationBYNAsync(long chatId)
        {
            var user = await GetUserByChatIdAsync(chatId);
            decimal calc = CurrentRepositore.BYNReader() / decimal.Parse(user.Money);
            return calc;
        }
        public async Task<decimal> CalculationBGNAsync(long chatId)
        {
            var user = await GetUserByChatIdAsync(chatId);
            decimal calc = CurrentRepositore.BGNReader() / decimal.Parse(user.Money);
            return calc;
        }
        public async Task<decimal> CalculationBRLAsync(long chatId)
        {
            var user = await GetUserByChatIdAsync(chatId);
            decimal calc = CurrentRepositore.BRLReader() / decimal.Parse(user.Money);
            return calc;
        }
        public async Task<decimal> CalculationHUFAsync(long chatId)
        {
            var user = await GetUserByChatIdAsync(chatId);
            decimal calc = CurrentRepositore.HUFReader() / decimal.Parse(user.Money);
            return calc;
        }
        public async Task<decimal> CalculationHKDAsync(long chatId)
        {
            var user = await GetUserByChatIdAsync(chatId);
            decimal calc = CurrentRepositore.HKDReader() / decimal.Parse(user.Money);
            return calc;
        }
        public async Task<decimal> CalculationDKKAsync(long chatId)
        {
            var user = await GetUserByChatIdAsync(chatId);
            decimal calc = CurrentRepositore.DKKReader() / decimal.Parse(user.Money);
            return calc;
        }
        public async Task<decimal> CalculationEURAsync(long chatId)
        {
            var user = await GetUserByChatIdAsync(chatId);
            decimal calc = CurrentRepositore.EURReader() / decimal.Parse(user.Money);
            return calc;
        }
        public async Task<decimal> CalculationINRAsync(long chatId)
        {
            var user = await GetUserByChatIdAsync(chatId);
            decimal calc = CurrentRepositore.INRReader() / decimal.Parse(user.Money);
            return calc;
        }
        public async Task<decimal> CalculationKZTAsync(long chatId)
        {
            var user = await GetUserByChatIdAsync(chatId);
            decimal calc = CurrentRepositore.KZTReader() / decimal.Parse(user.Money);
            return calc;
        }
        public async Task<decimal> CalculationCADAsync(long chatId)
        {
            var user = await GetUserByChatIdAsync(chatId);
            decimal calc = CurrentRepositore.CADReader() / decimal.Parse(user.Money);
            return calc;
        }
        public async Task<decimal> CalculationKGSAsync(long chatId)
        {
            var user = await GetUserByChatIdAsync(chatId);
            decimal calc = CurrentRepositore.KGSReader() / decimal.Parse(user.Money);
            return calc;
        }
        public async Task<decimal> CalculationCNYAsync(long chatId)
        {
            var user = await GetUserByChatIdAsync(chatId);
            decimal calc = CurrentRepositore.CNYReader() / decimal.Parse(user.Money);
            return calc;
        }
        public async Task<decimal> CalculationMDLAsync(long chatId)
        {
            var user = await GetUserByChatIdAsync(chatId);
            decimal calc = CurrentRepositore.MDLReader() / decimal.Parse(user.Money);
            return calc;
        }
        public async Task<decimal> CalculationNOKAsync(long chatId)
        {
            var user = await GetUserByChatIdAsync(chatId);
            decimal calc = CurrentRepositore.NOKReader() / decimal.Parse(user.Money);
            return calc;
        }
        public async Task<decimal> CalculationPLNAsync(long chatId)
        {
            var user = await GetUserByChatIdAsync(chatId);
            decimal calc = CurrentRepositore.PLNReader() / decimal.Parse(user.Money);
            return calc;
        }
        public async Task<decimal> CalculationRONAsync(long chatId)
        {
            var user = await GetUserByChatIdAsync(chatId);
            decimal calc = CurrentRepositore.RONReader() / decimal.Parse(user.Money);
            return calc;
        }
        public async Task<decimal> CalculationXDRAsync(long chatId)
        {
            var user = await GetUserByChatIdAsync(chatId);
            decimal calc = CurrentRepositore.XDRReader() / decimal.Parse(user.Money);
            return calc;
        }
        public async Task<decimal> CalculationSGDAsync(long chatId)
        {
            var user = await GetUserByChatIdAsync(chatId);
            decimal calc = CurrentRepositore.SGDReader() / decimal.Parse(user.Money);
            return calc;
        }
        public async Task<decimal> CalculationTJSAsync(long chatId)
        {
            var user = await GetUserByChatIdAsync(chatId);
            decimal calc = CurrentRepositore.TJSReader() / decimal.Parse(user.Money);
            return calc;
        }
        public async Task<decimal> CalculationTRYAsync(long chatId)
        {
            var user = await GetUserByChatIdAsync(chatId);
            decimal calc = CurrentRepositore.TRYReader() / decimal.Parse(user.Money);
            return calc;
        }
        public async Task<decimal> CalculationTMTAsync(long chatId)
        {
            var user = await GetUserByChatIdAsync(chatId);
            decimal calc = CurrentRepositore.TMTReader() / decimal.Parse(user.Money);
            return calc;
        }
        public async Task<decimal> CalculationUZSAsync(long chatId)
        {
            var user = await GetUserByChatIdAsync(chatId);
            decimal calc = CurrentRepositore.UZSReader() / decimal.Parse(user.Money);
            return calc;
        }
        public async Task<decimal> CalculationUAHAsync(long chatId)
        {
            var user = await GetUserByChatIdAsync(chatId);
            decimal calc = CurrentRepositore.UAHReader() / decimal.Parse(user.Money);
            return calc;
        }
        public async Task<decimal> CalculationCZKAsync(long chatId)
        {
            var user = await GetUserByChatIdAsync(chatId);
            decimal calc = CurrentRepositore.CZKReader() / decimal.Parse(user.Money);
            return calc;
        }
        public async Task<decimal> CalculationSEKAsync(long chatId)
        {
            var user = await GetUserByChatIdAsync(chatId);
            decimal calc = CurrentRepositore.SEKReader() / decimal.Parse(user.Money);
            return calc;
        }
        public async Task<decimal> CalculationCHFAsync(long chatId)
        {
            var user = await GetUserByChatIdAsync(chatId);
            decimal calc = CurrentRepositore.CHFReader() / decimal.Parse(user.Money);
            return calc;
        }
        public async Task<decimal> CalculationZARAsync(long chatId)
        {
            var user = await GetUserByChatIdAsync(chatId);
            decimal calc = CurrentRepositore.ZARReader() / decimal.Parse(user.Money);
            return calc;
        }
        public async Task<decimal> CalculationKRWAsync(long chatId)
        {
            var user = await GetUserByChatIdAsync(chatId);
            decimal calc = CurrentRepositore.KRWReader() / decimal.Parse(user.Money);
            return calc;
        }
        public async Task<decimal> CalculationJPYAsync(long chatId)
        {
            var user = await GetUserByChatIdAsync(chatId);
            decimal calc = CurrentRepositore.JPYReader() / decimal.Parse(user.Money);
            return calc;
        }

    }
}
