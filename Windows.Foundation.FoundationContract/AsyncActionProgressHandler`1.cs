// Decompiled with JetBrains decompiler
// Type: Windows.Foundation.AsyncActionProgressHandler`1
// Assembly: Windows.Foundation.FoundationContract, Version=4.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 340999F0-93F9-406F-A02A-E1F4CFB68771
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.FoundationContract.winmd

using Windows.Foundation.Metadata;

namespace Windows.Foundation
{
  /// <summary>Represents a method that handles progress update events of an asynchronous action that provides progress updates.</summary>
  /// <typeparam name="TProgress">
  /// </typeparam>
  /// <param name="asyncInfo">The asynchronous action.</param>
  /// <param name="progressInfo">The progress information.</param>
  [Guid(1837385816, 3327, 17808, 174, 137, 149, 165, 165, 200, 180, 184)]
  [ContractVersion(typeof (FoundationContract), 65536)]
  public delegate void AsyncActionProgressHandler<TProgress>(
    IAsyncActionWithProgress<TProgress> asyncInfo,
    TProgress progressInfo);
}
