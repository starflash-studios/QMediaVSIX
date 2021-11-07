// Decompiled with JetBrains decompiler
// Type: Windows.Media.Audio.ICreateMediaSourceAudioInputNodeResult2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Audio
{
  [Guid(1666272488, 27162, 18915, 151, 236, 40, 253, 91, 225, 20, 229)]
  [ExclusiveTo(typeof (CreateMediaSourceAudioInputNodeResult))]
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  internal interface ICreateMediaSourceAudioInputNodeResult2
  {
    HResult ExtendedError { get; }
  }
}
