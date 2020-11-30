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

namespace Silk.NET.Direct3D11
{
    [Guid("6543dbb6-1b48-42f5-ab82-e97ec74326f6")]
    [NativeName("Name", "ID3D11InfoQueue")]
    public unsafe partial struct ID3D11InfoQueue
    {
        public static implicit operator Silk.NET.Core.Native.IUnknown(ID3D11InfoQueue val)
            => Unsafe.As<ID3D11InfoQueue, Silk.NET.Core.Native.IUnknown>(ref val);

        public ID3D11InfoQueue
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
        /// <summary>To be added.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, void** ppvObject)
        {
            var @this = (ID3D11InfoQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ID3D11InfoQueue*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (ID3D11InfoQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D11InfoQueue*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (ID3D11InfoQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D11InfoQueue*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (ID3D11InfoQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D11InfoQueue*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly uint AddRef()
        {
            var @this = (ID3D11InfoQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ID3D11InfoQueue*, uint>)LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly uint Release()
        {
            var @this = (ID3D11InfoQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ID3D11InfoQueue*, uint>)LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly int SetMessageCountLimit(ulong MessageCountLimit)
        {
            var @this = (ID3D11InfoQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ID3D11InfoQueue*, ulong, int>)LpVtbl[3])(@this, MessageCountLimit);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly void ClearStoredMessages()
        {
            var @this = (ID3D11InfoQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Cdecl]<ID3D11InfoQueue*, void>)LpVtbl[4])(@this);
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int GetMessageA(ulong MessageIndex, Message* pMessage, uint* pMessageByteLength)
        {
            var @this = (ID3D11InfoQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ID3D11InfoQueue*, ulong, Message*, uint*, int>)LpVtbl[5])(@this, MessageIndex, pMessage, pMessageByteLength);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int GetMessageA(ulong MessageIndex, Message* pMessage, ref uint pMessageByteLength)
        {
            var @this = (ID3D11InfoQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (uint* pMessageByteLengthPtr = &pMessageByteLength)
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D11InfoQueue*, ulong, Message*, uint*, int>)LpVtbl[5])(@this, MessageIndex, pMessage, pMessageByteLengthPtr);
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int GetMessageA(ulong MessageIndex, ref Message pMessage, uint* pMessageByteLength)
        {
            var @this = (ID3D11InfoQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (Message* pMessagePtr = &pMessage)
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D11InfoQueue*, ulong, Message*, uint*, int>)LpVtbl[5])(@this, MessageIndex, pMessagePtr, pMessageByteLength);
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly int GetMessageA(ulong MessageIndex, ref Message pMessage, ref uint pMessageByteLength)
        {
            var @this = (ID3D11InfoQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (Message* pMessagePtr = &pMessage)
            {
                fixed (uint* pMessageByteLengthPtr = &pMessageByteLength)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D11InfoQueue*, ulong, Message*, uint*, int>)LpVtbl[5])(@this, MessageIndex, pMessagePtr, pMessageByteLengthPtr);
                }
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly ulong GetNumMessagesAllowedByStorageFilter()
        {
            var @this = (ID3D11InfoQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                ulong ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ID3D11InfoQueue*, ulong>)LpVtbl[6])(@this);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly ulong GetNumMessagesDeniedByStorageFilter()
        {
            var @this = (ID3D11InfoQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                ulong ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ID3D11InfoQueue*, ulong>)LpVtbl[7])(@this);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly ulong GetNumStoredMessages()
        {
            var @this = (ID3D11InfoQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                ulong ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ID3D11InfoQueue*, ulong>)LpVtbl[8])(@this);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly ulong GetNumStoredMessagesAllowedByRetrievalFilter()
        {
            var @this = (ID3D11InfoQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                ulong ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ID3D11InfoQueue*, ulong>)LpVtbl[9])(@this);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly ulong GetNumMessagesDiscardedByMessageCountLimit()
        {
            var @this = (ID3D11InfoQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                ulong ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ID3D11InfoQueue*, ulong>)LpVtbl[10])(@this);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly ulong GetMessageCountLimit()
        {
            var @this = (ID3D11InfoQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                ulong ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ID3D11InfoQueue*, ulong>)LpVtbl[11])(@this);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int AddStorageFilterEntries(InfoQueueFilter* pFilter)
        {
            var @this = (ID3D11InfoQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ID3D11InfoQueue*, InfoQueueFilter*, int>)LpVtbl[12])(@this, pFilter);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly int AddStorageFilterEntries(ref InfoQueueFilter pFilter)
        {
            var @this = (ID3D11InfoQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (InfoQueueFilter* pFilterPtr = &pFilter)
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D11InfoQueue*, InfoQueueFilter*, int>)LpVtbl[12])(@this, pFilterPtr);
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int GetStorageFilter(InfoQueueFilter* pFilter, uint* pFilterByteLength)
        {
            var @this = (ID3D11InfoQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ID3D11InfoQueue*, InfoQueueFilter*, uint*, int>)LpVtbl[13])(@this, pFilter, pFilterByteLength);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int GetStorageFilter(InfoQueueFilter* pFilter, ref uint pFilterByteLength)
        {
            var @this = (ID3D11InfoQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (uint* pFilterByteLengthPtr = &pFilterByteLength)
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D11InfoQueue*, InfoQueueFilter*, uint*, int>)LpVtbl[13])(@this, pFilter, pFilterByteLengthPtr);
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int GetStorageFilter(ref InfoQueueFilter pFilter, uint* pFilterByteLength)
        {
            var @this = (ID3D11InfoQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (InfoQueueFilter* pFilterPtr = &pFilter)
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D11InfoQueue*, InfoQueueFilter*, uint*, int>)LpVtbl[13])(@this, pFilterPtr, pFilterByteLength);
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly int GetStorageFilter(ref InfoQueueFilter pFilter, ref uint pFilterByteLength)
        {
            var @this = (ID3D11InfoQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (InfoQueueFilter* pFilterPtr = &pFilter)
            {
                fixed (uint* pFilterByteLengthPtr = &pFilterByteLength)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D11InfoQueue*, InfoQueueFilter*, uint*, int>)LpVtbl[13])(@this, pFilterPtr, pFilterByteLengthPtr);
                }
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly void ClearStorageFilter()
        {
            var @this = (ID3D11InfoQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Cdecl]<ID3D11InfoQueue*, void>)LpVtbl[14])(@this);
        }

        /// <summary>To be added.</summary>
        public readonly int PushEmptyStorageFilter()
        {
            var @this = (ID3D11InfoQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ID3D11InfoQueue*, int>)LpVtbl[15])(@this);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly int PushCopyOfStorageFilter()
        {
            var @this = (ID3D11InfoQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ID3D11InfoQueue*, int>)LpVtbl[16])(@this);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int PushStorageFilter(InfoQueueFilter* pFilter)
        {
            var @this = (ID3D11InfoQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ID3D11InfoQueue*, InfoQueueFilter*, int>)LpVtbl[17])(@this, pFilter);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly int PushStorageFilter(ref InfoQueueFilter pFilter)
        {
            var @this = (ID3D11InfoQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (InfoQueueFilter* pFilterPtr = &pFilter)
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D11InfoQueue*, InfoQueueFilter*, int>)LpVtbl[17])(@this, pFilterPtr);
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly void PopStorageFilter()
        {
            var @this = (ID3D11InfoQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Cdecl]<ID3D11InfoQueue*, void>)LpVtbl[18])(@this);
        }

        /// <summary>To be added.</summary>
        public readonly uint GetStorageFilterStackSize()
        {
            var @this = (ID3D11InfoQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ID3D11InfoQueue*, uint>)LpVtbl[19])(@this);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int AddRetrievalFilterEntries(InfoQueueFilter* pFilter)
        {
            var @this = (ID3D11InfoQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ID3D11InfoQueue*, InfoQueueFilter*, int>)LpVtbl[20])(@this, pFilter);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly int AddRetrievalFilterEntries(ref InfoQueueFilter pFilter)
        {
            var @this = (ID3D11InfoQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (InfoQueueFilter* pFilterPtr = &pFilter)
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D11InfoQueue*, InfoQueueFilter*, int>)LpVtbl[20])(@this, pFilterPtr);
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int GetRetrievalFilter(InfoQueueFilter* pFilter, uint* pFilterByteLength)
        {
            var @this = (ID3D11InfoQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ID3D11InfoQueue*, InfoQueueFilter*, uint*, int>)LpVtbl[21])(@this, pFilter, pFilterByteLength);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int GetRetrievalFilter(InfoQueueFilter* pFilter, ref uint pFilterByteLength)
        {
            var @this = (ID3D11InfoQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (uint* pFilterByteLengthPtr = &pFilterByteLength)
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D11InfoQueue*, InfoQueueFilter*, uint*, int>)LpVtbl[21])(@this, pFilter, pFilterByteLengthPtr);
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int GetRetrievalFilter(ref InfoQueueFilter pFilter, uint* pFilterByteLength)
        {
            var @this = (ID3D11InfoQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (InfoQueueFilter* pFilterPtr = &pFilter)
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D11InfoQueue*, InfoQueueFilter*, uint*, int>)LpVtbl[21])(@this, pFilterPtr, pFilterByteLength);
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly int GetRetrievalFilter(ref InfoQueueFilter pFilter, ref uint pFilterByteLength)
        {
            var @this = (ID3D11InfoQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (InfoQueueFilter* pFilterPtr = &pFilter)
            {
                fixed (uint* pFilterByteLengthPtr = &pFilterByteLength)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D11InfoQueue*, InfoQueueFilter*, uint*, int>)LpVtbl[21])(@this, pFilterPtr, pFilterByteLengthPtr);
                }
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly void ClearRetrievalFilter()
        {
            var @this = (ID3D11InfoQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Cdecl]<ID3D11InfoQueue*, void>)LpVtbl[22])(@this);
        }

        /// <summary>To be added.</summary>
        public readonly int PushEmptyRetrievalFilter()
        {
            var @this = (ID3D11InfoQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ID3D11InfoQueue*, int>)LpVtbl[23])(@this);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly int PushCopyOfRetrievalFilter()
        {
            var @this = (ID3D11InfoQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ID3D11InfoQueue*, int>)LpVtbl[24])(@this);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int PushRetrievalFilter(InfoQueueFilter* pFilter)
        {
            var @this = (ID3D11InfoQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ID3D11InfoQueue*, InfoQueueFilter*, int>)LpVtbl[25])(@this, pFilter);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly int PushRetrievalFilter(ref InfoQueueFilter pFilter)
        {
            var @this = (ID3D11InfoQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (InfoQueueFilter* pFilterPtr = &pFilter)
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D11InfoQueue*, InfoQueueFilter*, int>)LpVtbl[25])(@this, pFilterPtr);
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly void PopRetrievalFilter()
        {
            var @this = (ID3D11InfoQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Cdecl]<ID3D11InfoQueue*, void>)LpVtbl[26])(@this);
        }

        /// <summary>To be added.</summary>
        public readonly uint GetRetrievalFilterStackSize()
        {
            var @this = (ID3D11InfoQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ID3D11InfoQueue*, uint>)LpVtbl[27])(@this);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int AddMessage(MessageCategory Category, MessageSeverity Severity, MessageID ID, byte* pDescription)
        {
            var @this = (ID3D11InfoQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ID3D11InfoQueue*, MessageCategory, MessageSeverity, MessageID, byte*, int>)LpVtbl[28])(@this, Category, Severity, ID, pDescription);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly int AddMessage(MessageCategory Category, MessageSeverity Severity, MessageID ID, ref byte pDescription)
        {
            var @this = (ID3D11InfoQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (byte* pDescriptionPtr = &pDescription)
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D11InfoQueue*, MessageCategory, MessageSeverity, MessageID, byte*, int>)LpVtbl[28])(@this, Category, Severity, ID, pDescriptionPtr);
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly int AddMessage(MessageCategory Category, MessageSeverity Severity, MessageID ID, string pDescription)
        {
            var @this = (ID3D11InfoQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            var pDescriptionPtr = (byte*) Marshal.StringToHGlobalAnsi(pDescription);
            ret = ((delegate* unmanaged[Cdecl]<ID3D11InfoQueue*, MessageCategory, MessageSeverity, MessageID, byte*, int>)LpVtbl[28])(@this, Category, Severity, ID, pDescriptionPtr);
            Marshal.FreeHGlobal((IntPtr)pDescriptionPtr);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int AddApplicationMessage(MessageSeverity Severity, byte* pDescription)
        {
            var @this = (ID3D11InfoQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ID3D11InfoQueue*, MessageSeverity, byte*, int>)LpVtbl[29])(@this, Severity, pDescription);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly int AddApplicationMessage(MessageSeverity Severity, ref byte pDescription)
        {
            var @this = (ID3D11InfoQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (byte* pDescriptionPtr = &pDescription)
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D11InfoQueue*, MessageSeverity, byte*, int>)LpVtbl[29])(@this, Severity, pDescriptionPtr);
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly int AddApplicationMessage(MessageSeverity Severity, string pDescription)
        {
            var @this = (ID3D11InfoQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            var pDescriptionPtr = (byte*) Marshal.StringToHGlobalAnsi(pDescription);
            ret = ((delegate* unmanaged[Cdecl]<ID3D11InfoQueue*, MessageSeverity, byte*, int>)LpVtbl[29])(@this, Severity, pDescriptionPtr);
            Marshal.FreeHGlobal((IntPtr)pDescriptionPtr);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly int SetBreakOnCategory(MessageCategory Category, int bEnable)
        {
            var @this = (ID3D11InfoQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ID3D11InfoQueue*, MessageCategory, int, int>)LpVtbl[30])(@this, Category, bEnable);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly int SetBreakOnSeverity(MessageSeverity Severity, int bEnable)
        {
            var @this = (ID3D11InfoQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ID3D11InfoQueue*, MessageSeverity, int, int>)LpVtbl[31])(@this, Severity, bEnable);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly int SetBreakOnID(MessageID ID, int bEnable)
        {
            var @this = (ID3D11InfoQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ID3D11InfoQueue*, MessageID, int, int>)LpVtbl[32])(@this, ID, bEnable);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly int GetBreakOnCategory(MessageCategory Category)
        {
            var @this = (ID3D11InfoQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ID3D11InfoQueue*, MessageCategory, int>)LpVtbl[33])(@this, Category);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly int GetBreakOnSeverity(MessageSeverity Severity)
        {
            var @this = (ID3D11InfoQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ID3D11InfoQueue*, MessageSeverity, int>)LpVtbl[34])(@this, Severity);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly int GetBreakOnID(MessageID ID)
        {
            var @this = (ID3D11InfoQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ID3D11InfoQueue*, MessageID, int>)LpVtbl[35])(@this, ID);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly void SetMuteDebugOutput(int bMute)
        {
            var @this = (ID3D11InfoQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Cdecl]<ID3D11InfoQueue*, int, void>)LpVtbl[36])(@this, bMute);
        }

        /// <summary>To be added.</summary>
        public readonly int GetMuteDebugOutput()
        {
            var @this = (ID3D11InfoQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ID3D11InfoQueue*, int>)LpVtbl[37])(@this);
            return ret;
        }

    }
}