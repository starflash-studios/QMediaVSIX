// Decompiled with JetBrains decompiler
// Type: Windows.Security.Cryptography.Core.IHashComputation
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Security.Cryptography.Core
{
  [Guid(1493488054, 44337, 17923, 163, 164, 177, 189, 169, 142, 37, 98)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (CryptographicHash))]
  internal interface IHashComputation
  {
    void Append(IBuffer data);

    IBuffer GetValueAndReset();
  }
}
