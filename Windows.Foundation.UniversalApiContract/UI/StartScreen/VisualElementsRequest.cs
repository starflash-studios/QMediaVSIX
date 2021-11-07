// Decompiled with JetBrains decompiler
// Type: Windows.UI.StartScreen.VisualElementsRequest
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.UI.StartScreen
{
  /// <summary>Provides a method to delay the display of the **Pin to Start**  flyout, as well as methods through which you can set the visual elements of the secondary tile to be presented in that flyout as well as alternate versions of the tile that can also be presented as options.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class VisualElementsRequest : IVisualElementsRequest
  {
    /// <summary>Gets a copy of the parent secondary tile's SecondaryTileVisualElements object. The visual elements properties can be set or read through this object. When deferral is complete (or the handler returns without a deferral), the properties in this object are verified and then reflected in the **Pin to Start**  flyout.</summary>
    /// <returns>The object through which you'll access the visual element properties.</returns>
    public extern SecondaryTileVisualElements VisualElements { [MethodImpl] get; }

    /// <summary>Gets a set of objects that provide alternate logo images, background and foreground colors, and display name. These alternates are shown to the user in the **Pin to Start**  flyout.</summary>
    /// <returns>An array of SecondaryTileVisualElements objects, each of which provides the information for an alternate presentation of the secondary tile.</returns>
    public extern IVectorView<SecondaryTileVisualElements> AlternateVisualElements { [MethodImpl] get; }

    /// <summary>Gets the approximate time at which the deferral will time-out.</summary>
    /// <returns>The time at which the deferral will time out.</returns>
    public extern DateTime Deadline { [MethodImpl] get; }

    /// <summary>Retrieves a deferral object, which allows the app time to provide information and assets used in the **Pin to Start**  flyout.</summary>
    /// <returns>The deferral object.</returns>
    [MethodImpl]
    public extern VisualElementsRequestDeferral GetDeferral();
  }
}
