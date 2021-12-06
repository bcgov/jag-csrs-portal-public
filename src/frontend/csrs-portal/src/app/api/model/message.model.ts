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


export interface Message { 
    messageGuid?: string;
    fileGuid: string;
    fileNo: string;
    subject: string;
    date?: string | null;
    attachment?: boolean;
    isRead?: boolean;
}
