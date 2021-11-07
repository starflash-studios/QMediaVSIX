// Decompiled with JetBrains decompiler
// Type: Windows.Media.Protection.PlayReady.NDCustomData
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Protection.PlayReady
{
  /// <summary>Contains the custom data for one of the following PlayReady-ND messages: Registration Challenge, Registration Response, License Fetch Challenge, or License Fetch Response.</summary>
  /// <deprecated type="deprecate">NDCustomData is deprecated and might not work on all platforms. For more info, see MSDN.</deprecated>
  [Activatable(typeof (INDCustomDataFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  [Deprecated("NDCustomData is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 196608, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class NDCustomData : INDCustomData
  {
    /// <summary>Creates a new instance of the NDCustomData class.</summary>
    /// <deprecated type="deprecate">INDCustomDataFactory is deprecated and might not work on all platforms. For more info, see MSDN.</deprecated>
    /// <param name="customDataTypeIDBytes">The type identifier for the custom data. Only a type identifier that is exactly 16 bytes in size is supported.</param>
    /// <param name="customDataBytes">The custom data.</param>
    [Deprecated("INDCustomDataFactory is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 196608, "Windows.Foundation.UniversalApiContract")]
    [MethodImpl]
    public extern NDCustomData(byte[] customDataTypeIDBytes, byte[] customDataBytes);

    /// <summary>Gets the 16-byte type identifier for the custom data.</summary>
    /// <returns>The custom data type identifier.</returns>
    public extern byte[] CustomDataTypeID { [Deprecated("INDCustomData is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 196608, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }

    /// <summary>Gets the custom data.</summary>
    /// <returns>The byte array that contains the custom data.</returns>
    public extern byte[] CustomData { [Deprecated("INDCustomData is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 196608, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }
  }
}
