﻿// -----------------------------------------------------------------------
// <copyright file="SybaseSqlCharacters.cs" company="MicroLite">
// Copyright 2012 - 2014 Project Contributors
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//    http://www.apache.org/licenses/LICENSE-2.0
//
// </copyright>
// -----------------------------------------------------------------------
namespace MicroLite.Dialect
{
    /// <summary>
    /// The implementation of <see cref="SqlCharacters"/> for Sybase.
    /// </summary>
    internal sealed class SybaseSqlCharacters : SqlCharacters
    {
        /// <summary>
        /// The single instance of <see cref="SqlCharacters"/> for Sybase.
        /// </summary>
        internal static readonly SqlCharacters Instance = new SybaseSqlCharacters();

        /// <summary>
        /// Prevents a default instance of the <see cref="SybaseSqlCharacters"/> class from being created.
        /// </summary>
        private SybaseSqlCharacters()
        {
        }
    }
}