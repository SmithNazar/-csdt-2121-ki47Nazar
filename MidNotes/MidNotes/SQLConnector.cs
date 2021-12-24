using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidNotes
{
    class SQLConnector
    {
        public string GetNotes(string NoteName)
        {
            using (IDbConnection connection = new SqlConnection(@"Server=DESKTOP-QPBOC36\SQLEXPRESS; Database=SynthNotes; Trusted_Connection=True;"))
            //new SqlConnection(Helper.CnnVal("SynthNotes")))
            {
                var notesList = connection.Query<Note>($"SELECT [NoteFrequency] FROM [SynthNotes].[dbo].[MidNotes] WHERE NoteName = '{ NoteName }'").ToList();
                return notesList[0].NoteFrequency;
            }
        }
    }
}
