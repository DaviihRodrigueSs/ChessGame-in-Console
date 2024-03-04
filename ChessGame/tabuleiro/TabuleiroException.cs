using System;
using System.Reflection.Metadata;

namespace tabuleiro
{
    internal class TabuleiroException : Exception
    {
        public TabuleiroException(string msg) : base (msg) {
        }
    }
}
