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
    
    public partial class Заказанные_изделия
    {
        public int Номер_заказанного_изделия { get; set; }
        public string Номер_заказа { get; set; }
        public string Артикул_изделия { get; set; }
        public int Количество { get; set; }
    
        public virtual Заказ Заказ { get; set; }
        public virtual Изделия Изделия { get; set; }
    }
}
