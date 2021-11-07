// Decompiled with JetBrains decompiler
// Type: Windows.UI.ViewManagement.Core.CoreInputViewOcclusionsChangedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.UI.ViewManagement.Core
{
  /// <summary>Contains event data for the OcclusionsChanged event.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  [DualApiPartition(version = 1)]
  public sealed class CoreInputViewOcclusionsChangedEventArgs : 
    ICoreInputViewOcclusionsChangedEventArgs
  {
    /// <summary>Gets the collection of input panes (and associated UI) currently occluding the app.</summary>
    /// <returns>The CoreInputViewOcclusion collection.</returns>
    public extern IVectorView<CoreInputViewOcclusion> Occlusions { [MethodImpl] get; }

    /// <summary>Gets or sets a value that marks the event as handled. A **true** value for Handled prevents most handlers along the event route from handling the same event again.</summary>
    /// <returns>**true** to mark the event handled. **false** to leave the event unhandled, which permits the event to potentially route further and be acted on by other handlers. The default is **false**.</returns>
    public extern bool Handled { [MethodImpl] get; [MethodImpl] set; }
  }
}
