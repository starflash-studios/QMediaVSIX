// Decompiled with JetBrains decompiler
// Type: Windows.Media.Core.ITimedTextSourceResolveResultEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Media.Core
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1217428636, 56536, 19507, 154, 211, 108, 220, 231, 177, 197, 102)]
  [ExclusiveTo(typeof (TimedTextSourceResolveResultEventArgs))]
  internal interface ITimedTextSourceResolveResultEventArgs
  {
    TimedMetadataTrackError Error { get; }

    IVectorView<TimedMetadataTrack> Tracks { get; }
  }
}
