// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IAppBarButtonStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [ExclusiveTo(typeof (AppBarButton))]
  [WebHostHidden]
  [Guid(2093814758, 21249, 16511, 135, 78, 220, 145, 96, 170, 7, 175)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IAppBarButtonStatics
  {
    DependencyProperty LabelProperty { get; }

    DependencyProperty IconProperty { get; }

    DependencyProperty IsCompactProperty { get; }
  }
}
