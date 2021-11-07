// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Data.IBindingBaseFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Data
{
  [ExclusiveTo(typeof (BindingBase))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(584776762, 30465, 18022, 161, 186, 152, 89, 189, 207, 236, 52)]
  [WebHostHidden]
  internal interface IBindingBaseFactory
  {
    BindingBase CreateInstance(object baseInterface, out object innerInterface);
  }
}
