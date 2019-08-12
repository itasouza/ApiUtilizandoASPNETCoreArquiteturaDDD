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
        private DateTime? DataInclusao { get; set; }
        private DateTime? DataAlteracao { get; set; }
        public string Status { get; set; }

        private DateTime? _DataInclusao
        {
            get { return DataInclusao; }
            set { DataInclusao = (value == null ? DateTime.UtcNow : value); }
        }

        private string _Status
        {
            get { return Status; }
            set
            {
                if (Status == null)
                {
                    Status = "A";
                }
                else
                {
                    Status = "I";
                }

            }
        }


    }
}
