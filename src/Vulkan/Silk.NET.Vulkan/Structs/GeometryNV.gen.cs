// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Core;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkGeometryNV")]
    public unsafe partial struct GeometryNV
    {
        public GeometryNV
        (
            StructureType? sType = StructureType.GeometryNV,
            void* pNext = null,
            GeometryTypeKHR? geometryType = null,
            GeometryDataNV? geometry = null,
            GeometryFlagsKHR? flags = null
        ) : this()
        {
            if (sType is not null)
            {
                SType = sType.Value;
            }

            if (pNext is not null)
            {
                PNext = pNext;
            }

            if (geometryType is not null)
            {
                GeometryType = geometryType.Value;
            }

            if (geometry is not null)
            {
                Geometry = geometry.Value;
            }

            if (flags is not null)
            {
                Flags = flags.Value;
            }
        }

/// <summary></summary>
        [NativeName("Type", "VkStructureType")]
        [NativeName("Type.Name", "VkStructureType")]
        [NativeName("Name", "sType")]
        public StructureType SType;
/// <summary></summary>
        [NativeName("Type", "void*")]
        [NativeName("Type.Name", "void")]
        [NativeName("Name", "pNext")]
        public void* PNext;
/// <summary></summary>
        [NativeName("Type", "VkGeometryTypeKHR")]
        [NativeName("Type.Name", "VkGeometryTypeKHR")]
        [NativeName("Name", "geometryType")]
        public GeometryTypeKHR GeometryType;
/// <summary></summary>
        [NativeName("Type", "VkGeometryDataNV")]
        [NativeName("Type.Name", "VkGeometryDataNV")]
        [NativeName("Name", "geometry")]
        public GeometryDataNV Geometry;
/// <summary></summary>
        [NativeName("Type", "VkGeometryFlagsKHR")]
        [NativeName("Type.Name", "VkGeometryFlagsKHR")]
        [NativeName("Name", "flags")]
        public GeometryFlagsKHR Flags;
    }
}
