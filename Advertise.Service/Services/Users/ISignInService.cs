﻿using System;
using System.Security.Claims;
using System.Threading.Tasks;
using Advertise.Core.Domains.Users;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin.Security;

namespace Advertise.Service.Services.Users
{

    public interface ISignInService : IDisposable
    {
        #region Public Properties

        /// <summary>
        /// Used to sign in identities 
        /// </summary>
        IAuthenticationManager AuthenticationManager { get; set; }

        /// <summary>
        /// AuthenticationType that will be used by sign in, defaults to DefaultAuthenticationTypes.ApplicationCookie 
        /// </summary>
        string AuthenticationType { get; set; }

        #endregion Public Properties



        #region Public Methods

        /// <summary>
        /// Convert a string id to the proper Guid using Convert.ChangeType 
        /// </summary>
        /// <param name="id" />
        /// <returns />
        Guid ConvertIdFromString(string id);

        /// <summary>
        /// Convert a Guid userId to a string, by default this just calls ToString() 
        /// </summary>
        /// <param name="id" />
        /// <returns />
        string ConvertIdToString(Guid id);

        /// <summary>
        /// Called to generate the ClaimsIdentity for the user, override to add additional claims
        /// before SignIn
        /// </summary>
        /// <param name="user" />
        /// <returns />
        Task<ClaimsIdentity> CreateUserIdentityAsync(User user);

        /// <summary>
        /// Sign the user in using an associated external login 
        /// </summary>
        /// <param name="loginInfo" />   
        /// <param name="isPersistent" />
        /// <returns />
        Task<SignInStatus> ExternalSignInAsync(ExternalLoginInfo loginInfo, bool isPersistent);

        /// <summary>
        /// Get the user id that has been verified already or null. 
        /// </summary>
        /// <returns />
        Task<Guid> GetVerifiedUserIdAsync();

        /// <summary>
        /// Has the user been verified (ie either via password or external login) 
        /// </summary>
        /// <returns />
        Task<bool> HasBeenVerifiedAsync();

        /// <summary>
        /// Sign in the user in using the user name and password 
        /// </summary>
        /// <param name="userName" />     
        /// <param name="password" />     
        /// <param name="isPersistent" /> 
        /// <param name="shouldLockout" />
        /// <returns />
        Task<SignInStatus> PasswordSignInAsync(string userName, string password, bool isPersistent, bool shouldLockout);

        /// <summary>
        /// Send a two factor code to a user 
        /// </summary>
        /// <param name="provider" />
        /// <returns />
        Task<bool> SendTwoFactorCodeAsync(string provider);

        /// <summary>
        /// Creates a user identity and then signs the identity using the AuthenticationManager 
        /// </summary>
        /// <param name="user" />           
        /// <param name="isPersistent" />   
        /// <param name="rememberBrowser" />
        /// <returns />
        Task SignInAsync(User user, bool isPersistent, bool rememberBrowser);

        /// <summary>
        /// Two factor verification step 
        /// </summary>
        /// <param name="provider" />       
        /// <param name="code" />           
        /// <param name="isPersistent" />   
        /// <param name="rememberBrowser" />
        /// <returns />
        Task<SignInStatus> TwoFactorSignInAsync(string provider, string code, bool isPersistent, bool rememberBrowser);

        #endregion Public Methods
    }
}