// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IAppBarButtonStatics4
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  [ExclusiveTo(typeof (AppBarButton))]
  [WebHostHidden]
  [Guid(470475370, 51029, 20454, 163, 182, 14, 51, 148, 233, 82, 192)]
  internal interface IAppBarButtonStatics4
  {
    DependencyProperty KeyboardAcceleratorTextOverrideProperty { get; }
  }
}
