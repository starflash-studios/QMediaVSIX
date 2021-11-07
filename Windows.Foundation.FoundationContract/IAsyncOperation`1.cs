// Decompiled with JetBrains decompiler
// Type: Windows.Foundation.IAsyncOperation`1
// Assembly: Windows.Foundation.FoundationContract, Version=4.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 340999F0-93F9-406F-A02A-E1F4CFB68771
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.FoundationContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation.Metadata;

namespace Windows.Foundation
{
  /// <summary>Represents an asynchronous operation, which returns a result upon completion. This is the return type for many Windows Runtime asynchronous methods that have results but don't report progress.</summary>
  /// <typeparam name="TResult">
  /// </typeparam>
  [Guid(2680336571, 58438, 17634, 170, 97, 156, 171, 143, 99, 106, 242)]
  [ContractVersion(typeof (FoundationContract), 65536)]
  public interface IAsyncOperation<TResult> : IAsyncInfo
  {
    /// <summary>Gets or sets the method that handles the operation completed notification.</summary>
    /// <returns>The method that handles the notification.</returns>
    AsyncOperationCompletedHandler<TResult> Completed { [MethodImpl] set; [MethodImpl] get; }

    /// <summary>Returns the results of the operation.</summary>
    /// <returns>The results of the operation.</returns>
    [MethodImpl]
    TResult GetResults();
  }
}
