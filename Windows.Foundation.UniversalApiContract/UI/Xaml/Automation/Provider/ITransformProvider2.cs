// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.Provider.ITransformProvider2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Automation.Provider
{
  /// <summary>Extends the ITransformProvider interface to enable Microsoft UI Automation providers to expose API to support the viewport zooming functionality of a control.</summary>
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2830178134, 41887, 20119, 140, 125, 193, 234, 141, 214, 51, 197)]
  public interface ITransformProvider2 : ITransformProvider
  {
    /// <summary>Gets a value that indicates whether the control supports zooming of its viewport.</summary>
    /// <returns>**true** if the viewport can be zoomed; otherwise, **false**.</returns>
    bool CanZoom { get; }

    /// <summary>Gets the zoom level of the control's viewport.</summary>
    /// <returns>The zoom level, specified as a percentage. The provider should zoom the viewport to the nearest supported value.</returns>
    double ZoomLevel { get; }

    /// <summary>Gets the maximum zoom level of the element.</summary>
    /// <returns>The maximum zoom level, as a percentage.</returns>
    double MaxZoom { get; }

    /// <summary>Gets the minimum zoom level of the element.</summary>
    /// <returns>The minimum zoom level, as a percentage.</returns>
    double MinZoom { get; }

    /// <summary>Zooms the viewport of the control.</summary>
    /// <param name="zoom">The amount to zoom the viewport, specified as a percentage. The provider should zoom the viewport to the nearest supported value.</param>
    void Zoom(double zoom);

    /// <summary>Zooms the viewport of the control by the specified logical unit.</summary>
    /// <param name="zoomUnit">The logical unit by which to increase or decrease the zoom of the viewport.</param>
    void ZoomByUnit(ZoomUnit zoomUnit);
  }
}
