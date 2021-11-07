// Decompiled with JetBrains decompiler
// Type: Windows.Devices.AllJoyn.AllJoynTrafficType
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.AllJoyn
{
  /// <summary>Defines values used to indicate the type of data carried in session traffic.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Deprecated("AllJoynTrafficType has been deprecated.  For more info, see MSDN.", DeprecationType.Deprecate, 786432, "Windows.Foundation.UniversalApiContract")]
  public enum AllJoynTrafficType
  {
    /// <summary>Traffic type currently unknown.</summary>
    Unknown = 0,
    /// <summary>Message traffic.</summary>
    Messages = 1,
    /// <summary>Unreliable (lossy) byte stream.</summary>
    RawUnreliable = 2,
    /// <summary>Session carries a reliable byte stream.</summary>
    RawReliable = 4,
  }
}
