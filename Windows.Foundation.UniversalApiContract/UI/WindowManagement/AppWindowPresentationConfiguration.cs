// Decompiled with JetBrains decompiler
// Type: Windows.UI.WindowManagement.AppWindowPresentationConfiguration
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.WindowManagement
{
  /// <summary>Represents the base configuration for an AppWindowPresenter.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [Composable(typeof (IAppWindowPresentationConfigurationFactory), CompositionType.Public, 524288, "Windows.Foundation.UniversalApiContract")]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 524288)]
  public class AppWindowPresentationConfiguration : IAppWindowPresentationConfiguration
  {
    /// <summary>Gets a value that indicates the kind of presentation the app window is using.</summary>
    /// <returns>A value of the enumeration that indicates the kind of presentation the app window is using.</returns>
    public extern AppWindowPresentationKind Kind { [MethodImpl] get; }
  }
}
