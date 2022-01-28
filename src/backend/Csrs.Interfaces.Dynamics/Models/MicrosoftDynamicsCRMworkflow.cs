// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Csrs.Interfaces.Dynamics.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Microsoft.Dynamics.CRM.workflow
    /// </summary>
    public partial class MicrosoftDynamicsCRMworkflow
    {
        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMworkflow
        /// class.
        /// </summary>
        public MicrosoftDynamicsCRMworkflow()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMworkflow
        /// class.
        /// </summary>
        public MicrosoftDynamicsCRMworkflow(int? deletestage = default(int?), string xaml = default(string), string iscustomizable = default(string), string name = default(string), string _createdonbehalfbyValue = default(string), string versionnumber = default(string), byte[] entityimage = default(byte[]), int? scope = default(int?), string inputparameters = default(string), string _modifiedbyValue = default(string), int? componentstate = default(int?), int? runas = default(int?), bool? ondemand = default(bool?), string workflowid = default(string), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), long? entityimageTimestamp = default(long?), bool? syncworkflowlogonfailure = default(bool?), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), bool? iscrmuiworkflow = default(bool?), string uniquename = default(string), string processroleassignment = default(string), int? businessprocesstype = default(int?), string formid = default(string), int? updatestage = default(int?), int? rank = default(int?), int? type = default(int?), string _owningbusinessunitValue = default(string), bool? triggeroncreate = default(bool?), string uidata = default(string), string _plugintypeidValue = default(string), int? category = default(int?), int? statecode = default(int?), string rendererobjecttypecode = default(string), string _owningteamValue = default(string), bool? asyncautodelete = default(bool?), string triggeronupdateattributelist = default(string), string description = default(string), int? statuscode = default(int?), bool? ismanaged = default(bool?), string workflowidunique = default(string), System.DateTimeOffset? overwritetime = default(System.DateTimeOffset?), string _owninguserValue = default(string), string _parentworkflowidValue = default(string), string _createdbyValue = default(string), bool? subprocess = default(bool?), string entityimageUrl = default(string), string solutionid = default(string), int? languagecode = default(int?), string introducedversion = default(string), string _activeworkflowidValue = default(string), int? processorder = default(int?), bool? istransacted = default(bool?), string _modifiedonbehalfbyValue = default(string), string clientdata = default(string), int? mode = default(int?), bool? triggerondelete = default(bool?), string entityimageid = default(string), int? createstage = default(int?), string primaryentity = default(string), string _owneridValue = default(string), string _sdkmessageidValue = default(string), IList<MicrosoftDynamicsCRMphonetocaseprocess> workflowPhonetocaseprocess = default(IList<MicrosoftDynamicsCRMphonetocaseprocess>), IList<MicrosoftDynamicsCRMleadtoopportunitysalesprocess> workflowLeadtoopportunitysalesprocess = default(IList<MicrosoftDynamicsCRMleadtoopportunitysalesprocess>), IList<MicrosoftDynamicsCRMopportunitysalesprocess> workflowOpportunitysalesprocess = default(IList<MicrosoftDynamicsCRMopportunitysalesprocess>), IList<MicrosoftDynamicsCRMnewBpfC990ad2a1520457b87564f32c6b3a91e> lkNewBpfC990ad2a1520457b87564f32c6b3a91eProcessid = default(IList<MicrosoftDynamicsCRMnewBpfC990ad2a1520457b87564f32c6b3a91e>), IList<MicrosoftDynamicsCRMnewBpfAeeb3ada439a4f619bf1a429c6f7154e> lkNewBpfAeeb3ada439a4f619bf1a429c6f7154eProcessid = default(IList<MicrosoftDynamicsCRMnewBpfAeeb3ada439a4f619bf1a429c6f7154e>), IList<MicrosoftDynamicsCRMnewBpf042a40fe36e44388b3a9a191b03dab85> lkNewBpf042a40fe36e44388b3a9a191b03dab85Processid = default(IList<MicrosoftDynamicsCRMnewBpf042a40fe36e44388b3a9a191b03dab85>), IList<MicrosoftDynamicsCRMnewBpfD191d396d30b4080a49c77b0d411997e> lkNewBpfD191d396d30b4080a49c77b0d411997eProcessid = default(IList<MicrosoftDynamicsCRMnewBpfD191d396d30b4080a49c77b0d411997e>), IList<MicrosoftDynamicsCRMsla> slabaseWorkflowid = default(IList<MicrosoftDynamicsCRMsla>), MicrosoftDynamicsCRMbusinessunit owningbusinessunit = default(MicrosoftDynamicsCRMbusinessunit), MicrosoftDynamicsCRMsystemuser createdonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMprincipal ownerid = default(MicrosoftDynamicsCRMprincipal), IList<MicrosoftDynamicsCRMasyncoperation> lkAsyncoperationWorkflowactivationid = default(IList<MicrosoftDynamicsCRMasyncoperation>), MicrosoftDynamicsCRMworkflow parentworkflowid = default(MicrosoftDynamicsCRMworkflow), IList<MicrosoftDynamicsCRMworkflow> workflowParentWorkflow = default(IList<MicrosoftDynamicsCRMworkflow>), IList<MicrosoftDynamicsCRMexpiredprocess> workflowExpiredprocess = default(IList<MicrosoftDynamicsCRMexpiredprocess>), IList<MicrosoftDynamicsCRMslaitem> slaitembaseWorkflowid = default(IList<MicrosoftDynamicsCRMslaitem>), IList<MicrosoftDynamicsCRMtranslationprocess> workflowTranslationprocess = default(IList<MicrosoftDynamicsCRMtranslationprocess>), IList<MicrosoftDynamicsCRMprocesstrigger> processProcesstrigger = default(IList<MicrosoftDynamicsCRMprocesstrigger>), MicrosoftDynamicsCRMteam owningteam = default(MicrosoftDynamicsCRMteam), IList<MicrosoftDynamicsCRMannotation> workflowAnnotation = default(IList<MicrosoftDynamicsCRMannotation>), IList<MicrosoftDynamicsCRMprocesssession> lkProcesssessionProcessid = default(IList<MicrosoftDynamicsCRMprocesssession>), IList<MicrosoftDynamicsCRMprocessstage> processProcessstage = default(IList<MicrosoftDynamicsCRMprocessstage>), IList<MicrosoftDynamicsCRMsyncerror> workflowSyncErrors = default(IList<MicrosoftDynamicsCRMsyncerror>), IList<MicrosoftDynamicsCRMnewprocess> workflowNewprocess = default(IList<MicrosoftDynamicsCRMnewprocess>), MicrosoftDynamicsCRMworkflow activeworkflowid = default(MicrosoftDynamicsCRMworkflow), IList<MicrosoftDynamicsCRMworkflow> workflowActiveWorkflow = default(IList<MicrosoftDynamicsCRMworkflow>), MicrosoftDynamicsCRMsystemuser modifiedonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser createdby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser owninguser = default(MicrosoftDynamicsCRMsystemuser))
        {
            Deletestage = deletestage;
            Xaml = xaml;
            Iscustomizable = iscustomizable;
            Name = name;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            Versionnumber = versionnumber;
            Entityimage = entityimage;
            Scope = scope;
            Inputparameters = inputparameters;
            this._modifiedbyValue = _modifiedbyValue;
            Componentstate = componentstate;
            Runas = runas;
            Ondemand = ondemand;
            Workflowid = workflowid;
            Modifiedon = modifiedon;
            EntityimageTimestamp = entityimageTimestamp;
            Syncworkflowlogonfailure = syncworkflowlogonfailure;
            Createdon = createdon;
            Iscrmuiworkflow = iscrmuiworkflow;
            Uniquename = uniquename;
            Processroleassignment = processroleassignment;
            Businessprocesstype = businessprocesstype;
            Formid = formid;
            Updatestage = updatestage;
            Rank = rank;
            Type = type;
            this._owningbusinessunitValue = _owningbusinessunitValue;
            Triggeroncreate = triggeroncreate;
            Uidata = uidata;
            this._plugintypeidValue = _plugintypeidValue;
            Category = category;
            Statecode = statecode;
            Rendererobjecttypecode = rendererobjecttypecode;
            this._owningteamValue = _owningteamValue;
            Asyncautodelete = asyncautodelete;
            Triggeronupdateattributelist = triggeronupdateattributelist;
            Description = description;
            Statuscode = statuscode;
            Ismanaged = ismanaged;
            Workflowidunique = workflowidunique;
            Overwritetime = overwritetime;
            this._owninguserValue = _owninguserValue;
            this._parentworkflowidValue = _parentworkflowidValue;
            this._createdbyValue = _createdbyValue;
            Subprocess = subprocess;
            EntityimageUrl = entityimageUrl;
            Solutionid = solutionid;
            Languagecode = languagecode;
            Introducedversion = introducedversion;
            this._activeworkflowidValue = _activeworkflowidValue;
            Processorder = processorder;
            Istransacted = istransacted;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            Clientdata = clientdata;
            Mode = mode;
            Triggerondelete = triggerondelete;
            Entityimageid = entityimageid;
            Createstage = createstage;
            Primaryentity = primaryentity;
            this._owneridValue = _owneridValue;
            this._sdkmessageidValue = _sdkmessageidValue;
            WorkflowPhonetocaseprocess = workflowPhonetocaseprocess;
            WorkflowLeadtoopportunitysalesprocess = workflowLeadtoopportunitysalesprocess;
            WorkflowOpportunitysalesprocess = workflowOpportunitysalesprocess;
            LkNewBpfC990ad2a1520457b87564f32c6b3a91eProcessid = lkNewBpfC990ad2a1520457b87564f32c6b3a91eProcessid;
            LkNewBpfAeeb3ada439a4f619bf1a429c6f7154eProcessid = lkNewBpfAeeb3ada439a4f619bf1a429c6f7154eProcessid;
            LkNewBpf042a40fe36e44388b3a9a191b03dab85Processid = lkNewBpf042a40fe36e44388b3a9a191b03dab85Processid;
            LkNewBpfD191d396d30b4080a49c77b0d411997eProcessid = lkNewBpfD191d396d30b4080a49c77b0d411997eProcessid;
            SlabaseWorkflowid = slabaseWorkflowid;
            Owningbusinessunit = owningbusinessunit;
            Createdonbehalfby = createdonbehalfby;
            Ownerid = ownerid;
            LkAsyncoperationWorkflowactivationid = lkAsyncoperationWorkflowactivationid;
            Parentworkflowid = parentworkflowid;
            WorkflowParentWorkflow = workflowParentWorkflow;
            WorkflowExpiredprocess = workflowExpiredprocess;
            SlaitembaseWorkflowid = slaitembaseWorkflowid;
            WorkflowTranslationprocess = workflowTranslationprocess;
            ProcessProcesstrigger = processProcesstrigger;
            Owningteam = owningteam;
            WorkflowAnnotation = workflowAnnotation;
            LkProcesssessionProcessid = lkProcesssessionProcessid;
            ProcessProcessstage = processProcessstage;
            WorkflowSyncErrors = workflowSyncErrors;
            WorkflowNewprocess = workflowNewprocess;
            Activeworkflowid = activeworkflowid;
            WorkflowActiveWorkflow = workflowActiveWorkflow;
            Modifiedonbehalfby = modifiedonbehalfby;
            Createdby = createdby;
            Modifiedby = modifiedby;
            Owninguser = owninguser;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "deletestage")]
        public int? Deletestage { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "xaml")]
        public string Xaml { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "iscustomizable")]
        public string Iscustomizable { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdonbehalfby_value")]
        public string _createdonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public string Versionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonConverter(typeof(Base64UrlJsonConverter))]
        [JsonProperty(PropertyName = "entityimage")]
        public byte[] Entityimage { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "scope")]
        public int? Scope { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "inputparameters")]
        public string Inputparameters { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedby_value")]
        public string _modifiedbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "componentstate")]
        public int? Componentstate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "runas")]
        public int? Runas { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ondemand")]
        public bool? Ondemand { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "workflowid")]
        public string Workflowid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedon")]
        public System.DateTimeOffset? Modifiedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "entityimage_timestamp")]
        public long? EntityimageTimestamp { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "syncworkflowlogonfailure")]
        public bool? Syncworkflowlogonfailure { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdon")]
        public System.DateTimeOffset? Createdon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "iscrmuiworkflow")]
        public bool? Iscrmuiworkflow { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "uniquename")]
        public string Uniquename { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "processroleassignment")]
        public string Processroleassignment { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "businessprocesstype")]
        public int? Businessprocesstype { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "formid")]
        public string Formid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "updatestage")]
        public int? Updatestage { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "rank")]
        public int? Rank { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public int? Type { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owningbusinessunit_value")]
        public string _owningbusinessunitValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "triggeroncreate")]
        public bool? Triggeroncreate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "uidata")]
        public string Uidata { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_plugintypeid_value")]
        public string _plugintypeidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "category")]
        public int? Category { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statecode")]
        public int? Statecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "rendererobjecttypecode")]
        public string Rendererobjecttypecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owningteam_value")]
        public string _owningteamValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "asyncautodelete")]
        public bool? Asyncautodelete { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "triggeronupdateattributelist")]
        public string Triggeronupdateattributelist { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statuscode")]
        public int? Statuscode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ismanaged")]
        public bool? Ismanaged { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "workflowidunique")]
        public string Workflowidunique { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "overwritetime")]
        public System.DateTimeOffset? Overwritetime { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owninguser_value")]
        public string _owninguserValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_parentworkflowid_value")]
        public string _parentworkflowidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdby_value")]
        public string _createdbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "subprocess")]
        public bool? Subprocess { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "entityimage_url")]
        public string EntityimageUrl { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "solutionid")]
        public string Solutionid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "languagecode")]
        public int? Languagecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "introducedversion")]
        public string Introducedversion { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_activeworkflowid_value")]
        public string _activeworkflowidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "processorder")]
        public int? Processorder { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "istransacted")]
        public bool? Istransacted { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedonbehalfby_value")]
        public string _modifiedonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "clientdata")]
        public string Clientdata { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "mode")]
        public int? Mode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "triggerondelete")]
        public bool? Triggerondelete { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "entityimageid")]
        public string Entityimageid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createstage")]
        public int? Createstage { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "primaryentity")]
        public string Primaryentity { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_ownerid_value")]
        public string _owneridValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_sdkmessageid_value")]
        public string _sdkmessageidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "workflow_phonetocaseprocess")]
        public IList<MicrosoftDynamicsCRMphonetocaseprocess> WorkflowPhonetocaseprocess { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "workflow_leadtoopportunitysalesprocess")]
        public IList<MicrosoftDynamicsCRMleadtoopportunitysalesprocess> WorkflowLeadtoopportunitysalesprocess { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "workflow_opportunitysalesprocess")]
        public IList<MicrosoftDynamicsCRMopportunitysalesprocess> WorkflowOpportunitysalesprocess { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "lk_new_bpf_c990ad2a1520457b87564f32c6b3a91e_processid")]
        public IList<MicrosoftDynamicsCRMnewBpfC990ad2a1520457b87564f32c6b3a91e> LkNewBpfC990ad2a1520457b87564f32c6b3a91eProcessid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "lk_new_bpf_aeeb3ada439a4f619bf1a429c6f7154e_processid")]
        public IList<MicrosoftDynamicsCRMnewBpfAeeb3ada439a4f619bf1a429c6f7154e> LkNewBpfAeeb3ada439a4f619bf1a429c6f7154eProcessid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "lk_new_bpf_042a40fe36e44388b3a9a191b03dab85_processid")]
        public IList<MicrosoftDynamicsCRMnewBpf042a40fe36e44388b3a9a191b03dab85> LkNewBpf042a40fe36e44388b3a9a191b03dab85Processid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "lk_new_bpf_d191d396d30b4080a49c77b0d411997e_processid")]
        public IList<MicrosoftDynamicsCRMnewBpfD191d396d30b4080a49c77b0d411997e> LkNewBpfD191d396d30b4080a49c77b0d411997eProcessid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "slabase_workflowid")]
        public IList<MicrosoftDynamicsCRMsla> SlabaseWorkflowid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owningbusinessunit")]
        public MicrosoftDynamicsCRMbusinessunit Owningbusinessunit { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdonbehalfby")]
        public MicrosoftDynamicsCRMsystemuser Createdonbehalfby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ownerid")]
        public MicrosoftDynamicsCRMprincipal Ownerid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "lk_asyncoperation_workflowactivationid")]
        public IList<MicrosoftDynamicsCRMasyncoperation> LkAsyncoperationWorkflowactivationid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "parentworkflowid")]
        public MicrosoftDynamicsCRMworkflow Parentworkflowid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "workflow_parent_workflow")]
        public IList<MicrosoftDynamicsCRMworkflow> WorkflowParentWorkflow { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "workflow_expiredprocess")]
        public IList<MicrosoftDynamicsCRMexpiredprocess> WorkflowExpiredprocess { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "slaitembase_workflowid")]
        public IList<MicrosoftDynamicsCRMslaitem> SlaitembaseWorkflowid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "workflow_translationprocess")]
        public IList<MicrosoftDynamicsCRMtranslationprocess> WorkflowTranslationprocess { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "process_processtrigger")]
        public IList<MicrosoftDynamicsCRMprocesstrigger> ProcessProcesstrigger { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owningteam")]
        public MicrosoftDynamicsCRMteam Owningteam { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Workflow_Annotation")]
        public IList<MicrosoftDynamicsCRMannotation> WorkflowAnnotation { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "lk_processsession_processid")]
        public IList<MicrosoftDynamicsCRMprocesssession> LkProcesssessionProcessid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "process_processstage")]
        public IList<MicrosoftDynamicsCRMprocessstage> ProcessProcessstage { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Workflow_SyncErrors")]
        public IList<MicrosoftDynamicsCRMsyncerror> WorkflowSyncErrors { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "workflow_newprocess")]
        public IList<MicrosoftDynamicsCRMnewprocess> WorkflowNewprocess { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "activeworkflowid")]
        public MicrosoftDynamicsCRMworkflow Activeworkflowid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "workflow_active_workflow")]
        public IList<MicrosoftDynamicsCRMworkflow> WorkflowActiveWorkflow { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedonbehalfby")]
        public MicrosoftDynamicsCRMsystemuser Modifiedonbehalfby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdby")]
        public MicrosoftDynamicsCRMsystemuser Createdby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedby")]
        public MicrosoftDynamicsCRMsystemuser Modifiedby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owninguser")]
        public MicrosoftDynamicsCRMsystemuser Owninguser { get; set; }

    }
}
