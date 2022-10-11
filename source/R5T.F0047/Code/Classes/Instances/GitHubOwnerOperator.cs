using System;


namespace R5T.F0047
{
	public class GitHubOwnerOperator : IGitHubOwnerOperator
	{
		#region Infrastructure

	    public static IGitHubOwnerOperator Instance { get; } = new GitHubOwnerOperator();

	    private GitHubOwnerOperator()
	    {
        }

	    #endregion
	}
}