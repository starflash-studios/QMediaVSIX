// Decompiled with JetBrains decompiler
// Type: Windows.Security.Cryptography.DataProtection.IDataProtectionProvider
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Security.Cryptography.DataProtection
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(157522248, 60706, 17008, 189, 28, 109, 114, 192, 15, 135, 135)]
  [ExclusiveTo(typeof (DataProtectionProvider))]
  internal interface IDataProtectionProvider
  {
    [RemoteAsync]
    IAsyncOperation<IBuffer> ProtectAsync(IBuffer data);

    [RemoteAsync]
    IAsyncOperation<IBuffer> UnprotectAsync(IBuffer data);

    [RemoteAsync]
    IAsyncAction ProtectStreamAsync(IInputStream src, IOutputStream dest);

    [RemoteAsync]
    IAsyncAction UnprotectStreamAsync(IInputStream src, IOutputStream dest);
  }
}
