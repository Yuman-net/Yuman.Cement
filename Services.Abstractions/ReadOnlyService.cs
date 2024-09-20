// <copyright file="ReadOnlyService.cs" company="Andrey Nikolaev">
// Copyright (c) Andrey Nikolaev. All rights reserved.
// </copyright>

namespace Services.Abstractions
{
    using Domain.Entities.Abstractions;
    using Microsoft.EntityFrameworkCore;
    using Services.Abstractions.Interfaces;

    /// <summary>
    /// Сервис по чтению данных из БД.
    /// </summary>
    /// <typeparam name="TEntity"> Тип сущности. </typeparam>
    /// <typeparam name="TDataContext"> Контекст базы данных. </typeparam>
    public abstract class ReadOnlyService<TEntity, TDataContext> : IReadOnlyService<TEntity>
        where TEntity : class, IIdEntity
        where TDataContext : DbContext
    {
        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="ReadOnlyService{TEntity, TDataContext}"/>.
        /// </summary>
        /// <param name="dataContext"> Контекст бызы данных. </param>
        public ReadOnlyService(TDataContext dataContext)
        {
            this.DataContext = dataContext ?? throw new ArgumentNullException(nameof(dataContext));
        }

        /// <summary>
        /// Контекст базы данных.
        /// </summary>
        protected TDataContext DataContext { get; }

        /// <summary>
        /// Получает все сущности.
        /// </summary>
        /// <param name="track"> Флаг отслеживания сущности. </param>
        /// <returns> Перечисление объектов. </returns>
        public abstract IQueryable<TEntity> GetAll(bool track = false);

        /// <inheritdoc/>
        public TEntity? GetId(Guid id)
        {
            return this.GetAll().SingleOrDefault(entity => entity.Id == id);
        }

        /// <inheritdoc/>
        public async Task<TEntity?> GetIdAsync(Guid id)
        {
            return await this.GetAll().SingleOrDefaultAsync(entity => entity.Id == id);
        }
    }
}