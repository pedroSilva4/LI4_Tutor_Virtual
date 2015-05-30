namespace NomesdaHistoriaApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Perguntas
    {
        //a proxima resposta a sair pelo metodo getNextAnswer
        public int nextAnswer; //1,2,3,4(certa)
        public int firstAnser;

        public string getNextAnswer()
        {
            if (nextAnswer == 1)
            {
                if (nextAnswer == 4) nextAnswer = 1;
                else nextAnswer++;
                return errada1;
            }
            if (nextAnswer == 2)
            {
                if (nextAnswer == 4) nextAnswer = 1;
                else nextAnswer++;
                return errada2;
            }
            if (nextAnswer == 3)
            {
                if (nextAnswer == 4) nextAnswer = 1;
                else nextAnswer++;
                return errada3;
            }

            if (nextAnswer == 4) nextAnswer = 1;
            else nextAnswer++;
            return resposta;
        }

        public void randQuestions()
        {
            Random rnd = new Random();
            this.nextAnswer = rnd.Next(1, 4);
            this.firstAnser = this.nextAnswer;
        }

        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int cod { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int aula { get; set; }

        [Required]
        [StringLength(255)]
        public string pergunta { get; set; }

        [Required]
        [StringLength(255)]
        public string resposta { get; set; }

        [StringLength(255)]
        public string errada1 { get; set; }

        [StringLength(255)]
        public string errada2 { get; set; }

        [StringLength(255)]
        public string errada3 { get; set; }

        public virtual Aulas Aulas { get; set; }
    }
}
