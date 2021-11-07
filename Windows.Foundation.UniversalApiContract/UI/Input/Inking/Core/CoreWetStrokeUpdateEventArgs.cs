// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.Inking.Core.CoreWetStrokeUpdateEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.UI.Input.Inking.Core
{
  /// <summary>Contains ink stroke event data for an InkPresenter object.</summary>
  [DualApiPartition(version = 167772162)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [WebHostHidden]
  public sealed class CoreWetStrokeUpdateEventArgs : ICoreWetStrokeUpdateEventArgs
  {
    /// <summary>Gets the collection of InkPoint objects processed since the last event.</summary>
    /// <returns>The collection of InkPoint objects.</returns>
    public extern IVector<InkPoint> NewInkPoints { [MethodImpl] get; }

    /// <summary>Gets a unique identifier for the input pointer.</summary>
    /// <returns>A unique value that identifies the input pointer.</returns>
    public extern uint PointerId { [MethodImpl] get; }

    /// <summary>Gets or sets the pre-rendered state of the "wet" ink stroke.</summary>
    /// <returns>The pre-rendered state of the "wet" ink stroke.</returns>
    public extern CoreWetStrokeDisposition Disposition { [MethodImpl] get; [MethodImpl] set; }
  }
}
