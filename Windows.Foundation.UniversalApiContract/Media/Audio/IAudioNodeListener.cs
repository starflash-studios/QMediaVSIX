// Decompiled with JetBrains decompiler
// Type: Windows.Media.Audio.IAudioNodeListener
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;

namespace Windows.Media.Audio
{
  [Guid(3648138774, 3082, 16858, 183, 85, 108, 119, 131, 95, 177, 235)]
  [ExclusiveTo(typeof (AudioNodeListener))]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  internal interface IAudioNodeListener
  {
    Vector3 Position { get; set; }

    Quaternion Orientation { get; set; }

    double SpeedOfSound { get; set; }

    Vector3 DopplerVelocity { get; set; }
  }
}
