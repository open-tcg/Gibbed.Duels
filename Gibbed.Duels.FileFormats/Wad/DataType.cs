﻿/* Copyright (c) 2012 Rick (rick 'at' gibbed 'dot' us)
 * 
 * This software is provided 'as-is', without any express or implied
 * warranty. In no event will the authors be held liable for any damages
 * arising from the use of this software.
 * 
 * Permission is granted to anyone to use this software for any purpose,
 * including commercial applications, and to alter it and redistribute it
 * freely, subject to the following restrictions:
 * 
 * 1. The origin of this software must not be misrepresented; you must not
 *    claim that you wrote the original software. If you use this software
 *    in a product, an acknowledgment in the product documentation would
 *    be appreciated but is not required.
 * 
 * 2. Altered source versions must be plainly marked as such, and must not
 *    be misrepresented as being the original software.
 * 
 * 3. This notice may not be removed or altered from any source
 *    distribution.
 */

using System.IO;
using Gibbed.IO;

namespace Gibbed.Duels.FileFormats.Wad
{
    public class DataType
    {
        public uint Index;
        public uint Unknown2;

        public void Serialize(Stream output, Endian endian)
        {
            output.WriteValueU32(this.Index, endian);
            output.WriteValueU32(this.Unknown2, endian);
        }

        public void Deserialize(Stream input, Endian endian)
        {
            this.Index = input.ReadValueU32(endian);
            this.Unknown2 = input.ReadValueU32(endian);
        }

        public override string ToString()
        {
            return string.Format("{0}, {1}",
                                 this.Index,
                                 this.Unknown2);
        }
    }
}
