// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.OpenXR
{
    [NativeName("Name", "XrSystemHandTrackingMeshPropertiesMSFT")]
    public unsafe partial struct SystemHandTrackingMeshPropertiesMSFT
    {
        public SystemHandTrackingMeshPropertiesMSFT
        (
            StructureType? type = StructureType.TypeSystemHandTrackingMeshPropertiesMsft,
            void* next = null,
            uint? supportsHandTrackingMesh = null,
            uint? maxHandMeshIndexCount = null,
            uint? maxHandMeshVertexCount = null
        ) : this()
        {
            if (type is not null)
            {
                Type = type.Value;
            }

            if (next is not null)
            {
                Next = next;
            }

            if (supportsHandTrackingMesh is not null)
            {
                SupportsHandTrackingMesh = supportsHandTrackingMesh.Value;
            }

            if (maxHandMeshIndexCount is not null)
            {
                MaxHandMeshIndexCount = maxHandMeshIndexCount.Value;
            }

            if (maxHandMeshVertexCount is not null)
            {
                MaxHandMeshVertexCount = maxHandMeshVertexCount.Value;
            }
        }

/// <summary></summary>
        [NativeName("Type", "XrStructureType")]
        [NativeName("Type.Name", "XrStructureType")]
        [NativeName("Name", "type")]
        public StructureType Type;
/// <summary></summary>
        [NativeName("Type", "void*")]
        [NativeName("Type.Name", "void")]
        [NativeName("Name", "next")]
        public void* Next;
/// <summary></summary>
        [NativeName("Type", "XrBool32")]
        [NativeName("Type.Name", "XrBool32")]
        [NativeName("Name", "supportsHandTrackingMesh")]
        public uint SupportsHandTrackingMesh;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "maxHandMeshIndexCount")]
        public uint MaxHandMeshIndexCount;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "maxHandMeshVertexCount")]
        public uint MaxHandMeshVertexCount;
    }
}