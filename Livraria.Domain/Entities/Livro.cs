using Livraria.Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Livraria.Domain.Entities
{
    public class Livro
    {
        public Livro(int id, string? title, string? author, DateTime release_at, 
            string? cover, Publisher publisher, Category category, DateTime? created_at, DateTime? updated_at)
        {
            Id = id;
            Title = title;
            Author = author;
            Release_at = release_at;
            Cover = cover;
            Publisher = publisher;
            Category = category;
            Created_at = created_at;
            Updated_at = updated_at;
        }

        public int Id { get; set; }

        [Required(ErrorMessage = "Informe o título do livro!")]
        [StringLength(150)]
        public string? Title { get; set; }

        [Required(ErrorMessage = "Informe o autor do livro!")]
        [StringLength(200)]
        public string? Author {  get; set; }


        [Required(ErrorMessage = "Informe a data de lançamento do livro!")]
        public DateTime Release_at { get; set; }


        [Required(ErrorMessage = "Informe a imagem da capa!")]
        [StringLength(200)]
        public string? Cover {  get; set; }

        [Required]
        [EnumDataType(typeof(Publisher), ErrorMessage = "Selecione a editora")]
        public Publisher Publisher {  get; set; }

        [Required]
        [EnumDataType(typeof(Category), ErrorMessage = "Selecione a categoria")]
        public Category Category {  get; set; }

        public DateTime? Created_at { get; set; } = DateTime.Now;

        public DateTime? Updated_at { get; set; } = DateTime.Now;
    }
}
