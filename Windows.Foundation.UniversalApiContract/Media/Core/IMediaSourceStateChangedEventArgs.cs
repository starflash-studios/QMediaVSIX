// Decompiled with JetBrains decompiler
// Type: Windows.Media.Core.IMediaSourceStateChangedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Core
{
  [Guid(170962818, 36977, 19372, 188, 57, 202, 42, 147, 183, 23, 169)]
  [ExclusiveTo(typeof (MediaSourceStateChangedEventArgs))]
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  internal interface IMediaSourceStateChangedEventArgs
  {
    MediaSourceState OldState { get; }

    MediaSourceState NewState { get; }
  }
}
