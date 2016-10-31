using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MWODati
{
    public static class Funzioni
    {

        public static string[] retriveData(string url)
        {
            string s;
            string[] ritorno = null;
            string URL = url;
            try
            {
                using (WebClient client = new WebClient())
                {
                    s = client.DownloadString(url);
                    client.Dispose();
                }
                ritorno = s.Split('\n');
                return ritorno;
            }
            catch
            {
                return ritorno;
            }
        }


        /// <summary>
        /// Ricerca effettivamente il "nome" all'interno del DB
        /// della "stagione" specificata.
        /// </summary>
        /// <param name="stagione"></param>
        /// <param name="nome"></param>
        /// <returns></returns>
        public static string RicercaDB(int stagione, string nome)
        {
            string stagioneRicerca = string.Empty;
            string[] datiStagioneSelezionata = null;
            string[] stringa = null;
            string ritorno = string.Empty;
            Boolean trovato = false;
            switch (stagione)
            {
                case 1:
                    stagioneRicerca = Config.Season1URL;
                    datiStagioneSelezionata = Config.fileSeason1;
                    break;
                case 2:
                    stagioneRicerca = Config.Season2URL;
                    datiStagioneSelezionata = Config.fileSeason2;
                    break;
                case 3:
                    stagioneRicerca = Config.Season3URL;
                    datiStagioneSelezionata = Config.fileSeason3;
                    break;
                case 4:
                    stagioneRicerca = Config.Season4URL;
                    datiStagioneSelezionata = Config.fileSeason4;
                    break;
                default:
                    stagioneRicerca = Config.Season1URL;
                    break;
            }

            foreach (var tr in datiStagioneSelezionata)
            {
                stringa = Funzioni.Parsificatore(tr);
                if (stringa[1] == nome)
                {
                    //AGGIUNTA 'STAGIONE' all'Array
                    int numeroElementi = stringa.Count() - 1;
                    stringa[numeroElementi] = $"{stagione}";
                    //STAMPA
                    ritorno = $"{Environment.NewLine}{stringa[1]}{Environment.NewLine}STAGIONE {stagione}:{Environment.NewLine}Posizione:\t{stringa[0]}{Environment.NewLine}Vittorie:\t\t{stringa[2]}{Environment.NewLine}Sconfitte:\t{stringa[3]}{Environment.NewLine}Rapporto V/S:\t{stringa[4]}{Environment.NewLine}Kill:\t\t{stringa[5]}{Environment.NewLine}Death:\t\t{stringa[6]}{Environment.NewLine}Rapporto K/D:\t{stringa[7]}{Environment.NewLine}Partite:\t\t{stringa[8]}{Environment.NewLine}MS Medio:\t{stringa[9]}";
                    trovato = true;
                    break;
                }
            }
            if (trovato == false)
            {
                ritorno = string.Empty;
            }
            return ritorno;
        }

        /// <summary>
        /// Cerca il Nome all'interno dei dati della Stagione, 
        /// e restituisce la stringa non parsificata.
        /// </summary>
        /// <param name="stagione"></param>
        /// <param name="nome"></param>
        /// <returns></returns>
        public static string Ricerca (int stagione, string nome)
        {
            string valore = RicercaDB(stagione, nome);
            if(string.IsNullOrEmpty(valore))
            {
                valore = $"{Environment.NewLine}STAGIONE {stagione}: Elemento non trovato.";
            }
            return valore;
        }

        /// <summary>
        /// Parsifica la stringa di dati in entrata.
        /// Restituisce un'array di dati.
        /// </summary>
        /// <param name="dati"></param>
        /// <returns></returns>
        public static string[] Parsificatore(string dati)
        {
            string[] arrayDati = null;
            if (dati.Contains(";"))
            {
                arrayDati = dati.Split(';');
            }
            return arrayDati;
        }

        public static string PreparaTesto(RichTextBox box, string[] stringa)
        {

            return string.Empty;
        }
    }
}
