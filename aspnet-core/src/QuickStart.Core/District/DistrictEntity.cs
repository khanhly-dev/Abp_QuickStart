using Abp.Domain.Entities;
using QuickStart.City;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickStart.District
{
    [Table("District")]
    public class DistrictEntity : Entity
    {
        [ForeignKey(nameof(CityId))]
        public int CityId { get; set; }
        public CityEntity City { get; set; }
        public string Name { get; set; }
    }
}
