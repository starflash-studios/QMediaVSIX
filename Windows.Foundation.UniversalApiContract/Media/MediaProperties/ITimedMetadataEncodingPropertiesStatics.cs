// Decompiled with JetBrains decompiler
// Type: Windows.Media.MediaProperties.ITimedMetadataEncodingPropertiesStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.MediaProperties
{
  [ContractVersion(typeof (UniversalApiContract), 655360)]
  [Guid(1714010983, 28245, 22083, 137, 160, 122, 126, 141, 133, 181, 44)]
  [ExclusiveTo(typeof (TimedMetadataEncodingProperties))]
  internal interface ITimedMetadataEncodingPropertiesStatics
  {
    TimedMetadataEncodingProperties CreatePgs();

    TimedMetadataEncodingProperties CreateSrt();

    TimedMetadataEncodingProperties CreateSsa(byte[] formatUserData);

    TimedMetadataEncodingProperties CreateVobSub(
      byte[] formatUserData);
  }
}
