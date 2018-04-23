using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BatchEditCancel.Models {
    public class SampleModel {
        public int ID { get; set; }
        public string ClientSideCancel { get; set; }
        public string ClientSideReadOnly { get; set; }
        public int ServerSideExample { get; set; }
    }
    public static class DataProvider {
        public static IEnumerable<SampleModel> GetData() {
            return Enumerable.Range(0, 10).Select(i => new SampleModel {
                ID = i,
                ClientSideCancel = "Example " + i,
                ClientSideReadOnly = "Sample data " + i,
                ServerSideExample = i * 123
            });
        }
    }
}