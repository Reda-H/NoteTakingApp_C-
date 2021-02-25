using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoteWinApp
{

    public class Note
    {
        private static string _id;
        private static string m_noteTitle;
        private static string m_noteContent;

        public string NoteTitle
        {
            get { return m_noteTitle; }
            set { m_noteTitle = value; }
        }
        public string NoteContent
        {
            get { return m_noteContent; }
            set { m_noteContent = value; }
        }
        public string ID
        {
            get { return _id; }
        }

        public Note(string noteTitle, string noteContent)
        {
            Guid g = Guid.NewGuid();
            _id = g.ToString();

            m_noteTitle = noteTitle;
            m_noteContent = noteContent;
        }

    }

    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
