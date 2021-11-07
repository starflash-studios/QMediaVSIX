// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IStackPanelStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [ExclusiveTo(typeof (StackPanel))]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(4040215955, 19900, 18599, 153, 20, 149, 73, 36, 101, 119, 113)]
  internal interface IStackPanelStatics
  {
    DependencyProperty AreScrollSnapPointsRegularProperty { get; }

    DependencyProperty OrientationProperty { get; }
  }
}
