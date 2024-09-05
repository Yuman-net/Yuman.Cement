// <copyright file="IIdModel.cs" company="Andrey Nikolaev">
// Copyright (c) Andrey Nikolaev. All rights reserved.
// </copyright>

namespace Models.Abstractions
{
    /// <summary>
    /// Модель с иденификатором.
    /// </summary>
    public interface IIdModel : IIdModel<Guid>
    {
    }
}
