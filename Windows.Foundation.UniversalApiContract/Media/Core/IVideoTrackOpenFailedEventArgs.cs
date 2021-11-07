// Decompiled with JetBrains decompiler
// Type: Windows.Media.Core.IVideoTrackOpenFailedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Core
{
  [ExclusiveTo(typeof (VideoTrackOpenFailedEventArgs))]
  [Guid(1987699249, 1273, 19586, 164, 238, 134, 2, 200, 187, 71, 84)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  internal interface IVideoTrackOpenFailedEventArgs
  {
    HResult ExtendedError { get; }
  }
}
