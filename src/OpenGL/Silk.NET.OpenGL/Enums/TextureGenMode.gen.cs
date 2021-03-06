// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGL
{
    [NativeName("Name", "TextureGenMode")]
    public enum TextureGenMode : int
    {
        [NativeName("Name", "GL_EYE_DISTANCE_TO_POINT_SGIS")]
        EyeDistanceToPointSgis = 0x81F0,
        [NativeName("Name", "GL_OBJECT_DISTANCE_TO_POINT_SGIS")]
        ObjectDistanceToPointSgis = 0x81F1,
        [NativeName("Name", "GL_EYE_DISTANCE_TO_LINE_SGIS")]
        EyeDistanceToLineSgis = 0x81F2,
        [NativeName("Name", "GL_OBJECT_DISTANCE_TO_LINE_SGIS")]
        ObjectDistanceToLineSgis = 0x81F3,
    }
}
