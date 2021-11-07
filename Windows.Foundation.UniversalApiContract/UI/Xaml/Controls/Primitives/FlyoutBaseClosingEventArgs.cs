// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Primitives.FlyoutBaseClosingEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls.Primitives
{
  /// <summary>Provides data for the FlyoutBase.Closing event</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [WebHostHidden]
  public sealed class FlyoutBaseClosingEventArgs : IFlyoutBaseClosingEventArgs
  {
    /// <summary>Gets or sets a value that indicates whether the flyout should be prevented from closing.</summary>
    /// <returns>**true** to prevent the flyout from closing; otherwise, **false**.</returns>
    public extern bool Cancel { [MethodImpl] get; [MethodImpl] set; }
  }
}
