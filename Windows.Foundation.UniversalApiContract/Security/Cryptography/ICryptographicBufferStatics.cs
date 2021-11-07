// Decompiled with JetBrains decompiler
// Type: Windows.Security.Cryptography.ICryptographicBufferStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Security.Cryptography
{
  [ExclusiveTo(typeof (CryptographicBuffer))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(839613986, 15536, 19679, 134, 99, 29, 40, 145, 0, 101, 235)]
  internal interface ICryptographicBufferStatics
  {
    bool Compare(IBuffer object1, IBuffer object2);

    IBuffer GenerateRandom(uint length);

    uint GenerateRandomNumber();

    IBuffer CreateFromByteArray(byte[] value);

    void CopyToByteArray(IBuffer buffer, out byte[] value);

    IBuffer DecodeFromHexString(string value);

    string EncodeToHexString(IBuffer buffer);

    IBuffer DecodeFromBase64String(string value);

    string EncodeToBase64String(IBuffer buffer);

    IBuffer ConvertStringToBinary(string value, BinaryStringEncoding encoding);

    string ConvertBinaryToString(BinaryStringEncoding encoding, IBuffer buffer);
  }
}
