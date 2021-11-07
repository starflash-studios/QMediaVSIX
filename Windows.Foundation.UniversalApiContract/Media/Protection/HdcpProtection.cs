// Decompiled with JetBrains decompiler
// Type: Windows.Media.Protection.HdcpProtection
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Protection
{
  /// <summary>Describes the level of protection of an HdcpSession instance.</summary>
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  public enum HdcpProtection
  {
    /// <summary>HDCP is off.</summary>
    Off,
    /// <summary>HDCP is on.</summary>
    On,
    /// <summary>HDCP is on with type enforcement (other connected devices/monitors, besides the one that the content is running on, have HDCP required).</summary>
    OnWithTypeEnforcement,
  }
}
