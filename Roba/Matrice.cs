namespace Roba
{
    public class Matrice
    {
        static List<List<int>> TutteLeCombinazioni(int[,] matrice)
        {
            List<List<int>> risultato = new List<List<int>>();
            int numeriTotali = matrice.GetLength(0) * matrice.GetLength(1);
            GeneraCombinazioni(matrice, new List<int>(), risultato, numeriTotali);
            return risultato;
        }
        static void GeneraCombinazioni(int[,] matrice, List<int> combinazioneCorrente, List<List<int>> risultato, int numeriRimanenti)
        {
            if (numeriRimanenti == 0)
            {
                risultato.Add(new List<int>(combinazioneCorrente));
                return;
            }

            int rows = matrice.GetLength(0);
            int cols = matrice.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    int currentNumber = matrice[i, j];
                    if (!combinazioneCorrente.Contains(currentNumber))
                    {
                        combinazioneCorrente.Add(currentNumber);
                        GeneraCombinazioni(matrice, combinazioneCorrente, risultato, numeriRimanenti - 1);
                        combinazioneCorrente.RemoveAt(combinazioneCorrente.Count - 1);
                    }
                }
            }
        }

    }
}
