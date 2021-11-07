// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.SnapPointsType
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  /// <summary>Defines constants that specify how panning snap points are processed for gesture/manipulation input. </summary>
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum SnapPointsType
  {
    /// <summary>No snapping behavior. Only the manipulation influences the final location.</summary>
    None,
    /// <summary>Content stops at a snap point closest to where inertia would naturally stop along the direction of inertia, depending on how close the snap point is.</summary>
    Optional,
    /// <summary>Content always stops at the snap point closest to where inertia would naturally stop along the direction of inertia.</summary>
    Mandatory,
    /// <summary>Content stops at the next snap point, if the motion starts far from it.</summary>
    OptionalSingle,
    /// <summary>Content always stops at the snap point closest to the release point along the direction of inertia.</summary>
    MandatorySingle,
  }
}
