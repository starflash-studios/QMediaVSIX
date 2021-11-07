// Decompiled with JetBrains decompiler
// Type: Windows.Foundation.AsyncOperationCompletedHandler`1
// Assembly: Windows.Foundation.FoundationContract, Version=4.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 340999F0-93F9-406F-A02A-E1F4CFB68771
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.FoundationContract.winmd

using Windows.Foundation.Metadata;

namespace Windows.Foundation
{
  /// <summary>Represents a method that handles the completed event of an asynchronous operation.</summary>
  /// <typeparam name="TResult">
  /// </typeparam>
  /// <param name="asyncInfo">The asynchronous operation.</param>
  /// <param name="asyncStatus">One of the enumeration values.</param>
  [Guid(4242337836, 58840, 17528, 145, 90, 77, 144, 183, 75, 131, 165)]
  [ContractVersion(typeof (FoundationContract), 65536)]
  public delegate void AsyncOperationCompletedHandler<TResult>(
    IAsyncOperation<TResult> asyncInfo,
    AsyncStatus asyncStatus);
}
