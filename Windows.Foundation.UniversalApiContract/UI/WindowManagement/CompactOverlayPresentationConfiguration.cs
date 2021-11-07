// Decompiled with JetBrains decompiler
// Type: Windows.UI.WindowManagement.CompactOverlayPresentationConfiguration
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.WindowManagement
{
  /// <summary>Represents the compact overlay configuration for an AppWindowPresenter.</summary>
  [WebHostHidden]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 524288)]
  [Activatable(524288, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class CompactOverlayPresentationConfiguration : 
    AppWindowPresentationConfiguration,
    ICompactOverlayPresentationConfiguration
  {
    /// <summary>Initializes a new instance of the CompactOverlayPresentationConfiguration class.</summary>
    [MethodImpl]
    public extern CompactOverlayPresentationConfiguration();
  }
}
