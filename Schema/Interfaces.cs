using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Schema.Interfaces
{
    interface SchemaType
    {
        public string Id { get; set; }
        public string Ref { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public Regex Pattern { get; set; }
    }
}