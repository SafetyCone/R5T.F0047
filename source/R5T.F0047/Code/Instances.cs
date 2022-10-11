using System;

using R5T.Z0013;


namespace R5T.F0047
{
    public static class Instances
    {
        public static IGitHubOwnerNames GitHubOwnerNames { get; } = F0047.GitHubOwnerNames.Instance;
        public static IGitHubOwnerOperator GitHubOwnerOperator { get; } = F0047.GitHubOwnerOperator.Instance;
        public static IGitHubOwners GitHubOwners { get; } = F0047.GitHubOwners.Instance;
        public static IOrganizationNamespaceTokens OrganizationNamespaceTokens { get; } = Z0013.OrganizationNamespaceTokens.Instance;
    }
}