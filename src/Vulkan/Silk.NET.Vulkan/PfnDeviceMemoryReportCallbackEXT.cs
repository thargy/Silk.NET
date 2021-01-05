using System;
using Silk.NET.Core.Native;

namespace Silk.NET.Vulkan
{
    public readonly unsafe struct PfnDeviceMemoryReportCallbackEXT
    {
        private readonly void* _handle;

        public delegate* unmanaged[Cdecl]<DeviceMemoryReportCallbackDataEXT*, void*, void*> Handle =>
            (delegate* unmanaged[Cdecl]<DeviceMemoryReportCallbackDataEXT*, void*, void*>) _handle;

        public PfnDeviceMemoryReportCallbackEXT
            (delegate* unmanaged[Cdecl]<DeviceMemoryReportCallbackDataEXT*, void*, void*> ptr) => _handle = ptr;

        public static implicit operator nint(PfnDeviceMemoryReportCallbackEXT pfn) => (nint) pfn.Handle;

        public PfnDeviceMemoryReportCallbackEXT
            (AllocationFunction func) => _handle =
            (delegate* unmanaged[Cdecl]<DeviceMemoryReportCallbackDataEXT*, void*, void*>) SilkMarshal.DelegateToPtr
                (func);

        public static implicit operator delegate* unmanaged[Cdecl]<DeviceMemoryReportCallbackDataEXT*, void*, void*>
            (PfnDeviceMemoryReportCallbackEXT pfn) => pfn.Handle;

        public static implicit operator PfnDeviceMemoryReportCallbackEXT
            (delegate* unmanaged[Cdecl]<DeviceMemoryReportCallbackDataEXT*, void*, void*> func) => new(func);

        public static implicit operator PfnDeviceMemoryReportCallbackEXT(AllocationFunction func) => new(func);

        public static explicit operator AllocationFunction
            (PfnDeviceMemoryReportCallbackEXT pfn) => SilkMarshal.PtrToDelegate<AllocationFunction>((nint) pfn.Handle);
    }
}
