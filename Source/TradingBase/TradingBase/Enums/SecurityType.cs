/****************************** Project Header ******************************\
Project:	      QuantTrading
Author:			  Letian_zj @ Codeplex
URL:			  https://quanttrading.codeplex.com/
Copyright 2014 Letian_zj

This file is part of QuantTrading Project.

QuantTrading is free software: you can redistribute it and/or modify it under the terms of the GNU General Public License as published by the Free Software Foundation, 
either version 3 of the License, or (at your option) any later version.

QuantTrading is distributed in the hope that it will be useful, but WITHOUT ANY WARRANTY; without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. 
See the GNU General Public License for more details.

You should have received a copy of the GNU General Public License along with QuantTrading. 
If not, see http://www.gnu.org/licenses/.

\***************************************************************************/
using System;
using System.ComponentModel;
using System.Threading.Tasks;

namespace TradingBase
{
    public enum SecurityType
    {
        [Description("UNKNOWN")]
        UNKNOWN = -1,
        [Description("STK")]
        STK,
        [Description("OPT")]
        OPT,
        [Description("PUT")]
        FUT,
        [Description("CFD")]
        CFD,
        [Description("FOR")]
        FOR,
        [Description("FOP")]
        FOP,        // futures on options
        [Description("WAR")]
        WAR,        // Warrant
        [Description("FOX")]
        FOX,
        [Description("IND")]
        IND,        // index
        [Description("BND")]
        BND,
        [Description("CASH")]
        CASH,       // forex pair
        [Description("BAG")]
        BAG,        // combo
    }
}
