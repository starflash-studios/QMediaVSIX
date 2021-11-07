// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Display.Core.DisplayDeviceCapability
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Display.Core
{
  /// <summary>Defines constants that specify a capability of a DisplayDevice.</summary>
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  public enum DisplayDeviceCapability
  {
    /// <summary>Indicates that presenting content with a sync interval of zero cancels any pending flips, and instead schedules the content to be flipped on the next V-blank interrupt.</summary>
    FlipOverride,
  }
}
