// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.RedirectVisual
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Composition
{
  /// <summary>Represents a visual that gets its content from another visual.</summary>
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [WebHostHidden]
  [DualApiPartition(version = 167772166)]
  public sealed class RedirectVisual : ContainerVisual, IRedirectVisual
  {
    /// <summary>Gets or sets the Visual that this RedirectVisual gets its content from.</summary>
    /// <returns>The Visual that this RedirectVisual gets its content from. The default is **null**.</returns>
    public extern Visual Source { [MethodImpl] get; [MethodImpl] set; }
  }
}
