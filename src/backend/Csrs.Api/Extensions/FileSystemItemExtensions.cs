﻿namespace Csrs.Api.Extensions
{
    /// <summary>
    /// ViewModel transforms.
    /// </summary>
    public static class FileSystemItemExtensions
    {
        const string NameDocumentTypeSeparator = "__";

        public static string GetDocumentName(string value)
        {
            string result = "";
            if (value != null)
            {
                int pos = value.IndexOf(NameDocumentTypeSeparator);
                if (pos > -1)
                {
                    result = value.Substring(pos + 2);
                }
            }
            return result;
        }

        public static string GetDocumentType(string value)
        {
            string result = "";
            if (value != null)
            {
                int pos = value.IndexOf(NameDocumentTypeSeparator);
                if (pos > -1)
                {
                    result = value.Substring(0, pos);
                }
            }
            return result;
        }

        public static string CombineNameDocumentType(string name, string documentType)
        {
            string result = documentType + NameDocumentTypeSeparator + name;
            return result;
        }

    }
}
