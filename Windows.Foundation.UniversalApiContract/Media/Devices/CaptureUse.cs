// Decompiled with JetBrains decompiler
// Type: Windows.Media.Devices.CaptureUse
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Devices
{
  /// <summary>Defines the values for the primary use of the capture device.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum CaptureUse
  {
    /// <summary>The capture device does not have a primary use.</summary>
    None,
    /// <summary>The capture device is used primarily for photos.</summary>
    Photo,
    /// <summary>The capture device is used primarily for video.</summary>
    Video,
  }
}
