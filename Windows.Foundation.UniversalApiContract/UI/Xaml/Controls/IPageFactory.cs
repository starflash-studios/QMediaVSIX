// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IPageFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (Page))]
  [Guid(3751889324, 6217, 17502, 147, 124, 64, 169, 89, 12, 192, 118)]
  [WebHostHidden]
  internal interface IPageFactory
  {
    Page CreateInstance(object baseInterface, out object innerInterface);
  }
}
