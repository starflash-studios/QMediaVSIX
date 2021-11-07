// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.ISemanticZoomInformation
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  /// <summary>Communicates the info needed for a view to serve as one of the two possible views (ZoomedOutView or ZoomedInView ) of a SemanticZoom.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2808757091, 8859, 19909, 170, 17, 157, 146, 47, 191, 138, 152)]
  [WebHostHidden]
  public interface ISemanticZoomInformation
  {
    /// <summary>Gets or sets the SemanticZoom owner that hosts the implementing view.</summary>
    /// <returns>The SemanticZoom that hosts this view. </returns>
    SemanticZoom SemanticZoomOwner { get; set; }

    /// <summary>Gets or sets a value that indicates whether the implementing view is the active view.</summary>
    /// <returns>**true** if the implementing view is the active view; otherwise, **false**.</returns>
    bool IsActiveView { get; set; }

    /// <summary>Gets or sets a value that indicates whether the implementing view is the semantically more complete zoomed-in view.</summary>
    /// <returns>**true** if the implementing view is the zoomed-in view; otherwise, **false**.</returns>
    bool IsZoomedInView { get; set; }

    /// <summary>Initializes the changes to related aspects of presentation (such as scrolling UI or state) when the overall view for a SemanticZoom is about to change.</summary>
    void InitializeViewChange();

    /// <summary>Changes related aspects of presentation (such as scrolling UI or state) when the overall view for a SemanticZoom changes.</summary>
    void CompleteViewChange();

    /// <summary>Forces content in the view to scroll until the item specified by SemanticZoomLocation is visible. Also focuses that item if found.</summary>
    /// <param name="item">The item in the view to scroll to.</param>
    void MakeVisible(SemanticZoomLocation item);

    /// <summary>Initializes item-wise operations related to a view change when the implementing view is the source view and the pending destination view is a potentially different implementing view.</summary>
    /// <param name="source">The view item as represented in the source view.</param>
    /// <param name="destination">The view item as represented in the destination view.</param>
    void StartViewChangeFrom(SemanticZoomLocation source, SemanticZoomLocation destination);

    /// <summary>Initializes item-wise operations related to a view change when the source view is a different view and the pending destination view is the implementing view.</summary>
    /// <param name="source">The view item as represented in the source view.</param>
    /// <param name="destination">The view item as represented in the destination view.</param>
    void StartViewChangeTo(SemanticZoomLocation source, SemanticZoomLocation destination);

    /// <summary>Completes item-wise operations related to a view change when the implementing view is the source view and the new view is a potentially different implementing view.</summary>
    /// <param name="source">The view item as represented in the source view.</param>
    /// <param name="destination">The view item as represented in the destination view.</param>
    void CompleteViewChangeFrom(SemanticZoomLocation source, SemanticZoomLocation destination);

    /// <summary>Completes item-wise operations related to a view change when the implementing view is the destination view and the source view is a potentially different implementing view.</summary>
    /// <param name="source">The view item as represented in the source view.</param>
    /// <param name="destination">The view item as represented in the destination view.</param>
    void CompleteViewChangeTo(SemanticZoomLocation source, SemanticZoomLocation destination);
  }
}
