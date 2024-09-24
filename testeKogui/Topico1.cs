
using testeKogui.models;

namespace testeKogui
{
    internal class Topico1
    {
        ChaveCor[] listaChaveCor = [];

        public ChaveCor[] InstaciarListaChaveCor()
        {
            listaChaveCor = [
                new ChaveCor() {cor="MagentaFuchsia", componente = null },
                new ChaveCor() {cor="White", componente = "para" },
                new ChaveCor() {cor="Blue", componente = "Pares" },
                new ChaveCor() {cor="Green", componente = "alterar" },
                new ChaveCor() {cor="Black", componente = "#" },
                new ChaveCor() {cor="WebOrange", componente = "e" },
                new ChaveCor() {cor="Yellow", componente = "impares" },
                new ChaveCor() {cor="Red", componente = " " },
                new ChaveCor() {cor="Coconut", componente = "Busca" },
                new ChaveCor() {cor="CyanAqua", componente = "primos" }
            ];

            return listaChaveCor;
        }

        public void MostrarListaChaveCor()
        {
            foreach (var item in listaChaveCor)
            {
                Console.WriteLine("Cor: " + item.cor + " | Componente: " + item.componente);
            }
        }
    }
}