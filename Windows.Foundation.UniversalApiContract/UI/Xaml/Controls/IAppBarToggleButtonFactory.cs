// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IAppBarToggleButtonFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (AppBarToggleButton))]
  [Guid(42641364, 36692, 17830, 159, 144, 19, 96, 86, 86, 215, 147)]
  internal interface IAppBarToggleButtonFactory
  {
    AppBarToggleButton CreateInstance(
      object baseInterface,
      out object innerInterface);
  }
}
