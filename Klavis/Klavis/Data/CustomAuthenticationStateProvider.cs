using System;
using System.Security.Claims;
using System.Linq;
using System.Threading.Tasks; 
using Microsoft.AspNetCore.Components.Authorization;

namespace Klavis.Data
{
	public class CustomAuthenticationStateProvider : AuthenticationStateProvider
	{
		public override Task<AuthenticationState> GetAuthenticationStateAsync()
		{
			var identity = new ClaimsIdentity(); 
			var adm = new ClaimsPrincipal(identity);

			return Task.FromResult(new AuthenticationState(adm));
		
		}

		public void MarkUserAsAuthenticated(string emailAddress)
        {
			var identity = new ClaimsIdentity(new[]
			{
		    new Claim(ClaimTypes.Name,emailAddress),
			}, "apiauth type");

			//var identity = new ClaimsIdentity();
			var adm = new ClaimsPrincipal(identity);

			NotifyAuthenticationStateChanged(Task.FromResult(new AuthenticationState(adm))); 

		}
	}

	
}

