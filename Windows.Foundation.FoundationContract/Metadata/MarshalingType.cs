// Decompiled with JetBrains decompiler
// Type: Windows.Foundation.Metadata.MarshalingType
// Assembly: Windows.Foundation.FoundationContract, Version=4.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 340999F0-93F9-406F-A02A-E1F4CFB68771
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.FoundationContract.winmd

namespace Windows.Foundation.Metadata
{
  /// <summary>Specifies the marshaling type for the class.</summary>
  [ContractVersion(typeof (FoundationContract), 65536)]
  public enum MarshalingType
  {
    /// <summary>The class can't be marshaled.</summary>
    InvalidMarshaling,
    /// <summary>The class prevents marshaling on all interfaces.</summary>
    None,
    /// <summary>The class marshals and unmarshals to the same pointer value on all interfaces.</summary>
    Agile,
    /// <summary>The class does not implement IMarshal or forwards to CoGetStandardMarshal on all interfaces.</summary>
    Standard,
  }
}
