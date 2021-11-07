// Decompiled with JetBrains decompiler
// Type: Windows.UI.WindowManagement.FullScreenPresentationConfiguration
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.WindowManagement
{
  /// <summary>Represents the full screen configuration for an AppWindowPresenter.</summary>
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 524288)]
  [WebHostHidden]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Activatable(524288, "Windows.Foundation.UniversalApiContract")]
  public sealed class FullScreenPresentationConfiguration : 
    AppWindowPresentationConfiguration,
    IFullScreenPresentationConfiguration
  {
    /// <summary>Initializes a new instance of the FullScreenPresentationConfiguration class.</summary>
    [MethodImpl]
    public extern FullScreenPresentationConfiguration();

    /// <summary>Gets or sets a value that indicates whether Exclusive Fullscreen Mode is on.</summary>
    /// <returns>**true** if the presentation is in Exclusive Fullscreen Mode; otherwise, **false**.</returns>
    public extern bool IsExclusive { [MethodImpl] get; [MethodImpl] set; }
  }
}
