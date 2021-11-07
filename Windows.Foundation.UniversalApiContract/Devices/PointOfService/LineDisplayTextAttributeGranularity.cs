// Decompiled with JetBrains decompiler
// Type: Windows.Devices.PointOfService.LineDisplayTextAttributeGranularity
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.PointOfService
{
  /// <summary>Defines the constants that indicate whether the line display supports blinking or reversing the display.</summary>
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  public enum LineDisplayTextAttributeGranularity
  {
    /// <summary>The feature is not supported.</summary>
    NotSupported,
    /// <summary>The feature is supported for the entire display.</summary>
    EntireDisplay,
    /// <summary>The feature is supported for individual characters.</summary>
    PerCharacter,
  }
}
