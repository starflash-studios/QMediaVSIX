// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.IThemeShadowFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media
{
  [ExclusiveTo(typeof (ThemeShadow))]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 524288)]
  [Guid(779175517, 3943, 22798, 131, 27, 126, 94, 42, 50, 183, 120)]
  internal interface IThemeShadowFactory
  {
    ThemeShadow CreateInstance(object baseInterface, out object innerInterface);
  }
}
