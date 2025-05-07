using Microsoft.AspNetCore.Razor.TagHelpers;

namespace barbearia_tranquila.TagHelpers
{
    public class MensagemTagHelper : TagHelper
    {

        public string? Texto { get; set; }
        public string? Classe { get; set; } = "alert alert-success";
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "div";
            if (!string.IsNullOrEmpty(Texto))
            {
                output.Attributes.SetAttribute("class", Classe);
            }
            output.Content.SetContent(Texto);
        }
    }
}
