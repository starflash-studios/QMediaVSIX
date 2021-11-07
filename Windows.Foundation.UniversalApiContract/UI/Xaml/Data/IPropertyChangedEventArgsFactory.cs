// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Data.IPropertyChangedEventArgsFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Data
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [ExclusiveTo(typeof (PropertyChangedEventArgs))]
  [Guid(1842125827, 57543, 20206, 142, 169, 55, 227, 64, 110, 235, 28)]
  internal interface IPropertyChangedEventArgsFactory
  {
    PropertyChangedEventArgs CreateInstance(
      string name,
      object baseInterface,
      out object innerInterface);
  }
}
