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


export interface FileSummary { 
    fileId?: string | null;
    status?: FileStatus;
    usersRole: PartyRole;
}
