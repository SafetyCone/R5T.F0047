using System;


namespace R5T.F0047
{
    public static class Instances
    {
        public static L0066.IExceptionOperator ExceptionOperator => L0066.ExceptionOperator.Instance;
        public static IGitHubOwnerNames GitHubOwnerNames { get; } = F0047.GitHubOwnerNames.Instance;
        public static IGitHubOwnerOperator GitHubOwnerOperator { get; } = F0047.GitHubOwnerOperator.Instance;
        public static IGitHubOwners GitHubOwners { get; } = F0047.GitHubOwners.Instance;
        public static Z0013.IOrganizationNamespaceTokens OrganizationNamespaceTokens { get; } = Z0013.OrganizationNamespaceTokens.Instance;
        public static L0066.ISwitchOperator SwitchOperator => L0066.SwitchOperator.Instance;
    }
}