using System.Collections.Generic;
using Xunit;

namespace test
{
    public class UnitTest
    {
        [Fact]
        public void Test_Quantity_Two()
        {
            int quantity = 2;
            List<string> expected = new List<string> { "ccccaaabd", "xxyyz" };
            var actual = Program.sortingOperations(quantity, new List<string> { "abaccadcc", "xyzxy" });
            
            for (int i = 0; i < expected.Count; i++)
            {
                Assert.Contains(expected[i], actual[i]);
            }

        }

        [Fact]
        public void Test_Quantity_Ten()
        {
            int quantity = 10;
            List<string> expected = new List<string> {
            "gggdlquvwz",
            "tttgjmrwxy",
            "nnghilptux",
            "cgijkoptvz",
            "ddppwwaest",
            "ccppbiklns",
            "ffhhblmtvy",
            "rrrttacnqx",
            "ccnnadmort",
            "ffkkdegnst"
            };

            var actual = Program.sortingOperations(
                quantity,
                new List<string> {
                    "dulgvgzwqg",
                    "gxtjtmtywr",
                    "hnlnxiupgt",
                    "gzjotckivp",
                    "dpwwsdptae",
                    "pcscpilknb",
                    "btvyhhmflf",
                    "artrtnqxcr",
                    "nrtcmcoadn",
                    "fkdsgnekft"
                });

            for (int i = 0; i < expected.Count; i++)
            {
                Assert.Contains(expected[i], actual[i]);
            }

        }

        [Fact]
        public void Test_Quantity_Five()
        {
            int quantity = 5;
            List<string> expected = new List<string> {
            "eeuuwwabnz",
            "fklnovwxyz",
            "eedfklnrxy",
            "ddafgioqsw",
            "ccbfikuvyz"
            };
            var actual = Program.sortingOperations(quantity, new List<string> {
                "wzenwebuau",
                "vokfxzynwl",
                "neldfeyrxk",
                "wqadfiodgs",
                "ykiuvzfcbc"
            });

            for (int i = 0; i < expected.Count; i++)
            {
                Assert.Contains(expected[i], actual[i]);
            }

        }
    }
    
}