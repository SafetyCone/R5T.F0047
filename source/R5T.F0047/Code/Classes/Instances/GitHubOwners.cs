using System;


namespace R5T.F0047
{
	public class GitHubOwners : IGitHubOwners
	{
		#region Infrastructure

	    public static IGitHubOwners Instance { get; } = new GitHubOwners();

	    private GitHubOwners()
	    {
        }

	    #endregion
	}
}