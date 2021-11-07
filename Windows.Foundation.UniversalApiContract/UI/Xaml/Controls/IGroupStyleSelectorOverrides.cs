// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IGroupStyleSelectorOverrides
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (GroupStyleSelector))]
  [Guid(4136749746, 30637, 19773, 165, 28, 142, 249, 195, 131, 100, 86)]
  [WebHostHidden]
  internal interface IGroupStyleSelectorOverrides
  {
    GroupStyle SelectGroupStyleCore(object group, uint level);
  }
}
