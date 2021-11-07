// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IAppBarButton5
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls.Primitives;

namespace Windows.UI.Xaml.Controls
{
  [Guid(1083636863, 6892, 19215, 160, 49, 202, 140, 78, 6, 210, 237)]
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  [ExclusiveTo(typeof (AppBarButton))]
  [WebHostHidden]
  internal interface IAppBarButton5
  {
    AppBarButtonTemplateSettings TemplateSettings { get; }
  }
}
