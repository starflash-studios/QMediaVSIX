// Decompiled with JetBrains decompiler
// Type: Windows.Devices.PointOfService.LineDisplayTextAttribute
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.PointOfService
{
  /// <summary>Defines the constants that indicate whether the line display is reversed or blinking.</summary>
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  public enum LineDisplayTextAttribute
  {
    /// <summary>The display not reverse or blinking (ie. normal).</summary>
    Normal,
    /// <summary>The display is blinking.</summary>
    Blink,
    /// <summary>The display is reversed.</summary>
    Reverse,
    /// <summary>The display is reversed and blinking.</summary>
    ReverseBlink,
  }
}
