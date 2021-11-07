// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.EdgeGesture
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Input
{
  /// <summary>Provides access to the events that notify an app of triggers to its edge-based UI.</summary>
  [MarshalingBehavior(MarshalingType.Standard)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Static(typeof (IEdgeGestureStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.STA)]
  [Muse(Version = 100794368)]
  public sealed class EdgeGesture : IEdgeGesture
  {
    /// <summary>Fires when a user begins an action to summon or dismiss edge-based UI.</summary>
    public extern event TypedEventHandler<EdgeGesture, EdgeGestureEventArgs> Starting;

    /// <summary>Fires to indicate that the user has successfully summoned or dismissed the edge-based UI. This occurs either when the user lifts his or her finger from a touch-enabled screen or when the user presses Win+Z on the keyboard.</summary>
    public extern event TypedEventHandler<EdgeGesture, EdgeGestureEventArgs> Completed;

    /// <summary>Fires when a user cancels a show or hide action for an edge-based UI.</summary>
    public extern event TypedEventHandler<EdgeGesture, EdgeGestureEventArgs> Canceled;

    /// <summary>Gets an instance of the EdgeGesture class that is used to add and remove event delegate handlers for the current view.</summary>
    /// <returns>The currently relevant instance of the EdgeGesture object.</returns>
    [MethodImpl]
    public static extern EdgeGesture GetForCurrentView();
  }
}
