// Decompiled with JetBrains decompiler
// Type: Windows.Media.Core.IMediaSourceAppServiceConnection
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Core
{
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  [Guid(1642195607, 6422, 18448, 183, 244, 182, 66, 190, 130, 149, 150)]
  [ExclusiveTo(typeof (MediaSourceAppServiceConnection))]
  internal interface IMediaSourceAppServiceConnection
  {
    event TypedEventHandler<MediaSourceAppServiceConnection, InitializeMediaStreamSourceRequestedEventArgs> InitializeMediaStreamSourceRequested;

    void Start();
  }
}
