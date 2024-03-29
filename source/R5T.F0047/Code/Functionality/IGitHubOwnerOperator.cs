using System;

using R5T.T0132;


namespace R5T.F0047
{
	[FunctionalityMarker]
	public partial interface IGitHubOwnerOperator : IFunctionalityMarker
	{
		public string GetOrganizationNamespaceToken(string owner)
		{
			var output = owner switch
			{
				_ when owner == Instances.GitHubOwners.DavidCoats => Instances.OrganizationNamespaceTokens.DavidCoats,
				_ when owner == Instances.GitHubOwners.SafetyCone => Instances.OrganizationNamespaceTokens.Rivet,
				_ => throw Instances.ExceptionOperator.Get_UnhandledValueException(owner),
			};

			return output;
		}

		public string GetGitHubOwnerName(string gitHubOwner)
		{
			var gitHubOwnerName = gitHubOwner switch
			{
				_ when gitHubOwner == Instances.GitHubOwners.DavidCoats => Instances.GitHubOwnerNames.DavidCoats,
				_ when gitHubOwner == Instances.GitHubOwners.SafetyCone => Instances.GitHubOwnerNames.SafetyCone,
				_ => throw Instances.SwitchOperator.Get_UnrecognizedSwitchValueException(gitHubOwner, nameof(GitHubOwnerNames))
			};

			return gitHubOwnerName;
		}

		public string GetGitHubOwner(string gitHubOwnerName)
		{
			var gitHubOwner = gitHubOwnerName switch
			{
				_ when gitHubOwnerName == Instances.GitHubOwnerNames.DavidCoats => Instances.GitHubOwners.DavidCoats,
				_ when gitHubOwnerName == Instances.GitHubOwnerNames.SafetyCone => Instances.GitHubOwners.SafetyCone,
				_ => throw Instances.SwitchOperator.Get_UnrecognizedSwitchValueException(gitHubOwnerName, nameof(GitHubOwnerNames))
			};

			return gitHubOwner;
		}
	}
}