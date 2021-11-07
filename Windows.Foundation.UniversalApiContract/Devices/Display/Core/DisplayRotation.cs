// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Display.Core.DisplayRotation
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Display.Core
{
  /// <summary>Defines constants that specify how to rotate content from a frame buffer to a target.</summary>
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  public enum DisplayRotation
  {
    /// <summary>Specifies no rotation.</summary>
    None,
    /// <summary>Specifies a rotation of 90 degrees clockwise.</summary>
    Clockwise90Degrees,
    /// <summary>Specifies a rotation of 180 degrees clockwise.</summary>
    Clockwise180Degrees,
    /// <summary>Specifies a rotation of 270 degrees clockwise.</summary>
    Clockwise270Degrees,
  }
}
