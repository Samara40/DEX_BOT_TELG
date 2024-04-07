using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Domain.ValueObjects
{
    public abstract class BaseValueObject
    {
        public override bool Equals(object? obj)
        {
            if (obj is not BaseValueObject entity || entity == null) return false;
            var serialEnti = Serilize(entity);
            var serialThis = Serilize(this);
            ///TODO: Разобраться в String.Compare
            if (String.Compare(serialEnti, serialThis) != 0) return false;
            return true;
        }

        /// <summary>
        /// Переопределение метода для получения хэш-кода объекта.
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            return Serilize(this).GetHashCode();
        }

        /// <summary>
        /// Сериализация данных в json
        /// </summary>
        /// <param name="valueObjects"></param>
        /// <returns></returns>
        private string Serilize(BaseValueObject valueObjects)
        {
            var serializedObjects = JsonSerializer.Serialize(valueObjects);
            return serializedObjects;
        }

    }
}