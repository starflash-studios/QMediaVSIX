// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IItemsControlFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [Guid(4156277593, 63741, 18204, 188, 178, 44, 116, 190, 142, 191, 140)]
  [ExclusiveTo(typeof (ItemsControl))]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IItemsControlFactory
  {
    ItemsControl CreateInstance(object baseInterface, out object innerInterface);
  }
}
