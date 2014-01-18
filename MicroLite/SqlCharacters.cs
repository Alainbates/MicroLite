﻿// -----------------------------------------------------------------------
// <copyright file="SqlCharacters.cs" company="MicroLite">
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
namespace MicroLite
{
    using System;
    using System.Globalization;
    using System.Linq;

    /// <summary>
    /// A class containing the SQL characters for an SQL Dialect.
    /// </summary>
    public class SqlCharacters
    {
        private static SqlCharacters current;
        private static SqlCharacters empty;

        /// <summary>
        /// Initialises a new instance of the <see cref="SqlCharacters"/> class.
        /// </summary>
        protected SqlCharacters()
        {
        }

        /// <summary>
        /// Gets or sets the current SqlCharacters or Empty if not otherwise specified.
        /// </summary>
        public static SqlCharacters Current
        {
            get
            {
                return current ?? Empty;
            }

            set
            {
                current = value;
            }
        }

        /// <summary>
        /// Gets an Empty set of SqlCharacters.
        /// </summary>
        public static SqlCharacters Empty
        {
            get
            {
                return empty ?? (empty = new SqlCharacters());
            }
        }

        /// <summary>
        /// Gets the left delimiter character.
        /// </summary>
        public virtual string LeftDelimiter
        {
            get
            {
                return string.Empty;
            }
        }

        /// <summary>
        /// Gets the wildcard for use in like statements.
        /// </summary>
        public virtual string LikeWildcard
        {
            get
            {
                return "%";
            }
        }

        /// <summary>
        /// Gets the right delimiter character.
        /// </summary>
        public virtual string RightDelimiter
        {
            get
            {
                return string.Empty;
            }
        }

        /// <summary>
        /// Gets the wildcard for use in select statements.
        /// </summary>
        public virtual string SelectWildcard
        {
            get
            {
                return "*";
            }
        }

        /// <summary>
        /// Gets the SQL parameter.
        /// </summary>
        public virtual string SqlParameter
        {
            get
            {
                return "?";
            }
        }

        /// <summary>
        /// Gets a value indicating whether SQL parameters are named.
        /// </summary>
        public virtual bool SupportsNamedParameters
        {
            get
            {
                return false;
            }
        }

        /// <summary>
        /// Escapes the specified SQL using the left and right delimiters.
        /// </summary>
        /// <param name="sql">The SQL to be escaped.</param>
        /// <returns>The escaped SQL.</returns>
        public string EscapeSql(string sql)
        {
            if (sql == null)
            {
                throw new ArgumentNullException("sql");
            }

            if (this.IsEscaped(sql))
            {
                return sql;
            }

            if (!sql.Contains('.'))
            {
                return this.LeftDelimiter + sql + this.RightDelimiter;
            }

            var sqlPieces = sql.Split(Characters.Period);

#if NET_3_5
            return string.Join(".", sqlPieces.Select(s => this.LeftDelimiter + s + this.RightDelimiter).ToArray());
#else
            return string.Join(".", sqlPieces.Select(s => this.LeftDelimiter + s + this.RightDelimiter));
#endif
        }

        /// <summary>
        /// Gets the name of the parameter for the specified position.
        /// </summary>
        /// <param name="position">The parameter position.</param>
        /// <returns>The nape of the parameter for the specified position.</returns>
        public string GetParameterName(int position)
        {
            if (this.SupportsNamedParameters)
            {
                return this.SqlParameter + "p" + position.ToString(CultureInfo.InvariantCulture);
            }

            return this.SqlParameter;
        }

        /// <summary>
        /// Determines whether the specified SQL is escaped.
        /// </summary>
        /// <param name="sql">The SQL to check.</param>
        /// <returns>
        ///   <c>true</c> if the specified SQL is escaped; otherwise, <c>false</c>.
        /// </returns>
        public bool IsEscaped(string sql)
        {
            if (string.IsNullOrEmpty(sql))
            {
                return false;
            }

            return sql.StartsWith(this.LeftDelimiter, StringComparison.Ordinal) && sql.EndsWith(this.RightDelimiter, StringComparison.Ordinal);
        }
    }
}