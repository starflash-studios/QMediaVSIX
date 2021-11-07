// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Haptics.ISimpleHapticsControllerFeedback
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Haptics
{
  [ExclusiveTo(typeof (SimpleHapticsControllerFeedback))]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Guid(1029144312, 19694, 4582, 181, 53, 0, 27, 220, 6, 171, 59)]
  internal interface ISimpleHapticsControllerFeedback
  {
    ushort Waveform { get; }

    TimeSpan Duration { get; }
  }
}
