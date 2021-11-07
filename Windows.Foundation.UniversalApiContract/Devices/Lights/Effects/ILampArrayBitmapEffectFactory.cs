// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Lights.Effects.ILampArrayBitmapEffectFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Lights.Effects
{
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  [ExclusiveTo(typeof (LampArrayBitmapEffect))]
  [Guid(325091472, 58166, 19599, 144, 83, 169, 36, 7, 202, 123, 29)]
  internal interface ILampArrayBitmapEffectFactory
  {
    LampArrayBitmapEffect CreateInstance(
      LampArray lampArray,
      int[] lampIndexes);
  }
}
