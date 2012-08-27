﻿using dot10.IO;

namespace dot10.PE {
	/// <summary>
	/// Converts a <see cref="FileOffset"/> to/from an <see cref="RVA"/>
	/// </summary>
	public interface IPEType {
		/// <summary>
		/// Converts a <see cref="FileOffset"/> to an <see cref="RVA"/>
		/// </summary>
		/// <param name="peInfo">The PEInfo context</param>
		/// <param name="offset">The file offset to convert</param>
		/// <returns>The RVA</returns>
		RVA ToRVA(PEInfo peInfo, FileOffset offset);

		/// <summary>
		/// Converts an <see cref="RVA"/> to a <see cref="FileOffset"/>
		/// </summary>
		/// <param name="peInfo">The PEInfo context</param>
		/// <param name="rva">The RVA to convert</param>
		/// <returns>The file offset</returns>
		FileOffset ToFileOffset(PEInfo peInfo, RVA rva);
	}
}
