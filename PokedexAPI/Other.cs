﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace FormAPI
{
	public class Other
	{
		[JsonPropertyName("official-artwork")]
		public OfficialArtwork officialartwork { get; set; }
	}
}
