// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Display.Core.HdmiDisplayInformation
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Graphics.Display.Core
{
  /// <summary>Represents a class containing methods which can be used to interact with the display.</summary>
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 167772163)]
  [Static(typeof (IHdmiDisplayInformationStatics), 262144, "Windows.Foundation.UniversalApiContract")]
  public sealed class HdmiDisplayInformation : IHdmiDisplayInformation
  {
    /// <summary>Gets the display modes that are supported by your current display. This is determined in combination by your device type, specifications, and settings.</summary>
    /// <returns>The list of display modes that are supported.</returns>
    [MethodImpl]
    public extern IVectorView<HdmiDisplayMode> GetSupportedDisplayModes();

    /// <summary>Gets the HdmiDisplayMode object, which provides info about the current display mode of a connected device, like a TV.</summary>
    /// <returns>The display mode.</returns>
    [MethodImpl]
    public extern HdmiDisplayMode GetCurrentDisplayMode();

    /// <summary>Sets the display to the back to default settings.</summary>
    /// <returns>
    /// </returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction SetDefaultDisplayModeAsync();

    /// <summary>Sends request to set only the display mode for the display.</summary>
    /// <param name="mode">
    /// </param>
    /// <returns>Value that indicates whether the set request is successful.</returns>
    [Overload("RequestSetCurrentDisplayModeAsync")]
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<bool> RequestSetCurrentDisplayModeAsync(
      HdmiDisplayMode mode);

    /// <summary>Sends request to set only the display mode and HDR option for the display.</summary>
    /// <param name="mode">The display mode.</param>
    /// <param name="hdrOption">The electro-optical transfer function (EOTF) used to master the HDR content.</param>
    /// <returns>Value that indicates whether the set request is successful.</returns>
    [Overload("RequestSetCurrentDisplayModeWithHdrAsync")]
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<bool> RequestSetCurrentDisplayModeAsync(
      HdmiDisplayMode mode,
      HdmiDisplayHdrOption hdrOption);

    /// <summary>Sends request to set the display according to the input parameters.</summary>
    /// <param name="mode">The display mode.</param>
    /// <param name="hdrOption">The electro-optical transfer function (EOTF) used to master the HDR content.</param>
    /// <param name="hdrMetadata">The 10 bit display metadata used to adjust the output.</param>
    /// <returns>Value that indicates whether the set request is successful.</returns>
    [RemoteAsync]
    [Overload("RequestSetCurrentDisplayModeWithHdrAndMetadataAsync")]
    [MethodImpl]
    public extern IAsyncOperation<bool> RequestSetCurrentDisplayModeAsync(
      HdmiDisplayMode mode,
      HdmiDisplayHdrOption hdrOption,
      HdmiDisplayHdr2086Metadata hdrMetadata);

    /// <summary>Event raised when the display mode changes.</summary>
    public extern event TypedEventHandler<HdmiDisplayInformation, object> DisplayModesChanged;

    /// <summary>Gets the HdmiDisplayInformation object which is the display info of a video content that is currently sent to a display, like a TV or monitor.</summary>
    /// <returns>The display info of a video content that's currently on screen.</returns>
    [MethodImpl]
    public static extern HdmiDisplayInformation GetForCurrentView();
  }
}
