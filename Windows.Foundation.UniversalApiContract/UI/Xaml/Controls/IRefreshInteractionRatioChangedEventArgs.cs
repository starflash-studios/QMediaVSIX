// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IRefreshInteractionRatioChangedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  [Guid(3622074400, 56391, 19342, 187, 39, 127, 10, 131, 242, 154, 7)]
  [ExclusiveTo(typeof (RefreshInteractionRatioChangedEventArgs))]
  internal interface IRefreshInteractionRatioChangedEventArgs
  {
    double InteractionRatio { get; }
  }
}
