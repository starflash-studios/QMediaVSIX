// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Lights.Effects.ILampArrayCustomEffectFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Lights.Effects
{
  [Guid(1756657485, 25573, 19184, 165, 139, 62, 83, 91, 148, 232, 201)]
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  [ExclusiveTo(typeof (LampArrayCustomEffect))]
  internal interface ILampArrayCustomEffectFactory
  {
    LampArrayCustomEffect CreateInstance(
      LampArray lampArray,
      int[] lampIndexes);
  }
}
