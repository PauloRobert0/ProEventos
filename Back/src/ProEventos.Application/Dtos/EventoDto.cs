
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ProEventos.Application.Dtos
{
    public class EventoDto
    {
        public int Id { get; set; }

        public string local { get; set; }

        public string DataEvento { get; set; }
        
        [Required(ErrorMessage = "O campo {0} é obrigatorio!"),
        StringLength(50, MinimumLength = 3,
                        ErrorMessage = "Intervalo permitido de 3 a 50 caracteres!")
        ]
        public string Tema { get; set; }

        [Display(Name ="Qtd Pessoas")]
        [Range(1, 120000, ErrorMessage ="{0} não pode ser menor que 1 e maior que 120.000")]
        public int QtdPessoas { get; set; }


        [RegularExpression(@".*\.(gif|jpe?g|bmp|png)$")]

        public string ImagemURL { get; set; }

        [Required(ErrorMessage =" o campo {0} é obrigatorio!")]
        [Phone(ErrorMessage ="O campo {0} está invalido!")]
        public string Telefone { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatorio!"), 
        Display(Name = "e-mail"),
        EmailAddress(ErrorMessage = "É nescessario ser um {0} válido!")]
        public string Email { get; set; }

        public IEnumerable<LoteDto> Lotes { get; set; }

        public IEnumerable<RedeSocialDto> RedesSociais { get; set; }

        public IEnumerable<PalestranteDto> Palestrantes { get; set; }
    
    }
}