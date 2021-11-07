// Decompiled with JetBrains decompiler
// Type: Windows.Media.Audio.ISetDefaultSpatialAudioFormatResult
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Audio
{
  [ExclusiveTo(typeof (SetDefaultSpatialAudioFormatResult))]
  [Guid(472556817, 5120, 24176, 158, 169, 174, 21, 18, 65, 232, 234)]
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  internal interface ISetDefaultSpatialAudioFormatResult
  {
    SetDefaultSpatialAudioFormatStatus Status { get; }
  }
}
