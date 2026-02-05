using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace WpfApp1.Data.Models
{
    [Table("words")]   // ← очень желательно явно указать имя таблицы
    public class Word
    {
        [Key]
        [Column("w_id")]
        public int WordId { get; set; }

        [Column("foreign_word")]
        [Required]
        [MaxLength(250)]
        public string EnglishWord { get; set; } = null!;

        // добавь хотя бы ещё одно поле для примера
        [Column("word_translation")]
        [MaxLength(250)]
        public string RussianTranslation { get; set; } = null!;

    }
}
