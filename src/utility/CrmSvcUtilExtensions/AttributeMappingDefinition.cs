using System.Collections.Generic;

namespace CrmSvcUtilExtensions
{
    public class AttributeMappingDefinition : LogicalNameMappingDefinition
    {
    }

    public class AttributeMappingDefinitionCollection : List<AttributeMappingDefinition>
    {
        public void Skip(string logicalName)
        {
            Add(new AttributeMappingDefinition { LogicalName = logicalName, Skip = true });
        }

        public void Skip(params string[] logicalNames)
        {
            foreach (var logicalName in logicalNames)
            {
                Add(new AttributeMappingDefinition { LogicalName = logicalName, Skip = true });
            }
        }
    }
}
