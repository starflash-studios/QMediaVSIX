// Decompiled with JetBrains decompiler
// Type: Windows.Media.Protection.PlayReady.NDContentIDType
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Protection.PlayReady
{
  /// <summary>Indicates the types of content that PlayReady can use in different scenarios.</summary>
  /// <deprecated type="deprecate">NDContentIDType is deprecated and might not work on all platforms. For more info, see MSDN.</deprecated>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Deprecated("NDContentIDType is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 196608, "Windows.Foundation.UniversalApiContract")]
  public enum NDContentIDType
  {
    /// <summary>License key identifier.</summary>
    KeyID = 1,
    /// <summary>**PlayReadyObject** can be one of the following two objects.</summary>
    PlayReadyObject = 2,
    /// <summary>Custom object specific to the transmitter. It is expected that the transmitter will understand the data contained therein. PlayReady does not define a standard format for custom content identifiers.</summary>
    Custom = 3,
  }
}
