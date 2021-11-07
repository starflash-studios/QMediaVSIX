// Decompiled with JetBrains decompiler
// Type: Windows.Foundation.AsyncStatus
// Assembly: Windows.Foundation.FoundationContract, Version=4.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 340999F0-93F9-406F-A02A-E1F4CFB68771
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.FoundationContract.winmd

using Windows.Foundation.Metadata;

namespace Windows.Foundation
{
  /// <summary>Specifies the status of an asynchronous operation.</summary>
  [ContractVersion(typeof (FoundationContract), 65536)]
  public enum AsyncStatus
  {
    /// <summary>The operation has started.</summary>
    Started,
    /// <summary>The operation has completed.</summary>
    Completed,
    /// <summary>The operation was canceled.</summary>
    Canceled,
    /// <summary>The operation has encountered an error.</summary>
    Error,
  }
}
