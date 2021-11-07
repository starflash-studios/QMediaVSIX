// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IStyleSelectorFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (StyleSelector))]
  [Guid(2660510439, 14177, 17535, 143, 151, 41, 227, 157, 94, 179, 16)]
  [WebHostHidden]
  internal interface IStyleSelectorFactory
  {
    StyleSelector CreateInstance(object baseInterface, out object innerInterface);
  }
}
