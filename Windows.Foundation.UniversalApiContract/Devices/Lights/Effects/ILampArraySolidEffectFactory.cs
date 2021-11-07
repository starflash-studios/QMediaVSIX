// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Lights.Effects.ILampArraySolidEffectFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Lights.Effects
{
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  [Guid(4167213868, 21878, 17217, 150, 27, 174, 225, 241, 60, 249, 221)]
  [ExclusiveTo(typeof (LampArraySolidEffect))]
  internal interface ILampArraySolidEffectFactory
  {
    LampArraySolidEffect CreateInstance(LampArray lampArray, int[] lampIndexes);
  }
}
