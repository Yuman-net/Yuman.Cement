using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract.Domain
{
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
