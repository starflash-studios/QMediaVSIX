// Decompiled with JetBrains decompiler
// Type: Windows.UI.WindowManagement.DefaultPresentationConfiguration
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.WindowManagement
{
  /// <summary>Represents the default configuration for an AppWindowPresenter.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [Activatable(524288, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 524288)]
  public sealed class DefaultPresentationConfiguration : 
    AppWindowPresentationConfiguration,
    IDefaultPresentationConfiguration
  {
    /// <summary>Initializes a new instance of the DefaultPresentationConfiguration class.</summary>
    [MethodImpl]
    public extern DefaultPresentationConfiguration();
  }
}
