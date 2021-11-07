// Decompiled with JetBrains decompiler
// Type: Windows.Gaming.Input.Custom.XusbDeviceType
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Gaming.Input.Custom
{
  /// <summary>The device type of the controller.</summary>
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  public enum XusbDeviceType
  {
    /// <summary>The controller device type is unknown.</summary>
    Unknown,
    /// <summary>The controller device type is gamepad.</summary>
    Gamepad,
  }
}
