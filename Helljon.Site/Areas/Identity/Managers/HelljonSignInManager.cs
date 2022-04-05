using Helljon.Site.Data;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Helljon.Site.Areas.Identity.Managers {
    public class HelljonSignInManager<TUser> : SignInManager<TUser> where TUser : HelljonUser {
        public HelljonSignInManager(
            UserManager<TUser> userManager, 
            IHttpContextAccessor contextAccessor, 
            IUserClaimsPrincipalFactory<TUser> claimsFactory, 
            IOptions<IdentityOptions> optionsAccessor, 
            ILogger<SignInManager<TUser>> logger, 
            IAuthenticationSchemeProvider schemes, 
            IUserConfirmation<TUser> confirmation) 
            : base(userManager, contextAccessor, claimsFactory, optionsAccessor, logger, schemes, confirmation) {
        }

        public override Task<bool> CanSignInAsync(TUser user) {
            return base.CanSignInAsync(user);
        }

        public override Task<SignInResult> CheckPasswordSignInAsync(TUser user, string password, bool lockoutOnFailure) {
            return base.CheckPasswordSignInAsync(user, password, lockoutOnFailure);
        }

        public override AuthenticationProperties ConfigureExternalAuthenticationProperties(string provider, string redirectUrl, string userId = null) {
            return base.ConfigureExternalAuthenticationProperties(provider, redirectUrl, userId);
        }

        public override Task<ClaimsPrincipal> CreateUserPrincipalAsync(TUser user) {
            return base.CreateUserPrincipalAsync(user);
        }

        public override bool Equals(object obj) {
            return base.Equals(obj);
        }

        public override int GetHashCode() {
            return base.GetHashCode();
        }

        public override bool IsSignedIn(ClaimsPrincipal principal) {
            return base.IsSignedIn(principal);
        }

        public override Task<SignInResult> PasswordSignInAsync(TUser user, string password, bool isPersistent, bool lockoutOnFailure) {
            return base.PasswordSignInAsync(user, password, isPersistent, lockoutOnFailure);
        }

        public override Task<SignInResult> PasswordSignInAsync(string userName, string password, bool isPersistent, bool lockoutOnFailure) {
            return base.PasswordSignInAsync(userName, password, isPersistent, lockoutOnFailure);
        }

        public override Task RefreshSignInAsync(TUser user) {
            return base.RefreshSignInAsync(user);
        }

        public override Task SignInAsync(TUser user, bool isPersistent, string authenticationMethod = null) {
            return base.SignInAsync(user, isPersistent, authenticationMethod);
        }

        public override Task SignInAsync(TUser user, AuthenticationProperties authenticationProperties, string authenticationMethod = null) {
            return base.SignInAsync(user, authenticationProperties, authenticationMethod);
        }

        public override Task SignInWithClaimsAsync(TUser user, bool isPersistent, IEnumerable<Claim> additionalClaims) {
            return base.SignInWithClaimsAsync(user, isPersistent, additionalClaims);
        }

        public override Task SignInWithClaimsAsync(TUser user, AuthenticationProperties authenticationProperties, IEnumerable<Claim> additionalClaims) {
            return base.SignInWithClaimsAsync(user, authenticationProperties, additionalClaims);
        }

        public override Task SignOutAsync() {
            return base.SignOutAsync();
        }

        public override string ToString() {
            return base.ToString();
        }

        public override Task<IdentityResult> UpdateExternalAuthenticationTokensAsync(ExternalLoginInfo externalLogin) {
            return base.UpdateExternalAuthenticationTokensAsync(externalLogin);
        }

        public override Task<TUser> ValidateSecurityStampAsync(ClaimsPrincipal principal) {
            return base.ValidateSecurityStampAsync(principal);
        }

        public override Task<bool> ValidateSecurityStampAsync(TUser user, string securityStamp) {
            return base.ValidateSecurityStampAsync(user, securityStamp);
        }

        protected override Task<bool> IsLockedOut(TUser user) {
            return base.IsLockedOut(user);
        }

        protected override Task<SignInResult> LockedOut(TUser user) {
            return base.LockedOut(user);
        }

        protected override Task<SignInResult> PreSignInCheck(TUser user) {
            return base.PreSignInCheck(user);
        }

        protected override Task ResetLockout(TUser user) {
            return base.ResetLockout(user);
        }

    }
}
