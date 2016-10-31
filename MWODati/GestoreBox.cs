using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MWODati
{

    public static class ControlExtensions
    {
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool LockWindowUpdate(IntPtr hWndLock);

        public static void Suspend(this Control control)
        {
            LockWindowUpdate(control.Handle);
        }

        public static void Resume(this Control control)
        {
            LockWindowUpdate(IntPtr.Zero);
        }

    }

    static public class GestoreBox
    {
        public static int Recursione = 1;
        static public void Accorcia(RichTextBox box)
        {
            int lineCount = box.Lines.Length - Config.MaxRigheTextBox;
            int start_index = box.GetFirstCharIndexFromLine(lineCount);

            box.Select(0, start_index);
            box.Cut();

            box.SelectionStart = box.TextLength;
            box.ScrollToCaret();
        }

        static public void StampaTesto(RichTextBox box, string testo)
        {
            VerificaLunghezza(box);

            box.AppendText(Environment.NewLine);
            box.SelectionFont = new Font("Courier New", 12, FontStyle.Regular);
            box.SelectionColor = Color.White;
            box.AppendText(testo);
        }

        static public void StampaStanza(RichTextBox box, string[] dati)
        {
            int numeroElementi = dati.Count() - 1;

            VerificaLunghezza(box);

            box.AppendText(Environment.NewLine);
            box.SelectionFont = new Font("Courier New", 12, FontStyle.Bold);
            box.SelectionColor = Color.DarkRed;
            box.AppendText(dati[10]);

            box.AppendText(Environment.NewLine);
            box.SelectionFont = new Font("Courier New", 10, FontStyle.Regular);
            box.SelectionColor = Color.White;
            //box.AppendText(stanza.Descrizione);

            box.AppendText(Environment.NewLine);
            box.SelectionFont = new Font("Courier New", 10, FontStyle.Regular);
            box.SelectionColor = Color.Blue;
            box.AppendText("Oggetti:");

            box.SelectionFont = new Font("Courier New", 10, FontStyle.Regular);
            box.SelectionColor = Color.Turquoise;
            //box.AppendText(string.Join(", ", stanza.Oggetti));
            box.ScrollToCaret();
        }

        static public void VerificaLunghezza(RichTextBox box)
        {
            if (box.Lines.Length > Config.MaxRigheTextBox)
            {
                box.Suspend();
                Accorcia(box);
                box.Resume();
            }
        }
    }
}
