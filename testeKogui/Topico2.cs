using testeKogui.models;
using testeKogui.service;

namespace testeKogui
{
    internal class Topico2
    {
        public async Task MostrarFrase()
        {
            CorService service = new CorService();
            Topico1 topico1 = new Topico1();

            ChaveCor[] listaChaveCor = topico1.InstaciarListaChaveCor();
            List<string> codigosHex = new List<string> { "0000FF", "00FF00", "FFFFFF", "FF0000", "FFA500", "FFFF00", "000000" };
            string frase = "";

            foreach (var codigo in codigosHex)
            {
                CorResponse corResponse = await service.GetColorNameAsync(codigo);

                if (corResponse != null)
                {
                    foreach (var chaveCor in listaChaveCor)
                    {
                        if (chaveCor.cor == corResponse.name.value)
                        {
                            frase += chaveCor.componente + " ";
                        }
                    }
                }
            }
            Console.WriteLine(frase);
        }
    }
}