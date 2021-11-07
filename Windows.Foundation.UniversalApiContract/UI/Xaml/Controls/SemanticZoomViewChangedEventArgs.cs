// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.SemanticZoomViewChangedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  /// <summary>Provides event data for the ViewChangeStarted and ViewChangeCompleted events.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [WebHostHidden]
  public sealed class SemanticZoomViewChangedEventArgs : ISemanticZoomViewChangedEventArgs
  {
    /// <summary>Initializes a new instance of the SemanticZoomViewChangedEventArgs class.</summary>
    [MethodImpl]
    public extern SemanticZoomViewChangedEventArgs();

    /// <summary>Gets or sets a value that indicates whether the starting view is the ZoomedInView.</summary>
    /// <returns>**true** if the starting view is the ZoomedInView; otherwise, **false**.</returns>
    public extern bool IsSourceZoomedInView { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Provides information about the item and its bounds, for the item as represented in the previous view.</summary>
    /// <returns>Information about the item and its bounds.</returns>
    public extern SemanticZoomLocation SourceItem { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Provides information about the item and its bounds, once the view change is complete.</summary>
    /// <returns>Information about the item and its bounds.</returns>
    public extern SemanticZoomLocation DestinationItem { [MethodImpl] get; [MethodImpl] set; }
  }
}
