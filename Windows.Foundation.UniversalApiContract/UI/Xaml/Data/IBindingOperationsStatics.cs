// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Data.IBindingOperationsStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Data
{
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (BindingOperations))]
  [Guid(3780505459, 38304, 19115, 140, 125, 42, 71, 218, 7, 60, 121)]
  internal interface IBindingOperationsStatics
  {
    void SetBinding(DependencyObject target, DependencyProperty dp, BindingBase binding);
  }
}
