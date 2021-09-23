using System;
using System.Globalization;

namespace Media_altura
{
    class Program
    {
        static void Main(string[] args)
        {
            //Criando as variáveis junto do array.
            int numeroPe = 0;
            double[] vect;
            double Media = 0;
            //Chamando o método para iniciar o programa.
            Iniciar();
            //Separei o programa em partes para facilitar a caso precise de manutenção.
            //Primeira parte Iniciar, é onde da início ao programa.
            void Iniciar()
            {
                //Demosntrando o que estou pedindo do usuário.
                Console.WriteLine("Coloque a quantidade do total de pessoas: ");
                //Computando o dado que foi enviado.
                numeroPe = int.Parse(Console.ReadLine());
                //Criando o objeto Array.
                vect = new double[numeroPe];
                //Percorrendo a todo o Array computando a altura de cada um.
                for (int i = 0; i < numeroPe; i++)
                {
                    Console.WriteLine("Adicione a altura das pessoas: ");
                    vect[i] = double.Parse(Console.ReadLine());
                }
                //Segunda parte onde o programa da continuidade após computar os dados.
                Continuar();


                void Continuar()
                {
                    //Limpando o console.
                    Console.Clear();
                    //Demonstrando ao usuário seus dados.
                    Console.WriteLine("Quantidade total de pessoas: " + numeroPe);

                    for (int i = 0; i < numeroPe; i++)
                    {
                        Console.WriteLine("tamanho da pessoa (" + i + "): " + vect[i]);
                    }
                    //Iniciando a ultima parte do programa.
                    MediaAltura();
                }
                //Calculo e finalização.
                void MediaAltura()
                {
                    //Somando todos os componentes da Array.
                    for (int i = 0; i < numeroPe; i++)
                    {
                        Media = Media + vect[i];
                    }
                    //Dividindo a soma pela quantidade de pessoas.
                    Media = Media / numeroPe;
                    //Demonstrando o resultado final.
                    Console.WriteLine("Média de altura das pessoas: " + Media.ToString("F2", CultureInfo.InvariantCulture));
                }
            }
        }
    }
}
