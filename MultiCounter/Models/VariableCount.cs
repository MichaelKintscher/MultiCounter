using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiCounter.Models
{
    /// <summary>
    /// Represents a variable being counted.
    /// </summary>
    public class VariableCount : INotifyPropertyChanged
    {
        /// <summary>
        /// The name of the variable being counted.
        /// </summary>
        public string Name { get; set; }

        private int count;
        /// <summary>
        /// The count of the variable.
        /// </summary>
        public int Count
        {
            get => this.count;
            set
            {
                this.count = value;
                this.RaisePropertyChanged("Count");
            }
        }

        /// <summary>
        /// Creates a new instance of the VariableCount, with the given name and count initialized to 0.
        /// </summary>
        /// <param name="name">The name of the variable being counted.</param>
        public VariableCount(string name)
        {
            this.Name = name;
            this.Count = 0;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        /// <summary>
        /// Raise the PropertChanged event for the given property name.
        /// </summary>
        /// <param name="name">Name of the property changed.</param>
        public void RaisePropertyChanged(string name)
        {
            if (this.PropertyChanged != null)
            {
                this.PropertyChanged(this, new PropertyChangedEventArgs(name));
            }
        }
    }
}
