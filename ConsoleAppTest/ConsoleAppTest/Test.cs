using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppTest
{
    public class Test
    {
        public int id { get; set; }
        public string firstname { get; set; }
        public string lastname { get; set; }
        public string fullname { get { return $"{firstname} {lastname}"; } }
	    public string address {get; set;}
        public string state { get; set;}
        public string zipcode { get; set; }
    }
}
