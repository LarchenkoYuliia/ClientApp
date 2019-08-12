using System;
using System.Collections.Generic;
using System.Text;

namespace App1.Models
{
    public class DeviceType
    {
        /// <summary>
        /// Уникальный идентификатор
        /// </summary>
        public int DeviceTypeId { get; set; }

        /// <summary>
        /// Наименовение типа устройства
        /// </summary>
        public string DeviceTypeName { get; set; }
    }
}
