// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.IDependencyPropertyStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Interop;

namespace Windows.UI.Xaml
{
  [Guid(1239806607, 33369, 19804, 170, 224, 131, 213, 109, 187, 104, 217)]
  [WebHostHidden]
  [ExclusiveTo(typeof (DependencyProperty))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IDependencyPropertyStatics
  {
    object UnsetValue { get; }

    DependencyProperty Register(
      string name,
      TypeName propertyType,
      TypeName ownerType,
      PropertyMetadata typeMetadata);

    DependencyProperty RegisterAttached(
      string name,
      TypeName propertyType,
      TypeName ownerType,
      PropertyMetadata defaultMetadata);
  }
}
