using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Api.Domain.Entities
{
    public abstract class BaseEntity
    {
        [Key]
        public Guid Id { get; set; }
        public DateTime? DataInclusao { get; set; }
        public DateTime? DataAlteracao { get; set; }
        public string Status { get; set; }

        private DateTime? _DataInclusao
        {
            get { return DataInclusao; }
            set { DataInclusao = (value == null ? DateTime.UtcNow : value); }
        }


    }
}
