// Decompiled with JetBrains decompiler
// Type: Windows.Media.Core.IMediaStreamSampleProtectionProperties
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Core
{
  [Guid(1320714898, 60639, 18750, 132, 29, 221, 74, 221, 124, 172, 162)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (MediaStreamSampleProtectionProperties))]
  internal interface IMediaStreamSampleProtectionProperties
  {
    void SetKeyIdentifier(byte[] value);

    void GetKeyIdentifier(out byte[] value);

    void SetInitializationVector(byte[] value);

    void GetInitializationVector(out byte[] value);

    void SetSubSampleMapping(byte[] value);

    void GetSubSampleMapping(out byte[] value);
  }
}
