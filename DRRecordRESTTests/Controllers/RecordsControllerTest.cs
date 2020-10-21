using System;
using System.Collections.Generic;
using System.Text;
using DRRecordREST.Controllers;
using DRRecordREST.StaticList;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DRRecordRESTTests.Controllers
{
    [TestClass()]
    public class MusicRecordControllerTests
    {
        private static RecordsController controller;
        private static RecordList list;

        [ClassInitialize]
        public static void Init(TestContext context)
        {
            controller = new RecordsController();
            list = new RecordList();
        }

        [TestMethod()]
        public void GetAllRecordsTest()
        {
            Assert.IsNotNull(list);
            Assert.AreEqual(list.GetAllRecords().Count, 2);
        }
    }
}