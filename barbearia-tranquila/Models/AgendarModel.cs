using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace barbearia_tranquila.Models
{
    public class AgendarModel
    {
        public enum Servicos
        {
            [Display(Name = "Corte de Cabelo")]
            Corte,

            [Display(Name = "Barba Tradicional")]
            Barba,

            [Display(Name = "Corte + Barba")]
            CorteEBarba,

            [Display(Name = "Outros Serviços")]
            Outros
        }

        public enum StatusEnum 
        {
            Pendente,
            Confirmado,
            Cancelado
        }

        public enum Profissionais
        {
            Robertinho,
            Kaicão,
            Tulio
        }

        [HiddenInput]
        public int Id { get; set; }
        public string Nome { get; set; }

        [Required(ErrorMessage = "Telefone é obrigatório")]
        [RegularExpression(@"\(?\d{2}\)?\s?\d{4,5}\-?\d{4}", ErrorMessage = "Telefone inválido")]
        public string Telefone { get; set; }

        [Display(Name = "Data")]
        [DataType(DataType.Date)]
        public DateTime Data { get; set; }

        [Display(Name = "Hora")]
        [DataType(DataType.Time)]
        public TimeSpan Hora { get; set; }

        public Servicos Servico { get; set; }
        public Profissionais Profissional { get; set; }
        public string Observacoes { get; set; }
        public StatusEnum Status { get; set; }

        public AgendarModel(string nome, string telefone, DateTime data, TimeSpan hora, Servicos servico, Profissionais profissional, string observacoes, StatusEnum status)
        {
            this.Nome = nome;
            this.Telefone = telefone;
            this.Data = data;
            this.Hora = hora;
            this.Servico = servico;
            this.Profissional = profissional;
            this.Observacoes = observacoes;
            this.Status = status;
        }

        public AgendarModel()
        {
            this.Data = DateTime.Now;
            this.Status = StatusEnum.Pendente; 
        }
    }
}
