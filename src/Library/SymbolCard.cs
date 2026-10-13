using System;

namespace Ucu.Poo.Cards
{
    /// <summary>
    /// Representa un naipe que se imprime con símbolos, por ejemplo A♠.
    /// </summary>
    public class SymbolCard : ICardContent
    {
        private readonly Card card;

        /// <summary>
        /// Inicializa una nueva instancia de la clase <see cref="SymbolCard"/>.
        /// </summary>
        /// <param name="card">El naipe a imprimir.</param>
        public SymbolCard(Card card)
        {
            ArgumentNullException.ThrowIfNull(card);
            this.card = card;
        }

        /// <summary>
        /// Obtiene el texto con símbolos del naipe.
        /// </summary>
        /// <returns>El texto del naipe, por ejemplo A♠.</returns>
        public string GetTextToPrint()
        {
            string symbol;
            switch (this.card.Suit)
            {
                case Suit.Hearts:
                    symbol = "♥";
                    break;
                case Suit.Diamonds:
                    symbol = "♦";
                    break;
                case Suit.Clubs:
                    symbol = "♣";
                    break;
                default:
                    symbol = "♠";
                    break;
            }

            string value;
            switch (this.card.Rank)
            {
                case Rank.Jack:
                    value = "J";
                    break;
                case Rank.Queen:
                    value = "Q";
                    break;
                case Rank.King:
                    value = "K";
                    break;
                case Rank.Ace:
                    value = "A";
                    break;
                default:
                    value = ((int)this.card.Rank + 2).ToString();
                    break;
            }

            return $"{value}{symbol}";
        }
    }
}