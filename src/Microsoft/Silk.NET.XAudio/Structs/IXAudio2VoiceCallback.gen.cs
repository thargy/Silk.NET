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

namespace Silk.NET.XAudio
{
    [NativeName("Name", "IXAudio2VoiceCallback")]
    public unsafe partial struct IXAudio2VoiceCallback
    {
        public IXAudio2VoiceCallback
        (
            void** lpVtbl = null
        ) : this()
        {
            if (lpVtbl is not null)
            {
                LpVtbl = lpVtbl;
            }
        }


        [NativeName("Type", "")]
        [NativeName("Type.Name", "")]
        [NativeName("Name", "lpVtbl")]
        public void** LpVtbl;
        /// <summary>To be documented.</summary>
        public readonly void OnVoiceProcessingPassStart(uint BytesRequired)
        {
            var @this = (IXAudio2VoiceCallback*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Cdecl]<IXAudio2VoiceCallback*, uint, void>)LpVtbl[0])(@this, BytesRequired);
        }

        /// <summary>To be documented.</summary>
        public readonly void OnVoiceProcessingPassEnd()
        {
            var @this = (IXAudio2VoiceCallback*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Cdecl]<IXAudio2VoiceCallback*, void>)LpVtbl[1])(@this);
        }

        /// <summary>To be documented.</summary>
        public readonly void OnStreamEnd()
        {
            var @this = (IXAudio2VoiceCallback*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Cdecl]<IXAudio2VoiceCallback*, void>)LpVtbl[2])(@this);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void OnBufferStart(void* pBufferContext)
        {
            var @this = (IXAudio2VoiceCallback*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Cdecl]<IXAudio2VoiceCallback*, void*, void>)LpVtbl[3])(@this, pBufferContext);
        }

        /// <summary>To be documented.</summary>
        public readonly void OnBufferStart<T0>(ref T0 pBufferContext) where T0 : unmanaged
        {
            var @this = (IXAudio2VoiceCallback*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (T0* pBufferContextPtr = &pBufferContext)
            {
                ((delegate* unmanaged[Cdecl]<IXAudio2VoiceCallback*, T0*, void>)LpVtbl[3])(@this, pBufferContextPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void OnBufferEnd(void* pBufferContext)
        {
            var @this = (IXAudio2VoiceCallback*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Cdecl]<IXAudio2VoiceCallback*, void*, void>)LpVtbl[4])(@this, pBufferContext);
        }

        /// <summary>To be documented.</summary>
        public readonly void OnBufferEnd<T0>(ref T0 pBufferContext) where T0 : unmanaged
        {
            var @this = (IXAudio2VoiceCallback*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (T0* pBufferContextPtr = &pBufferContext)
            {
                ((delegate* unmanaged[Cdecl]<IXAudio2VoiceCallback*, T0*, void>)LpVtbl[4])(@this, pBufferContextPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void OnLoopEnd(void* pBufferContext)
        {
            var @this = (IXAudio2VoiceCallback*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Cdecl]<IXAudio2VoiceCallback*, void*, void>)LpVtbl[5])(@this, pBufferContext);
        }

        /// <summary>To be documented.</summary>
        public readonly void OnLoopEnd<T0>(ref T0 pBufferContext) where T0 : unmanaged
        {
            var @this = (IXAudio2VoiceCallback*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (T0* pBufferContextPtr = &pBufferContext)
            {
                ((delegate* unmanaged[Cdecl]<IXAudio2VoiceCallback*, T0*, void>)LpVtbl[5])(@this, pBufferContextPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void OnVoiceError(void* pBufferContext, int Error)
        {
            var @this = (IXAudio2VoiceCallback*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Cdecl]<IXAudio2VoiceCallback*, void*, int, void>)LpVtbl[6])(@this, pBufferContext, Error);
        }

        /// <summary>To be documented.</summary>
        public readonly void OnVoiceError<T0>(ref T0 pBufferContext, int Error) where T0 : unmanaged
        {
            var @this = (IXAudio2VoiceCallback*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (T0* pBufferContextPtr = &pBufferContext)
            {
                ((delegate* unmanaged[Cdecl]<IXAudio2VoiceCallback*, T0*, int, void>)LpVtbl[6])(@this, pBufferContextPtr, Error);
            }
        }

    }
}
