/**
 * CSRS API
 * BC Child Support Recalculation Service API
 *
 * The version of the OpenAPI document: v1
 * 
 *
 * NOTE: This class is auto generated by OpenAPI Generator (https://openapi-generator.tech).
 * https://openapi-generator.tech
 * Do not edit the class manually.
 */
import { PartyRole } from './partyRole.model';
import { FileStatus } from './fileStatus.model';
import { Party } from './party.model';
import { Child } from './child.model';


export interface ModelFile { 
    fileId?: string | null;
    status?: FileStatus;
    usersRole: PartyRole;
    otherParty?: Party;
    /**
     * The children on this file.
     */
    children?: Array<Child> | null;
}

