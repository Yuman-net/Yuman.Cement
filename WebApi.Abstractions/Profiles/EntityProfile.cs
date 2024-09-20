// <copyright file="EntityProfile.cs" company="Andrey Nikolaev">
// Copyright (c) Andrey Nikolaev. All rights reserved.
// </copyright>

namespace WebApi.Abstractions.Profiles
{
    using AutoMapper;
    using Domain.Entities.Abstractions;
    using Models.Abstractions;

    /// <summary>
    /// Профиль для настройки сущностей.
    /// </summary>
    /// <typeparam name="TEntity"> Тип сущности. </typeparam>
    /// <typeparam name="TModel"> Тип модели. </typeparam>
    public abstract class EntityProfile<TEntity, TModel> : Profile
        where TEntity : NamedEntity
        where TModel : NamedModel
    {
        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="EntityProfile{TEntity, TModel}"/>.
        /// </summary>
        protected EntityProfile()
        {
            this.Output = this.CreateMap<TEntity, TModel>()
                .ForMember(d => d.Id, ops => ops.MapFrom(s => s.Id))
                .ForMember(d => d.Name, ops => ops.MapFrom(s => s.Name));

            this.Input = this.CreateMap<TModel, TEntity>()
                .ForMember(d => d.Id, ops => ops.MapFrom(s => s.Id))
                .ForMember(d => d.Name, ops => ops.MapFrom(s => s.Name));
        }

        /// <summary>
        /// Маппинг из сущности в модель.
        /// </summary>
        protected IMappingExpression<TEntity, TModel> Output { get; set; }

        /// <summary>
        /// Маппинг из модели в сущность.
        /// </summary>
        protected IMappingExpression<TModel, TEntity> Input { get; set; }
    }
}
