// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.ISettingsFlyoutFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [Guid(1208774673, 22442, 19894, 182, 253, 236, 103, 111, 109, 65, 78)]
  [ExclusiveTo(typeof (SettingsFlyout))]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface ISettingsFlyoutFactory
  {
    SettingsFlyout CreateInstance(object baseInterface, out object innerInterface);
  }
}
