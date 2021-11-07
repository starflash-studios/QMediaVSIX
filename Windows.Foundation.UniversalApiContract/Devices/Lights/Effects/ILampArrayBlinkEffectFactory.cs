// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Lights.Effects.ILampArrayBlinkEffectFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Lights.Effects
{
  [Guid(2275351959, 40784, 18866, 165, 111, 1, 58, 160, 141, 85, 224)]
  [ExclusiveTo(typeof (LampArrayBlinkEffect))]
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  internal interface ILampArrayBlinkEffectFactory
  {
    LampArrayBlinkEffect CreateInstance(LampArray lampArray, int[] lampIndexes);
  }
}
