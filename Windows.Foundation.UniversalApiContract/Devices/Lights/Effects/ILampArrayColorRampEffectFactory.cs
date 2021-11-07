// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Lights.Effects.ILampArrayColorRampEffectFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Lights.Effects
{
  [Guid(1376506163, 3188, 19957, 190, 167, 72, 153, 224, 38, 107, 15)]
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  [ExclusiveTo(typeof (LampArrayColorRampEffect))]
  internal interface ILampArrayColorRampEffectFactory
  {
    LampArrayColorRampEffect CreateInstance(
      LampArray lampArray,
      int[] lampIndexes);
  }
}
