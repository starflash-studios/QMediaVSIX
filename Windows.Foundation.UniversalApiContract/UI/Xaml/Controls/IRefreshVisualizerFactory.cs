// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IRefreshVisualizerFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [Guid(1868325170, 28169, 19472, 130, 74, 18, 125, 54, 103, 39, 21)]
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  [WebHostHidden]
  [ExclusiveTo(typeof (RefreshVisualizer))]
  internal interface IRefreshVisualizerFactory
  {
    RefreshVisualizer CreateInstance(
      object baseInterface,
      out object innerInterface);
  }
}
