﻿//
//  TranslitTableBase.cs
//
//  Author:
//       Roman M. Yagodin <roman.yagodin@gmail.com>
//
//  Copyright (c) 2014, 2015 Roman M. Yagodin
//
//  This program is free software: you can redistribute it and/or modify
//  it under the terms of the GNU Lesser General Public License as published by
//  the Free Software Foundation, either version 3 of the License, or
//  (at your option) any later version.
//
//  This program is distributed in the hope that it will be useful,
//  but WITHOUT ANY WARRANTY; without even the implied warranty of
//  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//  GNU Lesser General Public License for more details.
//
//  You should have received a copy of the GNU Lesser General Public License
//  along with this program.  If not, see <http://www.gnu.org/licenses/>.

using System;
using System.Text;

namespace R7.Dnn.Extensions.Text.Transliteration
{
    public abstract class TranslitTableBase
    {
        protected string [,] translitTable; 

        public string [,] TranslitTable 
        {
            get { return translitTable; }
        }

        protected TranslitTableBase (string [,] translitTable)
        {
            this.translitTable = translitTable;
        }
    }
}

