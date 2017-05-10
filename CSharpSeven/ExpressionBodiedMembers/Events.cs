using System;

namespace CSharpSeven.ExpressionBodiedMembers
{
    class Events
    {
        private EventHandler _demo;
        public event EventHandler OldDemo
        {
            add
            {
                _demo += value;
            }
            remove
            {
                _demo -= value;
            }
        }
        public event EventHandler NewDemo
        {
            add => _demo += value;
            remove => _demo -= value;
        }
    }
}
