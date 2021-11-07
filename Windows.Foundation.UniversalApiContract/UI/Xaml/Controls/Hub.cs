// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Hub
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Markup;

namespace Windows.UI.Xaml.Controls
{
  /// <summary>Represents a control that displays groups of content in a panning view.</summary>
  [ContentProperty(Name = "Sections")]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Static(typeof (IHubStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [Composable(typeof (IHubFactory), CompositionType.Public, 65536, "Windows.Foundation.UniversalApiContract")]
  public class Hub : Control, IHub, ISemanticZoomInformation
  {
    /// <summary>Initializes a new instance of the Hub class.</summary>
    [MethodImpl]
    public extern Hub();

    /// <summary>Gets or sets the content for the hub header.</summary>
    /// <returns>The content of the hub header. The default is **null**.</returns>
    public extern object Header { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the DataTemplate used to display the content of the hub header.</summary>
    /// <returns>The template that specifies the visualization of the header object. The default is **null**.</returns>
    public extern DataTemplate HeaderTemplate { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the orientation of a Hub.</summary>
    /// <returns>One of the Orientation values. The default is **Horizontal**.</returns>
    public extern Orientation Orientation { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the index of the hub section to show first when the Hub is initialized.</summary>
    /// <returns>The index of the hub section to show first when the Hub is initialized.</returns>
    public extern int DefaultSectionIndex { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets all the hub sections in the Hub.</summary>
    /// <returns>All the hub sections in the Hub. The default is an empty collection.</returns>
    public extern IVector<HubSection> Sections { [MethodImpl] get; }

    /// <summary>Gets the hub sections currently on the screen.</summary>
    /// <returns>The hub sections currently on the screen.</returns>
    public extern IVector<HubSection> SectionsInView { [MethodImpl] get; }

    /// <summary>Gets a collection of the headers of the hub sections.</summary>
    /// <returns>The headers of the hub sections. The default is an empty collection.</returns>
    public extern IObservableVector<object> SectionHeaders { [MethodImpl] get; }

    /// <summary>Occurs when a section header is clicked and the section's IsHeaderInteractive property is **true**.</summary>
    public extern event HubSectionHeaderClickEventHandler SectionHeaderClick;

    /// <summary>Occurs when the SectionsInView collection changes.</summary>
    public extern event SectionsInViewChangedEventHandler SectionsInViewChanged;

    /// <summary>Scrolls the hub to bring the specified hub section into view.</summary>
    /// <param name="section">The hub section to bring into view.</param>
    [MethodImpl]
    public extern void ScrollToSection(HubSection section);

    /// <summary>Gets or sets the SemanticZoom instance that hosts the Hub.</summary>
    /// <returns>The SemanticZoom instance that hosts this Hub, or **null** if the Hub is not hosted in a SemanticZoom control.</returns>
    public extern SemanticZoom SemanticZoomOwner { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that indicates whether the Hub instance is the active view in its owning SemanticZoom.</summary>
    /// <returns>**true** if the Hub is the active view; otherwise, **false**.</returns>
    public extern bool IsActiveView { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that indicates whether the Hub instance is the zoomed-in view in its owning SemanticZoom.</summary>
    /// <returns>**true** if the Hub is the zoomed-in view; otherwise, **false**.</returns>
    public extern bool IsZoomedInView { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Initializes the changes to related aspects of presentation (such as scrolling UI or state) when the overall view for a SemanticZoom is about to change.</summary>
    [MethodImpl]
    public extern void InitializeViewChange();

    /// <summary>Changes related aspects of presentation when the overall view for a SemanticZoom changes.</summary>
    [MethodImpl]
    public extern void CompleteViewChange();

    /// <summary>Forces content in the view to scroll until the item that's specified by SemanticZoomLocation is visible. Also focuses the item if it finds the item.</summary>
    /// <param name="item">The item in the view to scroll to.</param>
    [MethodImpl]
    public extern void MakeVisible(SemanticZoomLocation item);

    /// <summary>Initializes item-wise operations that are related to a view change when the Hub instance is the source view and the pending destination view is a potentially different implementing view.</summary>
    /// <param name="source">The view item as represented in the source view.</param>
    /// <param name="destination">The view item as represented in the destination view.</param>
    [MethodImpl]
    public extern void StartViewChangeFrom(
      SemanticZoomLocation source,
      SemanticZoomLocation destination);

    /// <summary>Initializes item-wise operations that are related to a view change when the source view is a different view and the pending destination view is the Hub instance.</summary>
    /// <param name="source">The view item as represented in the source view.</param>
    /// <param name="destination">The view item as represented in the destination view.</param>
    [MethodImpl]
    public extern void StartViewChangeTo(
      SemanticZoomLocation source,
      SemanticZoomLocation destination);

    /// <summary>Completes item-wise operations that are related to a view change when the Hub instance is the source view and the new view is a potentially different implementing view.</summary>
    /// <param name="source">The view item as represented in the source view.</param>
    /// <param name="destination">The view item as represented in the destination view.</param>
    [MethodImpl]
    public extern void CompleteViewChangeFrom(
      SemanticZoomLocation source,
      SemanticZoomLocation destination);

    /// <summary>Completes item-wise operations that are related to a view change when the Hub instance is the destination view and the source view is a potentially different implementing view.</summary>
    /// <param name="source">The view item as represented in the source view.</param>
    /// <param name="destination">The view item as represented in the destination view.</param>
    [MethodImpl]
    public extern void CompleteViewChangeTo(
      SemanticZoomLocation source,
      SemanticZoomLocation destination);

    /// <summary>Identifies the Header dependency property.</summary>
    /// <returns>The identifier for the Header dependency property.</returns>
    public static extern DependencyProperty HeaderProperty { [MethodImpl] get; }

    /// <summary>Identifies the HeaderTemplate dependency property.</summary>
    /// <returns>The identifier for the HeaderTemplate dependency property.</returns>
    public static extern DependencyProperty HeaderTemplateProperty { [MethodImpl] get; }

    /// <summary>Identifies the Orientation dependency property.</summary>
    /// <returns>The identifier for the Orientation dependency property.</returns>
    public static extern DependencyProperty OrientationProperty { [MethodImpl] get; }

    /// <summary>Identifies the DefaultSectionIndex dependency property.</summary>
    /// <returns>The identifier for the DefaultSectionIndex dependency property.</returns>
    public static extern DependencyProperty DefaultSectionIndexProperty { [MethodImpl] get; }

    /// <summary>Identifies the SemanticZoomOwner dependency property.</summary>
    /// <returns>The identifier for the SemanticZoomOwner dependency property.</returns>
    public static extern DependencyProperty SemanticZoomOwnerProperty { [MethodImpl] get; }

    /// <summary>Identifies the IsActiveView dependency property.</summary>
    /// <returns>The identifier for the IsActiveView dependency property.</returns>
    public static extern DependencyProperty IsActiveViewProperty { [MethodImpl] get; }

    /// <summary>Identifies the IsZoomedInView dependency property.</summary>
    /// <returns>The identifier for the IsZoomedInView dependency property.</returns>
    public static extern DependencyProperty IsZoomedInViewProperty { [MethodImpl] get; }
  }
}
