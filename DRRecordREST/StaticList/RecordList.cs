using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ModelLIb.model;

namespace DRRecordREST.StaticList
{
    public class RecordList
    {
        private static List<Record> records = new List<Record>
        {
            new Record(1,"Guld", "Mikkel das Dickel", 200, "2019", "Danmark", true),
            new Record(2,"Min Lille Mand", "Carl Gustaf Larson", 459, "1910", "Sverigestan", false),
            new Record(3,"Store Peter Raketbygger", "Peter Madsen", 300, "2017", "Danmark",true),
            new Record(4,"99 Luftballons", "NENA", 253, "2000", "Deutschland",true),
            new Record(5,"I Want It That Way", "BackStreet Boys", 213, "1999", "England",true)
        };
        public IList<Record> GetAllRecords()
        {
            return records;
        }


    }
}
