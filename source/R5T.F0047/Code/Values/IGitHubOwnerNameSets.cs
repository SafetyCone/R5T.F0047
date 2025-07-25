using System;

using R5T.T0131;


namespace R5T.F0047
{
    [ValuesMarker]
    public partial interface IGitHubOwnerNameSets : IValuesMarker
    {
        public string[] All => new[]
        {
            Instances.GitHubOwnerNames.DavidCoats,
            Instances.GitHubOwnerNames.Functionairy,
            Instances.GitHubOwnerNames.SafetyCone,
        };
    }
}
