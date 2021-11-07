// Decompiled with JetBrains decompiler
// Type: Windows.Security.Cryptography.Core.IEncryptedAndAuthenticatedData
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Security.Cryptography.Core
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (EncryptedAndAuthenticatedData))]
  [Guid(1873031143, 7883, 19200, 190, 165, 96, 184, 63, 134, 47, 23)]
  internal interface IEncryptedAndAuthenticatedData
  {
    IBuffer EncryptedData { get; }

    IBuffer AuthenticationTag { get; }
  }
}
