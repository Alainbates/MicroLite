﻿// -----------------------------------------------------------------------
// <copyright file="InsertSqlBuilder.cs" company="MicroLite">
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
namespace MicroLite.Builder
{
    using System;
    using MicroLite.Mapping;

    [System.Diagnostics.DebuggerDisplay("{InnerSql}")]
    internal sealed class InsertSqlBuilder : SqlBuilderBase, IInsertIntoTable, IInsertColumn, IInsertValue
    {
        internal InsertSqlBuilder(SqlCharacters sqlCharacters)
            : base(sqlCharacters)
        {
            this.InnerSql.Append("INSERT INTO ");
        }

        public IInsertValue Columns(params string[] columnNames)
        {
            this.InnerSql.Append(" (");

            if (columnNames != null)
            {
                for (int i = 0; i < columnNames.Length; i++)
                {
                    if (i > 0)
                    {
                        this.InnerSql.Append(',');
                    }

                    this.InnerSql.Append(this.SqlCharacters.EscapeSql(columnNames[i]));
                }
            }

            this.InnerSql.Append(')');

            return this;
        }

        public IInsertColumn Into(string tableName)
        {
            this.AppendTableName(tableName);

            return this;
        }

        public IInsertColumn Into(Type forType)
        {
            var objectInfo = ObjectInfo.For(forType);

            return this.Into(objectInfo);
        }

        public IToSqlQuery Values(params object[] columnValues)
        {
            this.InnerSql.Append(" VALUES (");

            if (columnValues != null)
            {
                for (int i = 0; i < columnValues.Length; i++)
                {
                    this.Arguments.Add(columnValues[i]);

                    this.InnerSql.Append(this.SqlCharacters.GetParameterName(i));

                    if (i < columnValues.Length - 1)
                    {
                        this.InnerSql.Append(',');
                    }
                }
            }

            this.InnerSql.Append(')');

            return this;
        }

        internal IInsertColumn Into(IObjectInfo objectInfo)
        {
            this.AppendTableName(objectInfo);

            return this;
        }
    }
}