using Microsoft.Crm.Services.Utility;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Metadata;
using System;
using System.Linq;

namespace CrmSvcUtilExtensions
{
    public class CodeGenerationService : ICodeGenerationService
    {
        private ICodeGenerationService _codeGenerationService;

        public CodeGenerationService(ICodeGenerationService codeGenerationService)
        {
            _codeGenerationService = codeGenerationService ?? throw new ArgumentNullException(nameof(codeGenerationService));
        }

        public CodeGenerationType GetTypeForAttribute(EntityMetadata entityMetadata, AttributeMetadata attributeMetadata, IServiceProvider services)
        {
            return _codeGenerationService.GetTypeForAttribute(entityMetadata, attributeMetadata, services);
        }

        public CodeGenerationType GetTypeForEntity(EntityMetadata entityMetadata, IServiceProvider services)
        {
            return _codeGenerationService.GetTypeForEntity(entityMetadata, services);
        }

        public CodeGenerationType GetTypeForMessagePair(SdkMessagePair messagePair, IServiceProvider services)
        {
            return _codeGenerationService.GetTypeForMessagePair(messagePair, services);
        }

        public CodeGenerationType GetTypeForOption(OptionSetMetadataBase optionSetMetadata, OptionMetadata optionMetadata, IServiceProvider services)
        {
            return _codeGenerationService.GetTypeForOption(optionSetMetadata, optionMetadata, services);
        }

        public CodeGenerationType GetTypeForOptionSet(EntityMetadata entityMetadata, OptionSetMetadataBase optionSetMetadata, IServiceProvider services)
        {
            return _codeGenerationService.GetTypeForOptionSet(entityMetadata, optionSetMetadata, services);
        }

        public CodeGenerationType GetTypeForRequestField(SdkMessageRequest request, SdkMessageRequestField requestField, IServiceProvider services)
        {
            return _codeGenerationService.GetTypeForRequestField(request, requestField, services);
        }

        public CodeGenerationType GetTypeForResponseField(SdkMessageResponse response, SdkMessageResponseField responseField, IServiceProvider services)
        {
            return _codeGenerationService.GetTypeForResponseField(response, responseField, services);
        }

        public void Write(IOrganizationMetadata organizationMetadata, string language, string outputFile, string targetNamespace, IServiceProvider services)
        {
            IndentingStringBuilder buffer = new IndentingStringBuilder();

            BuildFileHeader(buffer);

            buffer.AppendLine();
            buffer.AppendLine($"namespace {targetNamespace}");
            buffer.AppendLine("{");
            buffer.Indent();

            BuildCommonTypes(buffer);

            BuildOptionSets(organizationMetadata.OptionSets, services);
            BuildEntities(organizationMetadata.Entities, services, buffer);

            buffer.Unindent();
            buffer.AppendLine("}");

            //Debugger.Launch();

            System.IO.File.WriteAllText(outputFile, buffer.ToString());

            //_codeGenerationService.Write(organizationMetadata, language, outputFile, targetNamespace, services);
        }

        private void BuildFileHeader(IndentingStringBuilder buffer)
        {
            buffer.AppendLine("using System;");
            buffer.AppendLine("using System.Text.Json.Serialization;");
            buffer.AppendLine();
            buffer.AppendLine("#nullable enable");
        }

        private void BuildCommonTypes(IndentingStringBuilder buffer)
        {
            //Entity
            buffer.AppendLine("public abstract class Entity");
            buffer.AppendLine("{");
            buffer.Indent();
            buffer.AppendLine("[JsonPropertyName(\"id\")]");
            buffer.AppendLine("public Guid? Id { get; set; }");
            buffer.Unindent();
            buffer.AppendLine("}");

            // EntityReference
            buffer.AppendLine();
            buffer.AppendLine("public class EntityReference");
            buffer.AppendLine("{");
            buffer.Indent();


            buffer.AppendLine();
            buffer.AppendLine("public EntityReference()");
            buffer.AppendLine("{");
            buffer.AppendLine("}");

            buffer.AppendLine("public EntityReference(string logicalName, Guid id)");
            buffer.AppendLine("{");
            buffer.Indent();
            buffer.AppendLine("LogicalName = logicalName;");
            buffer.AppendLine("Id = id;");
            buffer.Unindent();
            buffer.AppendLine("}");


            buffer.AppendLine("[JsonPropertyName(\"id\")]");
            buffer.AppendLine("public Guid Id { get; set; }");
            buffer.AppendLine("[JsonPropertyName(\"logicalName\")]");
            buffer.AppendLine("public string LogicalName { get; set; }");
            buffer.AppendLine("[JsonPropertyName(\"name\")]");
            buffer.AppendLine("public string Name { get; set; }");
            buffer.AppendLine("[JsonPropertyName(\"rowVersion\")]");
            buffer.AppendLine("public string RowVersion { get; set; }");

            buffer.Unindent();
            buffer.AppendLine("}");

            // Money
            buffer.AppendLine();
            buffer.AppendLine("public class Money");
            buffer.AppendLine("{");
            buffer.Indent();

            buffer.AppendLine("[JsonPropertyName(\"value\")]");
            buffer.AppendLine("public decimal Value { get; set; }");

            buffer.Unindent();
            buffer.AppendLine("}");
        }

        private void BuildOptionSets(OptionSetMetadataBase[] optionSetMetadata, IServiceProvider services)
        {
        }

        private void BuildEntities(EntityMetadata[] entities, IServiceProvider services, IndentingStringBuilder buffer)
        {
            ICodeWriterFilterService codeWriterFilterService = (ICodeWriterFilterService)services.GetService(typeof(ICodeWriterFilterService));
            INamingService namingService = (INamingService)services.GetService(typeof(INamingService));

            foreach (EntityMetadata entityMetadata in entities.OrderBy(_ => _.LogicalName))
            {
                if (codeWriterFilterService.GenerateEntity(entityMetadata, services))
                {
                    BuildEntity(entityMetadata, codeWriterFilterService, namingService, services, buffer);
                }
            }
        }

        private void BuildEntity(
            EntityMetadata entityMetadata,
            ICodeWriterFilterService codeWriterFilterService,
            INamingService namingService,
            IServiceProvider services,
            IndentingStringBuilder buffer)
        {
            buffer.AppendLine();

            var entityDescription = entityMetadata.Description.LocalizedLabels.FirstOrDefault()?.Label;
            if (!string.IsNullOrWhiteSpace(entityDescription))
            {
                buffer.AppendLine($"/// <summary>");
                buffer.AppendLine($"/// {entityDescription}");
                buffer.AppendLine($"/// </summary>");
            }
            else
            {
                buffer.AppendLine($"/// <summary></summary>");
            }

            var entityName = namingService.GetNameForEntity(entityMetadata, services);

            buffer.AppendLine($"public partial class {entityName} : Entity");
            buffer.AppendLine("{");
            buffer.Indent();

            foreach (var attribute in entityMetadata.Attributes.Where(_ => _.AttributeType != null).OrderBy(_ => _.LogicalName))
            {
                if (codeWriterFilterService.GenerateAttribute(attribute, services))
                {
                    BuildAttribute(entityMetadata, attribute, codeWriterFilterService, namingService, services, buffer);
                }
            }

            buffer.Unindent();
            buffer.AppendLine("}");

        }

        private void BuildAttribute(
            EntityMetadata entityMetadata,
            AttributeMetadata attribute,
            ICodeWriterFilterService codeWriterFilterService,
            INamingService namingService,
            IServiceProvider services,
            IndentingStringBuilder buffer)

        {
            var hasSet = (attribute.IsValidForCreate.GetValueOrDefault() ? true : attribute.IsValidForUpdate.GetValueOrDefault());
            var hasGet = (attribute.IsValidForRead.GetValueOrDefault() ? true : hasSet);

            if (!hasGet && !hasSet)
            {
                return;
            }

            // if (entity.PrimaryIdAttribute == attributeMetadatum.LogicalName && attributeMetadatum.IsPrimaryId.GetValueOrDefault())

            string attributeType = GetAttributeType(attribute.AttributeType.Value);
            if (string.IsNullOrEmpty(attributeType))
            {
                return;
            }

            var attributeName = namingService.GetNameForAttribute(entityMetadata, attribute, services);
            var attributesDescription = attribute.Description.LocalizedLabels.FirstOrDefault()?.Label;

            if (!string.IsNullOrWhiteSpace(attributesDescription))
            {
                buffer.AppendLine($"/// <summary>");
                buffer.AppendLine($"/// {attributesDescription}");
                buffer.AppendLine($"/// </summary>");
            }
            else
            {
                buffer.AppendLine($"/// <summary></summary>");
            }

            if (attribute.DeprecatedVersion != null)
            {
                buffer.AppendLine($"[Obsolete]");
            }

            buffer.AppendLine($"[JsonPropertyName(\"{attribute.LogicalName}\")]");
            buffer.AppendLine($"public {attributeType}? {attributeName} {{ get; set; }}");
        }

        private string GetAttributeType(AttributeTypeCode attributeTypeCode)
        {
            switch (attributeTypeCode)
            {
                case AttributeTypeCode.Boolean: return "bool"; // typeof(bool)
                case AttributeTypeCode.ManagedProperty: return string.Empty; // typeof(BooleanManagedProperty) },
                case AttributeTypeCode.CalendarRules: return string.Empty; // typeof(object) },
                case AttributeTypeCode.Customer: return "EntityReference"; // , typeof(EntityReference) },
                case AttributeTypeCode.DateTime: return "DateTime"; // typeof(DateTime) },
                case AttributeTypeCode.Decimal: return "decimal"; // typeof(decimal) },
                case AttributeTypeCode.Double: return "double"; // typeof(double) },
                case AttributeTypeCode.Integer: return "int"; // typeof(int) },
                case AttributeTypeCode.EntityName: return "string"; // typeof(string) },
                case AttributeTypeCode.BigInt: return "long"; // typeof(long) },
                case AttributeTypeCode.Lookup: return "EntityReference"; // typeof(EntityReference) },
                case AttributeTypeCode.Memo: return "string"; // typeof(string) },
                case AttributeTypeCode.Money: return "Money"; // typeof(Money) },
                case AttributeTypeCode.Owner: return "EntityReference"; // typeof(EntityReference) },
                case AttributeTypeCode.String: return "string"; // typeof(string) },
                case AttributeTypeCode.Uniqueidentifier: return "System.Guid"; // typeof(Guid) }
                default:
                    return string.Empty;
            }
        }
    }
}
