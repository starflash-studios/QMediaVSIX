// Decompiled with JetBrains decompiler
// Type: Windows.Media.Core.ITimedMetadataStreamDescriptor
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Media.MediaProperties;

namespace Windows.Media.Core
{
  [ExclusiveTo(typeof (TimedMetadataStreamDescriptor))]
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  [Guid(322123455, 10602, 17982, 159, 249, 1, 205, 37, 105, 20, 8)]
  internal interface ITimedMetadataStreamDescriptor
  {
    TimedMetadataEncodingProperties EncodingProperties { get; }

    TimedMetadataStreamDescriptor Copy();
  }
}
