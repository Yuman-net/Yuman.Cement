// <copyright file="IdEntity.cs" company="Andrey Nikolaev">
// Copyright (c) Andrey Nikolaev. All rights reserved.
// </copyright>

namespace Domain.Entities.Abstractions
{
    /// <summary>
    /// Сущность с идентификатором.
    /// </summary>
    public abstract class IdEntity : IIdEntity
    {
        /// <inheritdoc/>
        public Guid Id { get; set; }
    }
}
