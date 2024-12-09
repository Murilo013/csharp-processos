using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teste.Models
{
    public class Pessoa
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "O nome é obrigatório.")]
        public string? Nome { get; set; }
        [Required(ErrorMessage = "O Telefone é obrigatório.")]
        public string? Telefone { get; set; }
        [Required(ErrorMessage = "O Email é obrigatório.")]
        public string? Email { get; set; }
        [Required(ErrorMessage = "O CEP é obrigatório.")]
        public string? CEP { get; set; }
        public string? Estado { get; set; }
        public string? Cidade { get; set; }
        public string? Bairro { get; set; }
        public string? Rua { get; set; }
        [Required(ErrorMessage = "O Número é obrigatório.")]
        public string? Numero { get; set; }
        public string? Complemento { get; set; }
    }
}
