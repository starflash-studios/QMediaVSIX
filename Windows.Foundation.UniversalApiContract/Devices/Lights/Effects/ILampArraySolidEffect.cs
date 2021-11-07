// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Lights.Effects.ILampArraySolidEffect
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI;

namespace Windows.Devices.Lights.Effects
{
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  [ExclusiveTo(typeof (LampArraySolidEffect))]
  [Guid(1142915603, 17356, 19251, 128, 235, 198, 221, 222, 125, 200, 237)]
  internal interface ILampArraySolidEffect
  {
    Color Color { get; set; }

    TimeSpan Duration { get; set; }

    TimeSpan StartDelay { get; set; }

    LampArrayEffectCompletionBehavior CompletionBehavior { get; set; }
  }
}
