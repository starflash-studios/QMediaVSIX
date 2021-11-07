// Decompiled with JetBrains decompiler
// Type: Windows.Media.Core.IAudioTrackOpenFailedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Core
{
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Guid(4007508409, 47996, 16658, 191, 118, 147, 132, 103, 111, 130, 75)]
  [ExclusiveTo(typeof (AudioTrackOpenFailedEventArgs))]
  internal interface IAudioTrackOpenFailedEventArgs
  {
    HResult ExtendedError { get; }
  }
}
