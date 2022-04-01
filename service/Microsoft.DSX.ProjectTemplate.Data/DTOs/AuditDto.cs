using System;

namespace Microsoft.DSX.ProjectTemplate.Data.DTOs
{
    public abstract class AuditDto<TType> : BaseDto<TType>
    {
        // ahora si
        public DateTime CreatedDate { get; set; }

        public DateTime UpdatedDate { get; set; }
    }
}
