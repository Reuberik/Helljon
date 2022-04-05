using Helljon.Site.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading;
using System.Threading.Tasks;

namespace Helljon.Site.Areas.Identity.Managers {
    public class HelljonRoleManager<TUser> : RoleManager<TUser> where TUser : HelljonUser {
        public HelljonRoleManager(
            IRoleStore<TUser> store, 
            IEnumerable<IRoleValidator<TUser>> roleValidators, 
            ILookupNormalizer keyNormalizer, 
            IdentityErrorDescriber errors, 
            ILogger<RoleManager<TUser>> logger) 
            : base(store, roleValidators, keyNormalizer, errors, logger) {
        }

        public override ILogger Logger { get => base.Logger; set => base.Logger = value; }

        public override IQueryable<TUser> Roles => base.Roles;

        public override bool SupportsQueryableRoles => base.SupportsQueryableRoles;

        public override bool SupportsRoleClaims => base.SupportsRoleClaims;

        protected override CancellationToken CancellationToken => base.CancellationToken;

        public override Task<IdentityResult> AddClaimAsync(TUser role, Claim claim) {
            return base.AddClaimAsync(role, claim);
        }

        public override Task<IdentityResult> CreateAsync(TUser role) {
            return base.CreateAsync(role);
        }

        public override Task<IdentityResult> DeleteAsync(TUser role) {
            return base.DeleteAsync(role);
        }

        public override bool Equals(object obj) {
            return base.Equals(obj);
        }

        public override Task<TUser> FindByIdAsync(string roleId) {
            return base.FindByIdAsync(roleId);
        }

        public override Task<TUser> FindByNameAsync(string roleName) {
            return base.FindByNameAsync(roleName);
        }

        public override Task<IList<Claim>> GetClaimsAsync(TUser role) {
            return base.GetClaimsAsync(role);
        }

        public override int GetHashCode() {
            return base.GetHashCode();
        }

        public override Task<string> GetRoleIdAsync(TUser role) {
            return base.GetRoleIdAsync(role);
        }

        public override Task<string> GetRoleNameAsync(TUser role) {
            return base.GetRoleNameAsync(role);
        }

        public override string NormalizeKey(string key) {
            return base.NormalizeKey(key);
        }

        public override Task<IdentityResult> RemoveClaimAsync(TUser role, Claim claim) {
            return base.RemoveClaimAsync(role, claim);
        }

        public override Task<bool> RoleExistsAsync(string roleName) {
            return base.RoleExistsAsync(roleName);
        }

        public override Task<IdentityResult> SetRoleNameAsync(TUser role, string name) {
            return base.SetRoleNameAsync(role, name);
        }

        public override string ToString() {
            return base.ToString();
        }

        public override Task<IdentityResult> UpdateAsync(TUser role) {
            return base.UpdateAsync(role);
        }

        public override Task UpdateNormalizedRoleNameAsync(TUser role) {
            return base.UpdateNormalizedRoleNameAsync(role);
        }

        protected override void Dispose(bool disposing) {
            base.Dispose(disposing);
        }

        protected override Task<IdentityResult> UpdateRoleAsync(TUser role) {
            return base.UpdateRoleAsync(role);
        }

        protected override Task<IdentityResult> ValidateRoleAsync(TUser role) {
            return base.ValidateRoleAsync(role);
        }
    }
}
