// Decompiled with JetBrains decompiler
// Type: Windows.Networking.BackgroundTransfer.IBackgroundTransferRangesDownloadedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Networking.BackgroundTransfer
{
  [ExclusiveTo(typeof (BackgroundTransferRangesDownloadedEventArgs))]
  [Guid(1052537939, 48968, 19080, 146, 72, 176, 193, 101, 24, 79, 92)]
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  internal interface IBackgroundTransferRangesDownloadedEventArgs
  {
    bool WasDownloadRestarted { get; }

    IVector<BackgroundTransferFileRange> AddedRanges { get; }

    Deferral GetDeferral();
  }
}
