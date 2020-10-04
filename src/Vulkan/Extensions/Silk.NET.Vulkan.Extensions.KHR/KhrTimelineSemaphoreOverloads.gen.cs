// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.Vulkan.Extensions.KHR
{
    public static class KhrTimelineSemaphoreOverloads
    {
        /// <summary>To be added.</summary>
        public static unsafe Result GetSemaphoreCounterValue(this KhrTimelineSemaphore thisApi, [Count(Count = 0)] Device device, [Count(Count = 0)] Semaphore semaphore, [Count(Count = 0), Flow(FlowDirection.Out)] Span<ulong> pValue)
        {
            // SpanOverloader
            return thisApi.GetSemaphoreCounterValue(device, semaphore, out pValue.GetPinnableReference());
        }

        /// <summary>To be added.</summary>
        public static unsafe Result SignalSemaphore(this KhrTimelineSemaphore thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] ReadOnlySpan<SemaphoreSignalInfo> pSignalInfo)
        {
            // SpanOverloader
            return thisApi.SignalSemaphore(device, in pSignalInfo.GetPinnableReference());
        }

        /// <summary>To be added.</summary>
        public static unsafe Result WaitSemaphores(this KhrTimelineSemaphore thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] ReadOnlySpan<SemaphoreWaitInfo> pWaitInfo, [Count(Count = 0)] ulong timeout)
        {
            // SpanOverloader
            return thisApi.WaitSemaphores(device, in pWaitInfo.GetPinnableReference(), timeout);
        }

    }
}
