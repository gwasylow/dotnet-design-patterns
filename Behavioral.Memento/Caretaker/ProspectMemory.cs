using System;
using System.Collections.Generic;
using System.Text;

namespace Behavioral.Memento.Caretaker
{
    /// <summary>
    /// The 'Caretaker' class
    /// </summary>
    public class ProspectMemory
    {
        private Memento.Memento _memento;

        //Property
        public Memento.Memento Memento
        {
            get => _memento;
            set => this._memento = value;
        }
    }
}
