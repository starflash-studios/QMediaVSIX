// Decompiled with JetBrains decompiler
// Type: Windows.Media.Audio.ICreateAudioGraphResult
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Audio
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1414786942, 31710, 19318, 187, 93, 72, 247, 156, 252, 140, 11)]
  [ExclusiveTo(typeof (CreateAudioGraphResult))]
  internal interface ICreateAudioGraphResult
  {
    AudioGraphCreationStatus Status { get; }

    AudioGraph Graph { get; }
  }
}
