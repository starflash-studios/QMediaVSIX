// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Primitives.LayoutInformation
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls.Primitives
{
  /// <summary>Defines methods that provide additional information about the layout of an element.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Static(typeof (ILayoutInformationStatics2), 327680, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Static(typeof (ILayoutInformationStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [WebHostHidden]
  public sealed class LayoutInformation : ILayoutInformation
  {
    /// <summary>Returns the Size value that was most recently used to measure the specified element.</summary>
    /// <param name="element">The element for which to return the most recent size.</param>
    /// <returns>The Size given as an argument on the most recent call to measure this element, or a Size of 0,0 if the element has not been measured yet.</returns>
    [MethodImpl]
    public static extern Size GetAvailableSize(UIElement element);

    /// <summary>Returns the element that was being processed by the layout system at the moment of an unhandled exception.</summary>
    /// <param name="dispatcher">The *dispatcher* object that defines the scope of the operation. Direct support for "Dispatcher" type does not exist yet.</param>
    /// <returns>The element being processed at the time of an unhandled exception.</returns>
    [MethodImpl]
    public static extern UIElement GetLayoutExceptionElement(object dispatcher);

    /// <summary>Returns the layout slot, or bounding box, that contains the specified element.</summary>
    /// <param name="element">The element for which to return the layout slot.</param>
    /// <returns>The area assigned to the element for layout.</returns>
    [MethodImpl]
    public static extern Rect GetLayoutSlot(FrameworkElement element);
  }
}
