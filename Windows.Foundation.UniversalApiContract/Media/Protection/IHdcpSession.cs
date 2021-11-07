// Decompiled with JetBrains decompiler
// Type: Windows.Media.Protection.IHdcpSession
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Protection
{
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Guid(1904756201, 25815, 17005, 128, 155, 27, 228, 97, 148, 26, 42)]
  [ExclusiveTo(typeof (HdcpSession))]
  internal interface IHdcpSession : IClosable
  {
    bool IsEffectiveProtectionAtLeast(HdcpProtection protection);

    IReference<HdcpProtection> GetEffectiveProtection();

    [RemoteAsync]
    IAsyncOperation<HdcpSetProtectionResult> SetDesiredMinProtectionAsync(
      HdcpProtection protection);

    event TypedEventHandler<HdcpSession, object> ProtectionChanged;
  }
}
