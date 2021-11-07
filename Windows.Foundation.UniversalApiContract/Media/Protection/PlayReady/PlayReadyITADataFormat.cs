// Decompiled with JetBrains decompiler
// Type: Windows.Media.Protection.PlayReady.PlayReadyITADataFormat
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Protection.PlayReady
{
  /// <summary>Specifies the format for the ITA serialized data.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum PlayReadyITADataFormat
  {
    /// <summary>Returns the serialized IPropertySet as detailed in the remarks for the PlayReadyITADataGenerator.GenerateData method.</summary>
    SerializedProperties,
    /// <summary>Returns the entire serialized blob including the content protection system **GUID**, the stream count, and the next stream ID block.</summary>
    SerializedProperties_WithContentProtectionWrapper,
  }
}
