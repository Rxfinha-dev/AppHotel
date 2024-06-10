using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppHotel.Models
{
    public class hospedagem
    {
        public quarto QuartoSelecionado {get; set;}

        public int QntAdultos { get; set;}

        public int QntCriancas { get; set;}

        public DateTime DataCheckIn { get; set;}

        public DateTime DataCheckOut { get; set;}

        public int Estadia
        {
            get => DataCheckOut.Subtract(DataCheckIn).Days;
        }
        public double ValorTotal
        {
           get
            {
                double ValorAdultos = QntAdultos * QuartoSelecionado.ValorDiariaAdulto;
                double ValorCriancas = QntCriancas * QuartoSelecionado.ValorDiariaCrianca;

                double total = (ValorAdultos + ValorCriancas) * Estadia;

                return total;
            }
        }

    }
}
