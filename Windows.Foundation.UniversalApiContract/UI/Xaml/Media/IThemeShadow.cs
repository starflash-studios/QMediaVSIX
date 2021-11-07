// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.IThemeShadow
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media
{
  [WebHostHidden]
  [ExclusiveTo(typeof (ThemeShadow))]
  [ContractVersion(typeof (UniversalApiContract), 524288)]
  [Guid(1053601033, 31109, 24377, 139, 98, 108, 16, 105, 109, 202, 111)]
  internal interface IThemeShadow
  {
    UIElementWeakCollection Receivers { get; }
  }
}
