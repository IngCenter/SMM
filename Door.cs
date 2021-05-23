using System;
using System.Collections.Generic;
using System.Drawing;

namespace ADoors
{
    public class Door
    {
        /// <summary>
        /// Название модели
        /// </summary>
        public string Model { get; set; }

        /// <summary>
        /// Цена
        /// </summary>
        public int BasePrice { get; set; }

        /// <summary>
        /// Доступные Цвета
        /// </summary>
        public List<string> ColorsList { get; set; }

        /// <summary>
        /// Цвет
        /// </summary>
        public string Color { get; set; }

        /// <summary>
        /// Тип полотна (остеклённый, глухой...)
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// Ширина полотна, в миллиметрах
        /// </summary>
        public int Width { get; set; }

        /// <summary>
        /// Есть ли дверная ручка?
        /// </summary>
        public bool HasDoorhandle { get; set; }

        /// <summary>
        /// Есть ли наличник?
        /// </summary>
        public bool HasPlatband { get; set; }

        /// <summary>
        /// Фото
        /// </summary>
        public Image Picture { get; set; }

        public Door() 
        { }

        public Door(
            string _Model,
            int _BasePrice, 
            List<string> _ColorsList,
            string _Color,
            string _type, int _width,
            bool _doorhandle, bool _platband
        )
        {
            Model = _Model;
            BasePrice = _BasePrice;
            Color = _Color;
            ColorsList = _ColorsList;
            Type = (_type != null) ? _type.Trim() : "";
            Width = _width;
            HasDoorhandle = _doorhandle;
            HasPlatband = _platband;
        }

        /// <summary>
        /// Рассчитать стоимость дверки
        /// </summary>
        /// <param name="count">Кол-во дверей</param>
        /// <returns>Стоимость двери(-ей) с учётом количества</returns>
        public int ComputeCost(int count = 1)
        {
            //Учитываем ширину
            int Price = BasePrice * Width / 500;

            if (HasDoorhandle)
                Price += 1200;
            if (HasPlatband)
                Price += 1000;
            
            return Price * count;
        }
    }
}
