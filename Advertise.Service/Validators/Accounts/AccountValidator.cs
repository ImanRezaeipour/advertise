using Advertise.Service.Services.Users;

namespace Advertise.Service.Validators.Accounts
{

    public class AccountValidator : IAccountValidator
    {
        #region Private Fields

        private readonly IAccountService _accountService;
        private readonly IUserService _userService;

        #endregion Private Fields

        #region Public Constructors

        /// <summary>
        ///
        /// </summary>
        /// <param name="userService"></param>
        public AccountValidator(IUserService userService, IAccountService accountService)
        {
            _userService = userService;
            _accountService = accountService;
        }

        #endregion Public Constructors

        #region Public Methods

        #endregion Public Methods
    }
}