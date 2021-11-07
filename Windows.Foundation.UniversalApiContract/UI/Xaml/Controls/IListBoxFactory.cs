// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IListBoxFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [ExclusiveTo(typeof (ListBox))]
  [WebHostHidden]
  [Guid(1624112546, 12100, 17483, 156, 148, 184, 201, 253, 164, 111, 89)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IListBoxFactory
  {
    ListBox CreateInstance(object baseInterface, out object innerInterface);
  }
}
