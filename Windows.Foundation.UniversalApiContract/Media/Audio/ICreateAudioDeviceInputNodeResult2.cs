// Decompiled with JetBrains decompiler
// Type: Windows.Media.Audio.ICreateAudioDeviceInputNodeResult2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Audio
{
  [ExclusiveTo(typeof (CreateAudioDeviceInputNodeResult))]
  [Guid(2451335630, 16181, 16839, 150, 34, 121, 246, 8, 186, 237, 194)]
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  internal interface ICreateAudioDeviceInputNodeResult2
  {
    HResult ExtendedError { get; }
  }
}
