// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IAppBarButton3
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [ExclusiveTo(typeof (AppBarButton))]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Guid(187179344, 6539, 20100, 143, 28, 159, 106, 139, 162, 103, 167)]
  [WebHostHidden]
  internal interface IAppBarButton3
  {
    CommandBarLabelPosition LabelPosition { get; set; }
  }
}
