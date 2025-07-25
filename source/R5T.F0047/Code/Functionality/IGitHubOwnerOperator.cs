using System;

using R5T.T0132;


namespace R5T.F0047
{
	[FunctionalityMarker]
	public partial interface IGitHubOwnerOperator : IFunctionalityMarker
	{
		public string Get_OrganizationNamespaceToken(string owner)
		{
			var output = owner switch
			{
				_ when owner == Instances.GitHubOwners.DavidCoats => Instances.OrganizationNamespaceTokens.D8S,
                _ when owner == Instances.GitHubOwners.Functionairy => Instances.OrganizationNamespaceTokens.F10Y,
                _ when owner == Instances.GitHubOwners.SafetyCone => Instances.OrganizationNamespaceTokens.R5T,
				_ => throw Instances.ExceptionOperator.Get_UnhandledValueException(owner),
			};

			return output;
		}

		public string Get_GitHubOwnerName(string gitHubOwner)
		{
			var gitHubOwnerName = gitHubOwner switch
			{
				_ when gitHubOwner == Instances.GitHubOwners.DavidCoats => Instances.GitHubOwnerNames.DavidCoats,
                _ when gitHubOwner == Instances.GitHubOwners.Functionairy => Instances.GitHubOwnerNames.Functionairy,
                _ when gitHubOwner == Instances.GitHubOwners.SafetyCone => Instances.GitHubOwnerNames.SafetyCone,
				_ => throw Instances.SwitchOperator.Get_UnrecognizedSwitchValueException(gitHubOwner, nameof(GitHubOwnerNames))
			};

			return gitHubOwnerName;
		}

		public string Get_GitHubOwner(string gitHubOwnerName)
		{
			var gitHubOwner = gitHubOwnerName switch
			{
				_ when gitHubOwnerName == Instances.GitHubOwnerNames.DavidCoats => Instances.GitHubOwners.DavidCoats,
                _ when gitHubOwnerName == Instances.GitHubOwnerNames.Functionairy => Instances.GitHubOwners.Functionairy,
                _ when gitHubOwnerName == Instances.GitHubOwnerNames.SafetyCone => Instances.GitHubOwners.SafetyCone,
				_ => throw Instances.SwitchOperator.Get_UnrecognizedSwitchValueException(gitHubOwnerName, nameof(GitHubOwnerNames))
			};

			return gitHubOwner;
		}
	}
}