using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UniversalDashboard.Models
{
    public class TreeNode
    {   
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("id")]
        public string Id { get; set; }
		[JsonProperty("children")]
		public IEnumerable<TreeNode> Children { get; set; }
        [JsonProperty("icon")]
        public string Icon { get; set; }
    }
}
