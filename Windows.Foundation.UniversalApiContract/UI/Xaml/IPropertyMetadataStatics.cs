// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.IPropertyMetadataStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [ExclusiveTo(typeof (PropertyMetadata))]
  [Guid(989923194, 28166, 17897, 139, 92, 175, 36, 52, 88, 192, 98)]
  internal interface IPropertyMetadataStatics
  {
    [DefaultOverload]
    [Overload("CreateWithDefaultValue")]
    PropertyMetadata Create(object defaultValue);

    [DefaultOverload]
    [Overload("CreateWithDefaultValueAndCallback")]
    PropertyMetadata Create(
      object defaultValue,
      PropertyChangedCallback propertyChangedCallback);

    [Overload("CreateWithFactory")]
    PropertyMetadata Create(
      CreateDefaultValueCallback createDefaultValueCallback);

    [Overload("CreateWithFactoryAndCallback")]
    PropertyMetadata Create(
      CreateDefaultValueCallback createDefaultValueCallback,
      PropertyChangedCallback propertyChangedCallback);
  }
}
