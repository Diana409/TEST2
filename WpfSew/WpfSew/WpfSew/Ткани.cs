//------------------------------------------------------------------------------
// <auto-generated>
//    Этот код был создан из шаблона.
//
//    Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//    Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WpfSew
{
    using System;
    using System.Collections.Generic;
    
    public partial class Ткани
    {
        public Ткани()
        {
            this.Склад_ткани = new HashSet<Склад_ткани>();
            this.Ткани_изделия = new HashSet<Ткани_изделия>();
        }
    
        public string Артикул { get; set; }
        public string Наименование { get; set; }
        public string Цвет { get; set; }
        public string Рисунок { get; set; }
        public byte[] Изображение { get; set; }
        public string Состав { get; set; }
        public Nullable<double> Ширина { get; set; }
        public Nullable<double> Длина { get; set; }
        public Nullable<decimal> Цена { get; set; }
    
        public virtual ICollection<Склад_ткани> Склад_ткани { get; set; }
        public virtual ICollection<Ткани_изделия> Ткани_изделия { get; set; }
    }
}
