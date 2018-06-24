using System.Security.Principal;
using System.Security.AccessControl;

namespace Tests
{
    public static class ExtensionMethods
    {
        public static FileSystemAccessRule GetMatchingAccessRuleOrDefault(
            this AuthorizationRuleCollection arc,
            IdentityReference identityReference)
        {
            foreach (var rule in arc)
            {
                var accessRule = (FileSystemAccessRule)rule;
                if (identityReference == accessRule.IdentityReference)
                {
                    return accessRule;
                }
            }
            return null;
        }
    }
}
