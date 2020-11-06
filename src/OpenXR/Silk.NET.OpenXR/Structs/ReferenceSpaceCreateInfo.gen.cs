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
    [NativeName("Name", "XrReferenceSpaceCreateInfo")]
    public unsafe partial struct ReferenceSpaceCreateInfo
    {
        public ReferenceSpaceCreateInfo
        (
            StructureType? type = StructureType.TypeReferenceSpaceCreateInfo,
            void* next = null,
            ReferenceSpaceType? referenceSpaceType = null,
            Posef? poseInReferenceSpace = null
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

            if (referenceSpaceType is not null)
            {
                ReferenceSpaceType = referenceSpaceType.Value;
            }

            if (poseInReferenceSpace is not null)
            {
                PoseInReferenceSpace = poseInReferenceSpace.Value;
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
        [NativeName("Type", "XrReferenceSpaceType")]
        [NativeName("Type.Name", "XrReferenceSpaceType")]
        [NativeName("Name", "referenceSpaceType")]
        public ReferenceSpaceType ReferenceSpaceType;
/// <summary></summary>
        [NativeName("Type", "XrPosef")]
        [NativeName("Type.Name", "XrPosef")]
        [NativeName("Name", "poseInReferenceSpace")]
        public Posef PoseInReferenceSpace;
    }
}