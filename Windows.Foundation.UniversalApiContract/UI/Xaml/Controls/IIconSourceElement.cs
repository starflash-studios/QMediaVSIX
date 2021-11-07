// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IIconSourceElement
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [Guid(3617998082, 56794, 21965, 180, 201, 231, 154, 188, 139, 14, 164)]
  [ExclusiveTo(typeof (IconSourceElement))]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  internal interface IIconSourceElement
  {
    IconSource IconSource { get; set; }
  }
}
