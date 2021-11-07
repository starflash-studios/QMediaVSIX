// Decompiled with JetBrains decompiler
// Type: Windows.Media.Protection.PlayReady.INDCustomData
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Protection.PlayReady
{
  /// <summary>Contains the custom data for one of the following PlayReady-ND messages: Registration Challenge, Registration Response, License Fetch Challenge, or License Fetch Response.</summary>
  /// <deprecated type="deprecate">INDCustomData is deprecated and might not work on all platforms. For more info, see MSDN.</deprecated>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Deprecated("INDCustomData is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 196608, "Windows.Foundation.UniversalApiContract")]
  [Guid(4123725788, 11529, 20249, 181, 225, 118, 160, 179, 238, 146, 103)]
  public interface INDCustomData
  {
    /// <summary>Gets the 16-byte type identifier for the custom data.</summary>
    /// <returns>The byte array that contains the custom data type identifier.</returns>
    byte[] CustomDataTypeID { [Deprecated("INDCustomData is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 196608, "Windows.Foundation.UniversalApiContract")] get; }

    /// <summary>Gets the custom data.</summary>
    /// <returns>The byte array that contains the custom data.</returns>
    byte[] CustomData { [Deprecated("INDCustomData is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 196608, "Windows.Foundation.UniversalApiContract")] get; }
  }
}
