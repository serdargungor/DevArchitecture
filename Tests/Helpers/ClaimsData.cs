﻿namespace Tests.Helpers
{
    using System.Collections.Generic;
    using System.Security.Claims;

    public static class ClaimsData
	{
		public static List<Claim> GetClaims()
		{
			return new ()
			{
				new Claim("username", "deneme"),
				new Claim("email", "test@test.com")

			};
		}
	}
}
