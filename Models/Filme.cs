using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MinhaDemoMvc.Models
{
    public class Filme
    {
        [Key]
        public int Id { get; set; }


        [Required(ErrorMessage = "O campo título é obrigatório")]
        [StringLength(60, MinimumLength = 3, ErrorMessage = "O título precisa ter entre 3 ou 60 caracteres.")] //definindo tamanho minimo e maximo da string
        public string Titulo { get; set; }


        [DataType(DataType.DateTime, ErrorMessage = "Data em formato incorreto")]
        [Required(ErrorMessage = "O campo data de lançamento é obrigatório")] //Required => preenche o campo obrigatorio
        [Display(Name = "Data de lançamento")] //Exibir mensagem formatado 
        public DateTime DataLancamento { get; set; }


        [RegularExpression(@"^[A-Z]+[a-zA-Z\u00C0-\u00FF""'\w-]*$", ErrorMessage = "Gênero em formato inválido!")] //definir a regra expressãp a escrever no campo genero texto
        [StringLength(30, ErrorMessage = "Máximo de 30 caracteres"), Required(ErrorMessage = "O campo gênero é requerido")] //pode tudo na mesma linha como essa
        public string Genero { get; set; }


        [Range(1,1000, ErrorMessage = "Valor de 1 a 1000")]
        [Required(ErrorMessage = "Preenche o campo valor")]
        [Column(TypeName = "decimal(18,2)")] //definir tipo formato decimal
        public decimal Valor { get; set; }


        [Required(ErrorMessage = "Preenche o campo valor")]
        [Display(Name = "Avaliação")]
        [RegularExpression(@"^[0-5]*$", ErrorMessage = "Somente números")] //definir a regra exoressão somente número de 0 a 5
        public int Avaliacao { get; set; }
    }
}
