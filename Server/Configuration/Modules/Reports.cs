﻿//
//  X-RunUO - Ultima Online Server Emulator
//  Copyright (C) 2015 Pedro Pardal
//
//  This program is free software: you can redistribute it and/or modify
//  it under the terms of the GNU General Public License as published by
//  the Free Software Foundation, either version 3 of the License, or
//  (at your option) any later version.
//
//  This program is distributed in the hope that it will be useful,
//  but WITHOUT ANY WARRANTY; without even the implied warranty of
//  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//  GNU General Public License for more details.
//
//  You should have received a copy of the GNU General Public License
//  along with this program.  If not, see <http://www.gnu.org/licenses/>.
//

using System;

namespace Server.Configuration
{
	[ConfigModule]
	public class Reports
	{
		public bool Enabled { get; set; }
		public string FtpHost { get; set; }
		public string FtpUsername { get; set; }
		public string FtpPassword { get; set; }
		public string FtpStatsDirectory { get; set; }
		public string FtpStaffDirectory { get; set; }
	}
}