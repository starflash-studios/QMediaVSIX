// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.BackClickEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  /// <summary>Provides event data for the SettingsFlyout.BackClick event.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class BackClickEventArgs : IBackClickEventArgs
  {
    /// <summary>Initializes a new instance of the BackClickEventArgs class.</summary>
    [MethodImpl]
    public extern BackClickEventArgs();

    /// <summary>Gets or sets a value that can cancel the navigation. A **true** value for Handled cancels the default behavior.</summary>
    /// <returns>**true** to cancel the navigation. **false** to use default behavior. The default is **false**.</returns>
    public extern bool Handled { [MethodImpl] get; [MethodImpl] set; }
  }
}
