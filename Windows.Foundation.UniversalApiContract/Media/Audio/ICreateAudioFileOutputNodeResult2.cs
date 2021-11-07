// Decompiled with JetBrains decompiler
// Type: Windows.Media.Audio.ICreateAudioFileOutputNodeResult2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Audio
{
  [ExclusiveTo(typeof (CreateAudioFileOutputNodeResult))]
  [Guid(2667689229, 13080, 18355, 166, 10, 27, 73, 43, 231, 252, 13)]
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  internal interface ICreateAudioFileOutputNodeResult2
  {
    HResult ExtendedError { get; }
  }
}
