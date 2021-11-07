// Decompiled with JetBrains decompiler
// Type: Windows.Storage.ISystemAudioProperties
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Storage
{
  [ExclusiveTo(typeof (SystemAudioProperties))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1066350775, 12428, 18401, 146, 77, 134, 69, 52, 142, 93, 183)]
  internal interface ISystemAudioProperties
  {
    string EncodingBitrate { get; }
  }
}
