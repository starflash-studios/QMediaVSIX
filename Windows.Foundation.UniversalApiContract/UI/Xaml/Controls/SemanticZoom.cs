// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.SemanticZoom
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Markup;

namespace Windows.UI.Xaml.Controls
{
  /// <summary>Represents a scrollable control that incorporates two views that have a semantic relationship. For example, the ZoomedOutView might be an index of titles, and the ZoomedInView might include details and summaries for each of the title entries. Views can be changed using zoom or other interactions.</summary>
  [ContentProperty(Name = "ZoomedInView")]
  [WebHostHidden]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Static(typeof (ISemanticZoomStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class SemanticZoom : Control, ISemanticZoom
  {
    /// <summary>Initializes a new instance of the SemanticZoom class.</summary>
    [MethodImpl]
    public extern SemanticZoom();

    /// <summary>Gets or sets the semantically more complete zoomed-in view of the SemanticZoom.</summary>
    /// <returns>An object that implements ISemanticZoomInfo. Typically this is a practical ListViewBase implementation such as GridView.</returns>
    public extern ISemanticZoomInformation ZoomedInView { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the zoomed-out view of the SemanticZoom.</summary>
    /// <returns>An object that implements ISemanticZoomInfo. Typically this is a practical ListViewBase implementation such as GridView.</returns>
    public extern ISemanticZoomInformation ZoomedOutView { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that determines whether the ZoomedInView is the active view.</summary>
    /// <returns>**true** if the ZoomedInView is the active view. **false** if the ZoomedOutView is the active view.</returns>
    public extern bool IsZoomedInViewActive { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that declares whether the SemanticZoom can change display views.</summary>
    /// <returns>**true** if views can be changed; otherwise, **false**. The default is **true**. </returns>
    public extern bool CanChangeViews { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Occurs when a view change is requested.</summary>
    public extern event SemanticZoomViewChangedEventHandler ViewChangeStarted;

    /// <summary>Occurs when a view change is complete and the view is displayed.</summary>
    public extern event SemanticZoomViewChangedEventHandler ViewChangeCompleted;

    /// <summary>Changes from the current active view to the other possible view. For example, if IsZoomedInViewActive is true, calling this method changes to zoomed-out view.</summary>
    [MethodImpl]
    public extern void ToggleActiveView();

    /// <summary>Gets or sets a value that indicates whether the ZoomedInView shows a button that activates the ZoomedOutView.</summary>
    /// <returns>**True** if the ZoomedInView shows a button that activates the ZoomedOutView; otherwise, **false**. The default is **true**.</returns>
    public extern bool IsZoomOutButtonEnabled { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Identifies the ZoomedInView dependency property.</summary>
    /// <returns>The identifier for the ZoomedInView dependency property.</returns>
    public static extern DependencyProperty ZoomedInViewProperty { [MethodImpl] get; }

    /// <summary>Identifies the ZoomedOutView dependency property.</summary>
    /// <returns>The identifier for the ZoomedOutView dependency property.</returns>
    public static extern DependencyProperty ZoomedOutViewProperty { [MethodImpl] get; }

    /// <summary>Identifies the IsZoomedInViewActive dependency property.</summary>
    /// <returns>The identifier for the IsZoomedInViewActive dependency property.</returns>
    public static extern DependencyProperty IsZoomedInViewActiveProperty { [MethodImpl] get; }

    /// <summary>Identifies the CanChangeViews dependency property.</summary>
    /// <returns>The identifier for the CanChangeViews dependency property.</returns>
    public static extern DependencyProperty CanChangeViewsProperty { [MethodImpl] get; }

    /// <summary>Identifies the IsZoomOutButtonEnabled dependency property.</summary>
    /// <returns>The identifier of the IsZoomOutButtonEnabled dependency property.</returns>
    public static extern DependencyProperty IsZoomOutButtonEnabledProperty { [MethodImpl] get; }
  }
}
