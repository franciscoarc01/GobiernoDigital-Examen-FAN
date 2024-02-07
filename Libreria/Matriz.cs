using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria
{
    public sealed class Matriz
    {
        public static Dictionary<byte, String[]> MatrizNumero = new Dictionary<byte, String[]>() {
            {
                0, new string[]
                {
                    " _ ",
                    "| |",
                    "|_|"
                }
            },
            {
                1, new string[]
                {
                 "   ",
                 "  |",
                 "  |"
                }
            },
            {
                2, new string[]
                {
                    " _ ",
                    " _|",
                    "|_ "
                }
            },
            {
                3, new string[]
                {
                    " _ ",
                    " _|",
                    " _|"
                }
            },
            {
                4, new string[]
                {
                    "   ",
                    "|_|",
                    "  |"
                }
            },
            {
                5, new string[]
                {
                     " _ ",
                     "|_ ",
                     " _|"
                }
            },
            {
                6, new string[]
                {
                     " _ ",
                     "|_ ",
                     "|_|"
                }
            },
            {
                7, new string[]
                {
                    " _ ",
                    "  |",
                    "  |"
                }
            },
            {
                8, new string[]
                {
                    " _ ",
                    "|_|",
                    "|_|"
                }
            },
            {
                9, new string[]
                {
                    " _ ",
                    "|_|",
                    " _|"
                }
            }
        };
    }
}
