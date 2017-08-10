﻿
// Copyright (C) 2016-2017 Luca Piccioni
// 
// This library is free software; you can redistribute it and/or
// modify it under the terms of the GNU Lesser General Public
// License as published by the Free Software Foundation; either
// version 2.1 of the License, or (at your option) any later version.
// 
// This library is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU
// Lesser General Public License for more details.
// 
// You should have received a copy of the GNU Lesser General Public
// License along with this library; if not, write to the Free Software
// Foundation, Inc., 51 Franklin Street, Fifth Floor, Boston, MA  02110-1301
// USA

using System;

namespace OpenGL.Objects
{
	/// <summary>
	/// Graphics surface interface.
	/// </summary>
	public interface IGraphicsSurface : IDisposable
	{
		#region Viewport

		/// <summary>
		/// The width of the surface, in pixels.
		/// </summary>
		uint Width { get; }

		/// <summary>
		/// The width of the surface, in pixels.
		/// </summary>
		uint Height { get; }

		#endregion
	}
}
