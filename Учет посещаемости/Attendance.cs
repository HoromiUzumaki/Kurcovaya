//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Учет_посещаемости
{
    using System;
    using System.Collections.Generic;
    
    public partial class Attendance
    {
        public int Id_attendence { get; set; }
        public Nullable<int> Id_student { get; set; }
        public Nullable<int> Subject { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
        public string Reason { get; set; }
        public string Description { get; set; }
    
        public virtual Student Student { get; set; }
        public virtual Subject Subject1 { get; set; }
    }
}
