using Microsoft.AspNetCore.Mvc.Rendering;

namespace HogwartsAcademy.Models
{
    public class Constants
    {
        public static readonly SelectListItem[] UICultures = new SelectListItem[]
        {
            new SelectListItem{Value = "es", Text = "Español"},
            new SelectListItem{Value = "en", Text = "English"}
        };
    }
}
