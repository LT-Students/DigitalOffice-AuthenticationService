﻿using System;

namespace LT.DigitalOffice.AuthService.Token.Interfaces
{
    public interface ITokenEngine
    {
        /// <summary>
        /// Create new token based on user login.
        /// </summary>
        string Create(Guid userId);
    }
}
