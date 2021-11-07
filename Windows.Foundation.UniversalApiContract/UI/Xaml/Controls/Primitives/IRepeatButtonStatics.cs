// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Primitives.IRepeatButtonStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls.Primitives
{
  [Guid(957656142, 62562, 20339, 129, 151, 232, 132, 102, 57, 198, 130)]
  [WebHostHidden]
  [ExclusiveTo(typeof (RepeatButton))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IRepeatButtonStatics
  {
    DependencyProperty DelayProperty { get; }

    DependencyProperty IntervalProperty { get; }
  }
}
