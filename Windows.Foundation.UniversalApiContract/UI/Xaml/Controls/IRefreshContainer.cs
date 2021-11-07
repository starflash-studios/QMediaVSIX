// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IRefreshContainer
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  [ExclusiveTo(typeof (RefreshContainer))]
  [Guid(1398653971, 45525, 17345, 176, 87, 134, 88, 206, 30, 11, 162)]
  internal interface IRefreshContainer
  {
    RefreshVisualizer Visualizer { get; set; }

    RefreshPullDirection PullDirection { get; set; }

    event TypedEventHandler<RefreshContainer, RefreshRequestedEventArgs> RefreshRequested;

    void RequestRefresh();
  }
}
