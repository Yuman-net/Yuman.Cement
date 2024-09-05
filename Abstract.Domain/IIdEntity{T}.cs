// <copyright file="IIdEntity{T}.cs" company="Andrey Nikolaev">
// Copyright (c) Andrey Nikolaev. All rights reserved.
// </copyright>

namespace Domain.Entities.Abstractions
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// Сущность с идентификатором.
    /// </summary>
    /// <typeparam name="T"> Тип идентификатора. </typeparam>
    public interface IIdEntity<T>
        where T : struct
    {
        /// <summary>
        /// Идентификатор сущности.
        /// </summary>
        public T Id { get; set; }
    }
}
