using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FSISSystem.ENTITIES
{

    [Table("Team")]
    public class Team
    {
        public int TeamID { get; set; }
        public string TeamName { get; set; }

    }
}
