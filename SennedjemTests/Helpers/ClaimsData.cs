﻿using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Text;

namespace SennedjemTests.Helpers
{
    public static class ClaimsData
    {
        public static List<Claim> GetClaims()
        {
            return new List<Claim>()
            {
                new Claim("username", "deneme"),
                new Claim("email", "test@test.com")

            };
        }
    }
}
