using System;


namespace R5T.F0047
{
	public class GitHubOwnerNames : IGitHubOwnerNames
	{
		#region Infrastructure

	    public static IGitHubOwnerNames Instance { get; } = new GitHubOwnerNames();

	    private GitHubOwnerNames()
	    {
        }

	    #endregion
	}
}