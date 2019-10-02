using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace a101_backend.Models.Enums
{
    public enum DocumentStatus
    {
        MATCHING, // на согласовании
        SIGNED, // подписан
        NOT_SIGNED, // не подписан
        NOT_PAID, // не оплачен
        PAID // оплачен
    }
}
