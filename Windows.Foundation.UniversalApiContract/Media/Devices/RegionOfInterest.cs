// Decompiled with JetBrains decompiler
// Type: Windows.Media.Devices.RegionOfInterest
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Devices
{
  /// <summary>Represents a region of interest which is a rectangular region on the image which is used for functions such as focus and exposure.</summary>
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 100859904)]
  public sealed class RegionOfInterest : IRegionOfInterest, IRegionOfInterest2
  {
    /// <summary>Creates a new instance of the RegionOfInterest control.</summary>
    [MethodImpl]
    public extern RegionOfInterest();

    /// <summary>Gets or sets a value that specifies if auto focus is enabled.</summary>
    /// <returns>**true** if auto focus is enabled; otherwise, **false**.</returns>
    public extern bool AutoFocusEnabled { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that specifies if auto white balance is enabled.</summary>
    /// <returns>**true** if auto white balance; otherwise, **false**.</returns>
    public extern bool AutoWhiteBalanceEnabled { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that specifies if auto exposure is enabled.</summary>
    /// <returns>**true** if auto exposure is enabled; otherwise, **false**.</returns>
    public extern bool AutoExposureEnabled { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the rectangle that defines the region of focus.</summary>
    /// <returns>The rectangle that defines the region of focus.</returns>
    public extern Rect Bounds { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the type of region represented by the RegionOfInterest object.</summary>
    /// <returns>The type of region represented by the RegionOfInterest object.</returns>
    public extern RegionOfInterestType Type { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value indicating whether the Bounds Rect is in pixels or is mapped to a range of 0 to 1.0.</summary>
    /// <returns>A value indicating whether the Bounds Rect is in pixels or is mapped to a range of 0 to 1.0.</returns>
    public extern bool BoundsNormalized { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the weight of the region of interest.</summary>
    /// <returns>Gets or sets the weight of the region of interest which is a value from 0-100.</returns>
    public extern uint Weight { [MethodImpl] get; [MethodImpl] set; }
  }
}
