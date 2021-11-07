// Decompiled with JetBrains decompiler
// Type: Windows.Media.Core.IAudioStreamDescriptor2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Core
{
  [ExclusiveTo(typeof (AudioStreamDescriptor))]
  [Guid(778629622, 42056, 18811, 136, 64, 133, 8, 38, 101, 172, 249)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  internal interface IAudioStreamDescriptor2 : IMediaStreamDescriptor
  {
    IReference<uint> LeadingEncoderPadding { set; get; }

    IReference<uint> TrailingEncoderPadding { set; get; }
  }
}
