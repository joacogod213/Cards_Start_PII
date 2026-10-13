namespace Ucu.Poo.Cards
{
    /// <summary>
    /// Representa el contenido de un naipe que se puede imprimir.
    /// </summary>
    public interface ICardContent
    {
        /// <summary>
        /// Obtiene el texto para imprimir.
        /// </summary>
        /// <returns>El texto a imprimir.</returns>
        string GetTextToPrint();
    }
}