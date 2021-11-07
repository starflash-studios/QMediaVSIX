// Decompiled with JetBrains decompiler
// Type: Windows.Foundation.IAsyncActionWithProgress`1
// Assembly: Windows.Foundation.FoundationContract, Version=4.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 340999F0-93F9-406F-A02A-E1F4CFB68771
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.FoundationContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation.Metadata;

namespace Windows.Foundation
{
  /// <summary>Represents an asynchronous action that can report progress updates to callers. This is the return type for all Windows Runtime asynchronous methods that don't have a result object, but do report progress to callback listeners.</summary>
  /// <typeparam name="TProgress">
  /// </typeparam>
  [Guid(527282776, 59395, 18593, 149, 70, 235, 115, 83, 57, 136, 132)]
  [ContractVersion(typeof (FoundationContract), 65536)]
  public interface IAsyncActionWithProgress<TProgress> : IAsyncInfo
  {
    /// <summary>Gets or sets the callback method that receives progress notification.</summary>
    /// <returns>A reference to the callback method that handles progress notifications. Implement the AsyncActionProgressHandler(TProgress) delegate to define your callback. *TProgress* defines the progress unit type, which varies by method implementation.</returns>
    AsyncActionProgressHandler<TProgress> Progress { [MethodImpl] set; [MethodImpl] get; }

    /// <summary>Gets or sets the method that handles the action completed notification.</summary>
    /// <returns>The method that handles the notification.</returns>
    AsyncActionWithProgressCompletedHandler<TProgress> Completed { [MethodImpl] set; [MethodImpl] get; }

    /// <summary>Returns the results of the action.</summary>
    [MethodImpl]
    void GetResults();
  }
}
