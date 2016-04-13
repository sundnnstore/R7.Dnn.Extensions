﻿//
//  RuFileTranslitTable.cs
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

namespace R7.DotNetNuke.Extensions
{
    public class RuFileTranslitTable : TranslitTableBase
    {
        private static readonly string [,] ruFileTranslitTable ={
            // apply some filename rules
            {@"[^0-9^a-z^а-я^A-Z^А-Я^\-^ё^Ё]", "_"},
            {@"_+", "_"},
            {@"\-+", "-"},
            {@"\A[_\-]+", ""},
            {@"[_\-]+\z", ""},
            {@"([_\-])[_\-]+", "$1"},
            // custom rules
            {@"\bх", "kh" },
            {@"\bХ", "Kh" },
            {@"\Bый", "y"},
            {"ье", "iye" },
            {"ья", "iya" },
            {"ью", "iyu" },
            // main rules
            {"а", "a"}, 
            {"б", "b"}, 
            {"в", "v"},
            {"г", "g"},
            {"д", "d"},
            {"е", "e"},
            {"ё", "yo"},
            {"ж", "zh"},
            {"з", "z"},
            {"и", "i"},
            {"й", "y"},
            {"к", "k"},
            {"л", "l"},
            {"м", "m"},
            {"н", "n"},
            {"о", "o"},
            {"п", "p"},
            {"р", "r"},
            {"с", "s"},
            {"т", "t"},
            {"у", "u"},
            {"ф", "f"},
            {"х", "h"},
            {"ц", "c"},
            {"ч", "ch"},
            {"ш", "sh"},
            {"щ", "sch"},
            {"ъ", ""},
            {"ы", "y"},
            {"ь", ""},
            {"э", "e"},
            {"ю", "yu"},
            {"я", "ya"},
            {"А", "A"},
            {"Б", "B"},
            {"В", "V"},
            {"Г", "G"},
            {"Д", "D"},
            {"Е", "E"},
            {"Ё", "YO"},
            {"Ж", "Zh"},
            {"З", "Z"},
            {"И", "I"},
            {"Й", "Y"},
            {"К", "K"},
            {"Л", "L"},
            {"М", "M"},
            {"Н", "N"},
            {"О", "O"},
            {"П", "P"},
            {"Р", "R"},
            {"С", "S"},
            {"Т", "T"},
            {"У", "U"},
            {"Ф", "F"},
            {"Х", "H"},
            {"Ц", "C"},
            {"Ч", "Ch"},
            {"Ш", "Sh"},
            {"Щ", "Sch"},
            {"Ъ", ""},
            {"Ы", "Y"},
            {"Ь", ""},
            {"Э", "E"},
            {"Ю", "YU"},
            {"Я", "YA"}
        }; 

        private RuFileTranslitTable () : base (ruFileTranslitTable)
        {
        }
    }
}
