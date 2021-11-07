// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IGroupStyleSelector
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [WebHostHidden]
  [ExclusiveTo(typeof (GroupStyleSelector))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1843007902, 39540, 18319, 163, 57, 91, 181, 45, 230, 197, 30)]
  internal interface IGroupStyleSelector
  {
    GroupStyle SelectGroupStyle(object group, uint level);
  }
}
