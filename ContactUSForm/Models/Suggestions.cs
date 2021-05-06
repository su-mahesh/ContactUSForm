using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContactUSForm.Models
{
    public class Suggestion
    {
        public bool IsChecked { get; set; }
        public Suggestions suggestion;
    }
    public enum Suggestions
    {
       suggestion1, suggestion2, suggestion3
    }
}
