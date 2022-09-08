﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fauna
{
	interface IFlyingObject
	{
		int Speed { get; }
		void Fly();
	}
}
