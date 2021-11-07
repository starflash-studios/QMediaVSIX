// Decompiled with JetBrains decompiler
// Type: Windows.Media.Audio.IAudioGraphUnrecoverableErrorOccurredEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Audio
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3285830624, 16374, 20403, 178, 98, 80, 212, 53, 197, 84, 35)]
  [ExclusiveTo(typeof (AudioGraphUnrecoverableErrorOccurredEventArgs))]
  internal interface IAudioGraphUnrecoverableErrorOccurredEventArgs
  {
    AudioGraphUnrecoverableError Error { get; }
  }
}
