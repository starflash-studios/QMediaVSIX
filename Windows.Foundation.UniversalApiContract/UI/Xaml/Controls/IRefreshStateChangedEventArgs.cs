// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IRefreshStateChangedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  [WebHostHidden]
  [ExclusiveTo(typeof (RefreshStateChangedEventArgs))]
  [Guid(3144454174, 8702, 16649, 175, 128, 115, 236, 102, 27, 103, 138)]
  internal interface IRefreshStateChangedEventArgs
  {
    RefreshVisualizerState OldState { get; }

    RefreshVisualizerState NewState { get; }
  }
}
