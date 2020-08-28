using System;
using System.Collections.Generic;
using System.Text;
using ShopOnlineCore.Data.Enums;

namespace ShopOnlineCore.Data.Interfaces
{
    public interface ISwitchable
    {
        Status Status { set; get; }
    }
}
