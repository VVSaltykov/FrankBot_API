using FrankBot_API.Models;

namespace FrankBot_API.Interfaces
{
    public interface IUserRepositore
    {
        /// <summary>
        /// Checks whether the user is registered
        /// </summary>
        /// <param name="chatId"></param>
        /// <returns></returns>
        public Task<bool> UserIsRegisteredAsync(long chatId);
        /// <summary>
        /// Gets the user by chatid
        /// </summary>
        /// <param name="chatId"></param>
        /// <returns></returns>
        public Task<Users> GetUserByChatIdAsync(long chatId);
        /// <summary>
        /// Gets the user by id
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public Task<Users> GetUserByIdAsync(int Id);
        /// <summary>
        /// Add user to database
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public Task AddUserAsync(Users user);
        /// <summary>
        /// Remove user from database
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public Task DeleteUserAsync(Users user);
        /// <summary>
        /// Add user's money
        /// </summary>
        /// <param name="chatId"></param>
        /// <param name="message"></param>
        /// <returns></returns>
        public Task MoneyAddAsync(long chatId, string message);
        /// <summary>
        /// Сurrency calculation
        /// </summary>
        /// <param name="chatId"></param>
        /// <returns></returns>
        public Task<decimal> CalculationUSDAsync(long chatId);
        /// <summary>
        /// Сurrency calculation
        /// </summary>
        /// <param name="chatId"></param>
        /// <returns></returns>
        public Task<decimal> CalculationAUDAsync(long chatId);
        /// <summary>
        /// Сurrency calculation
        /// </summary>
        /// <param name="chatId"></param>
        /// <returns></returns>
        public Task<decimal> CalculationAZNAsync(long chatId);
        /// <summary>
        /// Сurrency calculation
        /// </summary>
        /// <param name="chatId"></param>
        /// <returns></returns>
        public Task<decimal> CalculationGBPAsync(long chatId);
        /// <summary>
        /// Сurrency calculation
        /// </summary>
        /// <param name="chatId"></param>
        /// <returns></returns>
        public Task<decimal> CalculationAMDAsync(long chatId);
        /// <summary>
        /// Сurrency calculation
        /// </summary>
        /// <param name="chatId"></param>
        /// <returns></returns>
        public Task<decimal> CalculationBYNAsync(long chatId);
        /// <summary>
        /// Сurrency calculation
        /// </summary>
        /// <param name="chatId"></param>
        /// <returns></returns>
        public Task<decimal> CalculationBGNAsync(long chatId);
        /// <summary>
        /// Сurrency calculation
        /// </summary>
        /// <param name="chatId"></param>
        /// <returns></returns>
        public Task<decimal> CalculationBRLAsync(long chatId);
        /// <summary>
        /// Сurrency calculation
        /// </summary>
        /// <param name="chatId"></param>
        /// <returns></returns>
        public Task<decimal> CalculationHUFAsync(long chatId);
        /// <summary>
        /// Сurrency calculation
        /// </summary>
        /// <param name="chatId"></param>
        /// <returns></returns>
        public Task<decimal> CalculationHKDAsync(long chatId);
        /// <summary>
        /// Сurrency calculation
        /// </summary>
        /// <param name="chatId"></param>
        /// <returns></returns>
        public Task<decimal> CalculationDKKAsync(long chatId);
        /// <summary>
        /// Сurrency calculation
        /// </summary>
        /// <param name="chatId"></param>
        /// <returns></returns>
        public Task<decimal> CalculationEURAsync(long chatId);
        /// <summary>
        /// Сurrency calculation
        /// </summary>
        /// <param name="chatId"></param>
        /// <returns></returns>
        public Task<decimal> CalculationINRAsync(long chatId);
        /// <summary>
        /// Сurrency calculation
        /// </summary>
        /// <param name="chatId"></param>
        /// <returns></returns>
        public Task<decimal> CalculationKZTAsync(long chatId);
        /// <summary>
        /// Сurrency calculation
        /// </summary>
        /// <param name="chatId"></param>
        /// <returns></returns>
        public Task<decimal> CalculationCADAsync(long chatId);
        /// <summary>
        /// Сurrency calculation
        /// </summary>
        /// <param name="chatId"></param>
        /// <returns></returns>
        public Task<decimal> CalculationKGSAsync(long chatId);
        /// <summary>
        /// Сurrency calculation
        /// </summary>
        /// <param name="chatId"></param>
        /// <returns></returns>
        public Task<decimal> CalculationCNYAsync(long chatId);
        /// <summary>
        /// Сurrency calculation
        /// </summary>
        /// <param name="chatId"></param>
        /// <returns></returns>
        public Task<decimal> CalculationMDLAsync(long chatId);
        /// <summary>
        /// Сurrency calculation
        /// </summary>
        /// <param name="chatId"></param>
        /// <returns></returns>
        public Task<decimal> CalculationNOKAsync(long chatId);
        /// <summary>
        /// Сurrency calculation
        /// </summary>
        /// <param name="chatId"></param>
        /// <returns></returns>
        public Task<decimal> CalculationPLNAsync(long chatId);
        /// <summary>
        /// Сurrency calculation
        /// </summary>
        /// <param name="chatId"></param>
        /// <returns></returns>
        public Task<decimal> CalculationRONAsync(long chatId);
        /// <summary>
        /// Сurrency calculation
        /// </summary>
        /// <param name="chatId"></param>
        /// <returns></returns>
        public Task<decimal> CalculationXDRAsync(long chatId);
        /// <summary>
        /// Сurrency calculation
        /// </summary>
        /// <param name="chatId"></param>
        /// <returns></returns>
        public Task<decimal> CalculationSGDAsync(long chatId);
        /// <summary>
        /// Сurrency calculation
        /// </summary>
        /// <param name="chatId"></param>
        /// <returns></returns>
        public Task<decimal> CalculationTJSAsync(long chatId);
        /// <summary>
        /// Сurrency calculation
        /// </summary>
        /// <param name="chatId"></param>
        /// <returns></returns>
        public Task<decimal> CalculationTRYAsync(long chatId);
        /// <summary>
        /// Сurrency calculation
        /// </summary>
        /// <param name="chatId"></param>
        /// <returns></returns>
        public Task<decimal> CalculationTMTAsync(long chatId);
        /// <summary>
        /// Сurrency calculation
        /// </summary>
        /// <param name="chatId"></param>
        /// <returns></returns>
        public Task<decimal> CalculationUZSAsync(long chatId);
        /// <summary>
        /// Сurrency calculation
        /// </summary>
        /// <param name="chatId"></param>
        /// <returns></returns>
        public Task<decimal> CalculationUAHAsync(long chatId);
        /// <summary>
        /// Сurrency calculation
        /// </summary>
        /// <param name="chatId"></param>
        /// <returns></returns>
        public Task<decimal> CalculationCZKAsync(long chatId);
        /// <summary>
        /// Сurrency calculation
        /// </summary>
        /// <param name="chatId"></param>
        /// <returns></returns>
        public Task<decimal> CalculationSEKAsync(long chatId);
        /// <summary>
        /// Сurrency calculation
        /// </summary>
        /// <param name="chatId"></param>
        /// <returns></returns>
        public Task<decimal> CalculationCHFAsync(long chatId);
        /// <summary>
        /// Сurrency calculation
        /// </summary>
        /// <param name="chatId"></param>
        /// <returns></returns>
        public Task<decimal> CalculationZARAsync(long chatId);
        /// <summary>
        /// Сurrency calculation
        /// </summary>
        /// <param name="chatId"></param>
        /// <returns></returns>
        public Task<decimal> CalculationKRWAsync(long chatId);
        /// <summary>
        /// Сurrency calculation
        /// </summary>
        /// <param name="chatId"></param>
        /// <returns></returns>
        public Task<decimal> CalculationJPYAsync(long chatId);
    }
}
