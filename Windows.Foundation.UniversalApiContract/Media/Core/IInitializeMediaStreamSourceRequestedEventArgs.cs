// Decompiled with JetBrains decompiler
// Type: Windows.Media.Core.IInitializeMediaStreamSourceRequestedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Media.Core
{
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  [ExclusiveTo(typeof (InitializeMediaStreamSourceRequestedEventArgs))]
  [Guid(633095649, 39688, 19502, 168, 85, 69, 66, 241, 167, 93, 235)]
  internal interface IInitializeMediaStreamSourceRequestedEventArgs
  {
    MediaStreamSource Source { get; }

    IRandomAccessStream RandomAccessStream { get; }

    Deferral GetDeferral();
  }
}
