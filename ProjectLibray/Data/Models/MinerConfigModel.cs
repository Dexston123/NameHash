using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectLibray.Data.Models
{
    public class MinerConfigModel
    {
        public PoolModel pool { get; set; } = new PoolModel();
        public string coin { get; set; } //Coin
        public string apibindhttp { get; set; } //Api
        public string algo { get; set; } //Algorythm
        public string intensity { get; set; } //?
        public string lowload { get; set; } //?
    }
}
