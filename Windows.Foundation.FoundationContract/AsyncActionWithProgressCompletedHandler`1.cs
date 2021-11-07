// Decompiled with JetBrains decompiler
// Type: Windows.Foundation.AsyncActionWithProgressCompletedHandler`1
// Assembly: Windows.Foundation.FoundationContract, Version=4.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 340999F0-93F9-406F-A02A-E1F4CFB68771
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.FoundationContract.winmd

using Windows.Foundation.Metadata;

namespace Windows.Foundation
{
  /// <summary>Represents a method that handles the completed event of an asynchronous action that provides progress updates.</summary>
  /// <typeparam name="TProgress">
  /// </typeparam>
  /// <param name="asyncInfo">The asynchronous action.</param>
  /// <param name="asyncStatus">One of the enumeration values.</param>
  [ContractVersion(typeof (FoundationContract), 65536)]
  [Guid(2617417617, 52356, 17661, 172, 38, 10, 108, 78, 85, 82, 129)]
  public delegate void AsyncActionWithProgressCompletedHandler<TProgress>(
    IAsyncActionWithProgress<TProgress> asyncInfo,
    AsyncStatus asyncStatus);
}
