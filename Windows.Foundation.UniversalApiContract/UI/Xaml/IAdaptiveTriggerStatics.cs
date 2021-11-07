// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.IAdaptiveTriggerStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml
{
  [Guid(3106810346, 5653, 17232, 156, 59, 146, 178, 152, 107, 244, 68)]
  [WebHostHidden]
  [ExclusiveTo(typeof (AdaptiveTrigger))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IAdaptiveTriggerStatics
  {
    DependencyProperty MinWindowWidthProperty { get; }

    DependencyProperty MinWindowHeightProperty { get; }
  }
}
