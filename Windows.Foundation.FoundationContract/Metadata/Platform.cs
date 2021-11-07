// Decompiled with JetBrains decompiler
// Type: Windows.Foundation.Metadata.Platform
// Assembly: Windows.Foundation.FoundationContract, Version=4.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 340999F0-93F9-406F-A02A-E1F4CFB68771
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.FoundationContract.winmd

namespace Windows.Foundation.Metadata
{
  /// <summary>Specifies the platforms that a specified type should be supported in, as used by Windows Runtime attributes and metadata.</summary>
  [ContractVersion(typeof (FoundationContract), 65536)]
  public enum Platform
  {
    /// <summary>For use by Windows metadata.</summary>
    Windows,
    /// <summary>For use by Windows Phone metadata.</summary>
    WindowsPhone,
  }
}
