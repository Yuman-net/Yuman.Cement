// <copyright file="NamedEntity.cs" company="Andrey Nikolaev">
// Copyright (c) Andrey Nikolaev. All rights reserved.
// </copyright>

namespace Domain.Entities.Abstractions
{
    /// <summary>
    /// Сущность с названием.
    /// </summary>
    public abstract class NamedEntity : IdEntity
    {
        /// <summary>
        /// Название сущности.
        /// </summary>
        public string Name { get; set; }
    }
}
