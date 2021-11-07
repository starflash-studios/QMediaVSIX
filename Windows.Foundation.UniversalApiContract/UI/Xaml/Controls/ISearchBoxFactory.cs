// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.ISearchBoxFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [WebHostHidden]
  [ExclusiveTo(typeof (SearchBox))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3446947693, 34437, 18100, 157, 221, 32, 47, 105, 65, 183, 1)]
  internal interface ISearchBoxFactory
  {
    SearchBox CreateInstance(object baseInterface, out object innerInterface);
  }
}
