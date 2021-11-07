// Decompiled with JetBrains decompiler
// Type: Windows.System.IAppUriHandlerRegistration2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.System
{
  [ExclusiveTo(typeof (AppUriHandlerRegistration))]
  [ContractVersion(typeof (UniversalApiContract), 851968)]
  [Guid(3578637463, 52025, 24351, 136, 62, 1, 133, 55, 48, 189, 109)]
  internal interface IAppUriHandlerRegistration2
  {
    IVector<AppUriHandlerHost> GetAllHosts();

    void UpdateHosts(IIterable<AppUriHandlerHost> hosts);

    string PackageFamilyName { get; }
  }
}
