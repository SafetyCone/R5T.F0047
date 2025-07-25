using System;


namespace R5T.F0047
{
    public class GitHubOwnerNameSets : IGitHubOwnerNameSets
    {
        #region Infrastructure

        public static IGitHubOwnerNameSets Instance { get; } = new GitHubOwnerNameSets();


        private GitHubOwnerNameSets()
        {
        }

        #endregion
    }
}
