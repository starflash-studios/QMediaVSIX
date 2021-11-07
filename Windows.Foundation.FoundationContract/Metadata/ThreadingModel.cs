// Decompiled with JetBrains decompiler
// Type: Windows.Foundation.Metadata.ThreadingModel
// Assembly: Windows.Foundation.FoundationContract, Version=4.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 340999F0-93F9-406F-A02A-E1F4CFB68771
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.FoundationContract.winmd

namespace Windows.Foundation.Metadata
{
  /// <summary>Specifies the threading model.</summary>
  [ContractVersion(typeof (FoundationContract), 65536)]
  public enum ThreadingModel
  {
    /// <summary>No valid threading model applies.</summary>
    InvalidThreading,
    /// <summary>Single-threaded apartment.</summary>
    STA,
    /// <summary>Multithreaded apartment.</summary>
    MTA,
    /// <summary>Both single-threaded and multithreaded apartments.</summary>
    Both,
  }
}
