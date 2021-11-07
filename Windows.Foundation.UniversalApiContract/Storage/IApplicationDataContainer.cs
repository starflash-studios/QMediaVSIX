// Decompiled with JetBrains decompiler
// Type: Windows.Storage.IApplicationDataContainer
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Storage
{
  [Guid(3316579614, 62567, 16570, 133, 102, 171, 100, 10, 68, 30, 29)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (ApplicationDataContainer))]
  internal interface IApplicationDataContainer
  {
    string Name { get; }

    ApplicationDataLocality Locality { get; }

    IPropertySet Values { get; }

    IMapView<string, ApplicationDataContainer> Containers { get; }

    ApplicationDataContainer CreateContainer(
      string name,
      ApplicationDataCreateDisposition disposition);

    void DeleteContainer(string name);
  }
}
