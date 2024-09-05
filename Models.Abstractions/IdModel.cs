// <copyright file="IdModel.cs" company="Andrey Nikolaev">
// Copyright (c) Andrey Nikolaev. All rights reserved.
// </copyright>

namespace Models.Abstractions
{
    /// <summary>
    /// Модель с идентификатором.
    /// </summary>
    public abstract class IdModel : IIdModel
    {
        /// <inheritdoc/>
        public Guid Id { get; set; }
    }
}
