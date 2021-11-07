// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Holographic.HolographicFramePresentResult
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Graphics.Holographic
{
  /// <summary>Indicates the outcome of a Present call on a holographic frame.</summary>
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  public enum HolographicFramePresentResult
  {
    /// <summary>The frame was presented successfully.</summary>
    Success,
    /// <summary>The Direct3D 11 device was removed and a new device is required. To investigate the cause of device removed errors, call the ID3D11Device::GetDeviceRemovedReason method before releasing the Direct3D device. Set the new device by calling the HolographicSpace::SetDirect3D11Device method.</summary>
    DeviceRemoved,
  }
}
