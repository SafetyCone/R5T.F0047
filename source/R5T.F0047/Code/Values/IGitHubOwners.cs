using System;

using R5T.T0131;


namespace R5T.F0047
{
	[ValuesMarker]
	public partial interface IGitHubOwners : IValuesMarker
	{
		/// <summary>
		/// <para><value>davidcoats</value></para>
		/// </summary>
		public string DavidCoats => "davidcoats";

		/// <summary>
		/// <para><value>Functionairy</value></para>
		/// </summary>
        public string Functionairy => "Functionairy";

		/// <summary>
		/// <para><value>SafetyCone</value></para>
		/// </summary>
        public string SafetyCone => "SafetyCone";
	}
}