using System;

namespace WepApiJil.Models
{
    public sealed class ValueViewModel
    {
        public Guid Id { get; set; }

        public string Name
        {
            get; set;
        }

        public DateTime InsertedDate
        {
            get; set;
        }

        public string InsertedBy
        {
            get; set;
        }

        public SubValueViewModel[] SubValues { get; set; }
    }

    public sealed  class SubValueViewModel
    {
        public Guid Id { get; set; }

        public string Name
        {
            get; set;
        }

        public DateTime InsertedDate
        {
            get; set;
        }

        public string InsertedBy
        {
            get; set;
        }
    }
}