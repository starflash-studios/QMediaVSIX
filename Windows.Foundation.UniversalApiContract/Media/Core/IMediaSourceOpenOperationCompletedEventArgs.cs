// Decompiled with JetBrains decompiler
// Type: Windows.Media.Core.IMediaSourceOpenOperationCompletedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Core
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (MediaSourceOpenOperationCompletedEventArgs))]
  [Guid(4234685675, 57985, 18300, 168, 224, 26, 205, 101, 65, 20, 200)]
  internal interface IMediaSourceOpenOperationCompletedEventArgs
  {
    MediaSourceError Error { get; }
  }
}
