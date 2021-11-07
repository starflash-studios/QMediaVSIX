// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IAppBarStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [Guid(2042330765, 56489, 19295, 164, 72, 55, 177, 50, 56, 237, 118)]
  [ExclusiveTo(typeof (AppBar))]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IAppBarStatics
  {
    DependencyProperty IsOpenProperty { get; }

    DependencyProperty IsStickyProperty { get; }
  }
}
