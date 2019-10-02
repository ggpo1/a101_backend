using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace a101_backend.Models.Enums
{
    public enum CompanyStatus
    {
        NEW, // новый
        DISCUSSION, // обсуждение
        MATCHING_KP, // согласоввание КП
        MATCHING_CONTRACT, // согласование договора
        NOT_PAID, // выставлен счет
        PAID, // счет оплачен
        DONE // услуга выполнена
    }
}
