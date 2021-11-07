// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.IPropertyMetadataFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml
{
  [Guid(3250068672, 22477, 20271, 176, 169, 225, 128, 27, 40, 247, 107)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (PropertyMetadata))]
  [WebHostHidden]
  internal interface IPropertyMetadataFactory
  {
    PropertyMetadata CreateInstanceWithDefaultValue(
      object defaultValue,
      object baseInterface,
      out object innerInterface);

    PropertyMetadata CreateInstanceWithDefaultValueAndCallback(
      object defaultValue,
      PropertyChangedCallback propertyChangedCallback,
      object baseInterface,
      out object innerInterface);
  }
}
