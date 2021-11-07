// Decompiled with JetBrains decompiler
// Type: Windows.UI.ViewManagement.Core.CoreInputViewOcclusion
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.ViewManagement.Core
{
  /// <summary>Represents a single input pane currently occluding the app.</summary>
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  [DualApiPartition(version = 1)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class CoreInputViewOcclusion : ICoreInputViewOcclusion
  {
    /// <summary>Gets the bounding rect of the occluding input pane (and associated UI).</summary>
    /// <returns>The rectangle, in client coordinates, representing the region of the app window hidden behind the pane. Specified in device-independent pixels (DIP).</returns>
    public extern Rect OccludingRect { [MethodImpl] get; }

    /// <summary>The type of occluding input pane (and associated UI).</summary>
    /// <returns>A value from the CoreInputViewOcclusionKind enumeration that indicates the type of input pane supported by the CoreInputViewOcclusion object.</returns>
    public extern CoreInputViewOcclusionKind OcclusionKind { [MethodImpl] get; }
  }
}
