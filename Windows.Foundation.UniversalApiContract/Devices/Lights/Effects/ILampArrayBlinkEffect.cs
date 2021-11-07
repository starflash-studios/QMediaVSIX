// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Lights.Effects.ILampArrayBlinkEffect
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI;

namespace Windows.Devices.Lights.Effects
{
  [ExclusiveTo(typeof (LampArrayBlinkEffect))]
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  [Guid(3955176950, 12229, 19379, 179, 195, 98, 33, 167, 104, 13, 19)]
  internal interface ILampArrayBlinkEffect
  {
    Color Color { get; set; }

    TimeSpan AttackDuration { get; set; }

    TimeSpan SustainDuration { get; set; }

    TimeSpan DecayDuration { get; set; }

    TimeSpan RepetitionDelay { get; set; }

    TimeSpan StartDelay { get; set; }

    int Occurrences { get; set; }

    LampArrayRepetitionMode RepetitionMode { get; set; }
  }
}
