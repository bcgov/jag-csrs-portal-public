using System.Collections.Generic;

namespace CrmSvcUtilExtensions
{
    public class EntityMappingDefinition : LogicalNameMappingDefinition
    {
        public EntityMappingDefinition()
        {
            Attributes = new List<AttributeMappingDefinition>();
        }

        public List<AttributeMappingDefinition> Attributes { get; set; }
    }
}
