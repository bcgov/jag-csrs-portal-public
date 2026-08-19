namespace Csrs.Api.Models
{
    public class AppConfig
    {
        public bool IsLoginDisabled { get; set; }
        public bool IsMaintenanceBannerVisible { get; set; }
        public string MaintenanceBannerText { get; set; } = string.Empty;
    }
}
