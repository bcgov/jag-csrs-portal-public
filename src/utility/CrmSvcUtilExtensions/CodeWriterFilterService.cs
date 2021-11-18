using Microsoft.Crm.Services.Utility;
using Microsoft.Xrm.Sdk.Metadata;
using System;
using System.Linq;

namespace CrmSvcUtilExtensions
{
    public class CodeWriterFilterService : ICodeWriterFilterService
    {
        private MappingDefinition _mappings = MappingDefinition.Current;

        private ICodeWriterFilterService _service { get; set; }

        public CodeWriterFilterService(ICodeWriterFilterService defaultService)
        {
            //if (!System.Diagnostics.Debugger.IsAttached)
            //{
            //    System.Diagnostics.Debugger.Launch();
            //}

            _service = defaultService;
        }

        bool ICodeWriterFilterService.GenerateAttribute(AttributeMetadata attributeMetadata, IServiceProvider services)
        {
            // global skip attribute list?
            var skip = _mappings.Attributes.Any(_ => _.LogicalName == attributeMetadata.LogicalName && _.Skip);
            if (skip) return false;

            // did we explictly skip this on this entity?
            var entityMapping = _mappings.Entities.SingleOrDefault(_ => _.LogicalName == attributeMetadata.EntityLogicalName);
            if (entityMapping != null)
            {
                skip = entityMapping.Attributes.Any(_ => _.LogicalName == attributeMetadata.LogicalName && _.Skip);
            }
            if (skip) return false;

            skip = !_service.GenerateAttribute(attributeMetadata, services);
            return !skip;
        }

        bool ICodeWriterFilterService.GenerateEntity(EntityMetadata entityMetadata, IServiceProvider services)
        {
            var skip = _mappings.Entities.Any(_ => _.LogicalName == entityMetadata.LogicalName && _.Skip);
            if (!skip)
            {
                skip = !_mappings.Generate(entityMetadata);
            }

            return !skip;
        }

        bool ICodeWriterFilterService.GenerateOption(OptionMetadata optionMetadata, IServiceProvider services)
        {
            return this._service.GenerateOption(optionMetadata, services);
        }

        bool ICodeWriterFilterService.GenerateOptionSet(OptionSetMetadataBase optionSetMetadata, IServiceProvider services)
        {
            return this._service.GenerateOptionSet(optionSetMetadata, services);
        }

        bool ICodeWriterFilterService.GenerateRelationship(RelationshipMetadataBase relationshipMetadata, EntityMetadata otherEntityMetadata,
        IServiceProvider services)
        {
            return this._service.GenerateRelationship(relationshipMetadata, otherEntityMetadata, services);
        }

        bool ICodeWriterFilterService.GenerateServiceContext(IServiceProvider services)
        {
            return this._service.GenerateServiceContext(services);
        }
    }
}
