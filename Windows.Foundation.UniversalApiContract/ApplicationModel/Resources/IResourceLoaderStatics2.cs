// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Resources.IResourceLoaderStatics2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Resources
{
  [Guid(213926209, 25702, 18825, 148, 148, 11, 130, 223, 197, 63, 31)]
  [ExclusiveTo(typeof (ResourceLoader))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IResourceLoaderStatics2
  {
    [Overload("GetForCurrentView")]
    ResourceLoader GetForCurrentView();

    [Overload("GetForCurrentViewWithName")]
    ResourceLoader GetForCurrentView(string name);

    [Overload("GetForViewIndependentUse")]
    ResourceLoader GetForViewIndependentUse();

    [Overload("GetForViewIndependentUseWithName")]
    ResourceLoader GetForViewIndependentUse(string name);
  }
}
