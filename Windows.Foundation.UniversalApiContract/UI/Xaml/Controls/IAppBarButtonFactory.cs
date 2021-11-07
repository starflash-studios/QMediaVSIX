// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IAppBarButtonFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [ExclusiveTo(typeof (AppBarButton))]
  [Guid(3183156150, 52014, 17014, 171, 214, 121, 53, 19, 5, 16, 224)]
  internal interface IAppBarButtonFactory
  {
    AppBarButton CreateInstance(object baseInterface, out object innerInterface);
  }
}
