using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    /// <summary>
    /// Базовый класс для всех сущностей
    /// </summary>
    public abstract class BaseEntity
    {
        /// <summary>
        /// TODO: Описать все сущности
        /// </summary>
        public Guid Id { get; set; }

        public override bool Equals(object? obj)
        {
            // TODO: Упростить код

            if (obj == null || obj is not BaseEntity entity)
            {
               return false;
            }

            return Id == entity.Id;
        }

        public override int GetHashCode()
        {
            // TODO: Поресёрчить, зачем переопределять при Equals
            throw new NotImplementedException();
        }
    }
}
