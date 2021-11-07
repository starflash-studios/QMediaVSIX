// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Data.IBindingFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Data
{
  [WebHostHidden]
  [Guid(4282563336, 50078, 20350, 132, 52, 161, 86, 144, 131, 136, 60)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (Binding))]
  internal interface IBindingFactory
  {
    Binding CreateInstance(object baseInterface, out object innerInterface);
  }
}
