// Decompiled with JetBrains decompiler
// Type: Windows.Foundation.HResult
// Assembly: Windows.Foundation.FoundationContract, Version=4.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 340999F0-93F9-406F-A02A-E1F4CFB68771
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.FoundationContract.winmd

using Windows.Foundation.Metadata;

namespace Windows.Foundation
{
  /// <summary>Represents a Windows Runtime error.</summary>
  [ContractVersion(typeof (FoundationContract), 65536)]
  public struct HResult
  {
    /// <summary>An integer that describes an error.</summary>
    public int Value;
  }
}
