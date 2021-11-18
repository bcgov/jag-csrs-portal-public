using Microsoft.Xrm.Sdk.Metadata;
using System.Collections.Generic;
using System.Linq;

namespace CrmSvcUtilExtensions
{
    public class MappingDefinition
    {
        static MappingDefinition()
        {
            Current = LoadMappingDefinitions();
        }

        public MappingDefinition()
        {
            Entities = new List<EntityMappingDefinition>();
            Attributes = new AttributeMappingDefinitionCollection();
        }

        public string Prefix { get; set; }

        public List<EntityMappingDefinition> Entities { get; set; }
        public AttributeMappingDefinitionCollection Attributes { get; set; }

        public static MappingDefinition Current { get; private set; }

        public string RemovePrefix(string name)
        {
            if (!string.IsNullOrEmpty(Prefix))
            {
                if (name.StartsWith(Prefix))
                {
                    return name.Substring(Prefix.Length);
                }
            }

            return name;
        }

        public bool Generate(EntityMetadata entityMetadata)
        {
            EntityMappingDefinition entityMapping = GetEntityMapping(entityMetadata);

            if (entityMapping != null)
            {
                return !entityMapping.Skip;
            }

            return false; // do not generate
        }

        public EntityMappingDefinition GetEntityMapping(EntityMetadata entityMetadata)
        {
            return Entities.SingleOrDefault(_ => _.LogicalName == entityMetadata.LogicalName);
        }

        public AttributeMappingDefinition GetAttributeMapping(EntityMetadata entityMetadata, AttributeMetadata attributeMetadata)
        {
            var entityMapping = GetEntityMapping(entityMetadata);
            if (entityMapping != null)
            {
                return entityMapping.Attributes.SingleOrDefault(_ => _.LogicalName == attributeMetadata.LogicalName);
            }

            // didnt find a specific entity attribute mapping, is it a global mapping
            return Attributes.SingleOrDefault(_ => _.LogicalName == attributeMetadata.LogicalName);
        }

        private static MappingDefinition LoadMappingDefinitions()
        {
            // TODO: load from json
            MappingDefinition mappings = new MappingDefinition();
            mappings.Prefix = "ssg_";

            mappings.Attributes.Add(new AttributeMappingDefinition { LogicalName = "statecode", Name = "StateCode" });
            mappings.Attributes.Add(new AttributeMappingDefinition { LogicalName = "statuscode", Name = "StatusCode" });

            // skip any of these fields if we dont need them
            mappings.Attributes.Skip("createdby", "createdbyname", "createdonbehalfby", "createdonbehalfbyname","createdbyyominame","createdonbehalfbyyominame", "overriddencreatedon");
            mappings.Attributes.Skip("modifiedby","modifiedbyname", "modifiedonbehalfby", "modifiedbyyominame","modifiedonbehalfbyyominame");
            mappings.Attributes.Skip("ownerid", "owneridname", "owneridtype", "owneridyominame", "owningbusinessunit", "owningteam", "owninguser");
            mappings.Attributes.Skip("importsequencenumber", "versionnumber", "utcconversiontimezonecode", "timezoneruleversionnumber");

            // add the entity mappings
            mappings.Entities.Add(new EntityMappingDefinition
            {
                LogicalName = "ssg_csrsparty",
                Name = "Party",
                Attributes = new AttributeMappingDefinitionCollection
                {
                    new AttributeMappingDefinition() { LogicalName = "ssg_street1", Name =  "AddressStreet1" },
                    new AttributeMappingDefinition() { LogicalName = "ssg_street2", Name =  "AddressStreet2" },
                    new AttributeMappingDefinition() { LogicalName = "ssg_csrspartyid", Name =  "PartyId" },
                    new AttributeMappingDefinition() { LogicalName = "ssg_fullname", Name =  "FullName" },
                    new AttributeMappingDefinition() { LogicalName = "ssg_bceid_userid", Name =  "BCeID_UserId" },
                    new AttributeMappingDefinition() { LogicalName = "ssg_bceid_guid", Name =  "BCeIDGuid" },
                    new AttributeMappingDefinition() { LogicalName = "ssg_bceid_displayname", Name =  "BCeIDDisplayName" },
                    new AttributeMappingDefinition() { LogicalName = "ssg_areapostalcode", Name =  "PostalCode" },
                }
            });

            mappings.Entities.Add(new EntityMappingDefinition
            {
                LogicalName = "ssg_csrsfile",
                Name = "File",
                Attributes = new AttributeMappingDefinitionCollection
                {
                    new AttributeMappingDefinition() { LogicalName = "ssg_csrsfileid", Name =  "CsrsFileId" },
                    new AttributeMappingDefinition() { LogicalName = "ssg_filenumber", Name =  "FileNumber" },
                    new AttributeMappingDefinition() { LogicalName = "ssg_autonumber", Name =  "AutoNumber" },
                }
            });

            mappings.Entities.Add(new EntityMappingDefinition
            {
                LogicalName = "ssg_feedbackform",
                Name = "FeedbackForm"
            });

            mappings.Entities.Add(new EntityMappingDefinition
            {
                LogicalName = "ssg_message",
                Name = "Message"
            });

            return mappings;
        }

    }
}
