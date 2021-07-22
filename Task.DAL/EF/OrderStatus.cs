using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace Task.DAL.EF
{
    public enum OrderStatus
    {
        InProgress = 0,

        [Display(Name = "Ожидает подтверждения")]
        Completed = 1,

        [Display(Name = "Подтверджено")]
        Confirmed = 2,

        [Display(Name = "Отменено")]
        Сancellation = 3
    }
}
