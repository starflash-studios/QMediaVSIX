// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Lights.ILampInfo
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;
using Windows.UI;

namespace Windows.Devices.Lights
{
  [ExclusiveTo(typeof (LampInfo))]
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  [Guid(817582620, 2767, 18906, 140, 16, 21, 11, 156, 246, 39, 19)]
  internal interface ILampInfo
  {
    int Index { get; }

    LampPurposes Purposes { get; }

    Vector3 Position { get; }

    int RedLevelCount { get; }

    int GreenLevelCount { get; }

    int BlueLevelCount { get; }

    int GainLevelCount { get; }

    IReference<Color> FixedColor { get; }

    Color GetNearestSupportedColor(Color desiredColor);

    TimeSpan UpdateLatency { get; }
  }
}
