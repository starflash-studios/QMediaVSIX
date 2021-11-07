// Decompiled with JetBrains decompiler
// Type: Windows.Management.IMdmSession
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Management
{
  [Guid(4270403916, 36708, 18327, 169, 215, 157, 136, 248, 106, 225, 102)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [ExclusiveTo(typeof (MdmSession))]
  internal interface IMdmSession
  {
    IVectorView<MdmAlert> Alerts { get; }

    HResult ExtendedError { get; }

    string Id { get; }

    MdmSessionState State { get; }

    [RemoteAsync]
    IAsyncAction AttachAsync();

    void Delete();

    [Overload("StartAsync")]
    [RemoteAsync]
    IAsyncAction StartAsync();

    [Overload("StartWithAlertsAsync")]
    IAsyncAction StartAsync(IIterable<MdmAlert> alerts);
  }
}
