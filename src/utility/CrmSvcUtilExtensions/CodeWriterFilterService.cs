
using Microsoft.Crm.Services.Utility;
using Microsoft.Xrm.Sdk.Metadata;
using System;

namespace CrmSvcUtilExtensions
{
    public class CodeWriterFilterService : ICodeWriterFilterService
    {
        private MappingDefinition _mappings = MappingDefinition.Current;

        private ICodeWriterFilterService _service { get; set; }

        public CodeWriterFilterService(ICodeWriterFilterService defaultService)
        {
            //if (!Debugger.IsAttached)
            //{
            //    Debugger.Launch();
            //}

            _service = defaultService;
        }

        bool ICodeWriterFilterService.GenerateAttribute(AttributeMetadata attributeMetadata, IServiceProvider services)
        {
            return this._service.GenerateAttribute(attributeMetadata, services);
        }

        bool ICodeWriterFilterService.GenerateEntity(EntityMetadata entityMetadata, IServiceProvider services)
        {
            return _mappings.Generate(entityMetadata);
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
