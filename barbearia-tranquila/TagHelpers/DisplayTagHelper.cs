using System.ComponentModel.DataAnnotations;
namespace barbearia_tranquila.TagHelpers
{
public static class DisplayTagHelper
{
    public static string GetDisplayName(this Enum value)
    {
        var field = value.GetType().GetField(value.ToString());
        var attribute = field?.GetCustomAttributes(typeof(DisplayAttribute), false)
                              .Cast<DisplayAttribute>()
                              .FirstOrDefault();
        return attribute?.Name ?? value.ToString();
    }
}

}
