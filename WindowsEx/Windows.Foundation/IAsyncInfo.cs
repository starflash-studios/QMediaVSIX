// Decompiled with JetBrains decompiler
// Type: Windows.Foundation.IAsyncInfo
// Assembly: Windows.Foundation.FoundationContract, Version=4.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 340999F0-93F9-406F-A02A-E1F4CFB68771
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.FoundationContract.winmd
// Compiler-generated code is shown

using System;
using System.Runtime.CompilerServices;

using Windows.Foundation.Metadata;

namespace Windows.Foundation {
    /// <summary>Supports asynchronous actions and operations. IAsyncInfo is a base interface for IAsyncAction, IAsyncActionWithProgress&lt;TProgress&gt;, IAsyncOperation&lt;TResult&gt; and IAsyncOperationWithProgress&lt;TResult,TProgress&gt;, each of which support combinations of return type and progress for an asynchronous method.</summary>
    [Guid(54U, 0, 0, 192, 0, 0, 0, 0, 0, 0, 70)]
    [ContractVersion(typeof(FoundationContract), 65536U)]
    public interface IAsyncInfo {
        /// <summary>Gets the handle of the asynchronous operation.</summary>
        /// <returns>The handle of the asynchronous operation.</returns>
        uint Id { [MethodImpl] get; }
        /// <summary>Gets a value that indicates the status of the asynchronous operation.</summary>
        /// <returns>The status of the operation, as a value of the enumeration. A value of **Completed** indicates that the method has returned. The **Started** value represents a transition state before any of the other 3 final results (**Completed**, **Error**, **Cancelled**) can be determined by the method's invocation.</returns>
        AsyncStatus Status { [MethodImpl] get; }
        /// <summary>Gets a string that describes an error condition of the asynchronous operation.</summary>
        /// <returns>The error string.</returns>
        Exception ErrorCode { [MethodImpl] get; }
        /// <summary>Cancels the asynchronous operation.</summary>
        [MethodImpl]
        void Cancel();
        /// <summary>Closes the asynchronous operation.</summary>
        [MethodImpl]
        void Close();
    }
}
