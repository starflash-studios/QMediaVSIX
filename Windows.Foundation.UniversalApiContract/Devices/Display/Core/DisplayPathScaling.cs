// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Display.Core.DisplayPathScaling
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Display.Core
{
  /// <summary>Defines constants that specify how to scale content from a frame buffer to a target.</summary>
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  public enum DisplayPathScaling
  {
    /// <summary>Indicates that content should not be stretched at all. This is only applicable if the source and target resolutions are identical.</summary>
    Identity,
    /// <summary>Indicates that content should be centered within the target resolution, with no scaling. Any unoccupied space is rendered as black pixels.</summary>
    Centered,
    /// <summary>Indicates that content should be stretched to the exact target resolution.</summary>
    Stretched,
    /// <summary>Indicates that content should be stretched to fit within the target resolution, but without changing the source aspect ratio. Any unoccupied space is rendered as black pixels.</summary>
    AspectRatioStretched,
    /// <summary>Reserved for future use.</summary>
    Custom,
    /// <summary>Indicates that the driver should determine how to scale the content.</summary>
    DriverPreferred,
  }
}
