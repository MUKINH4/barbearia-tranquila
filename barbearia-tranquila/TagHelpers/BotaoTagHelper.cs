using Microsoft.AspNetCore.Razor.TagHelpers;

namespace barbearia_tranquila.TagHelpers
{
    public class BotaoTagHelper : TagHelper
    {
        public string Cor { get; set; } = "btn-primary";
        public string? Texto { get; set; } = "Agendar";
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "button";
            output.Attributes.SetAttribute("class", $"btn {Cor}");
            output.Content.SetContent(Texto);
        }
    }
}
