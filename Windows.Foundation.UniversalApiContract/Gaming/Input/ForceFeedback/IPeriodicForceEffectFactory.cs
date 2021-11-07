// Decompiled with JetBrains decompiler
// Type: Windows.Gaming.Input.ForceFeedback.IPeriodicForceEffectFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Gaming.Input.ForceFeedback
{
  [Guid(1868753690, 38993, 18299, 179, 24, 53, 236, 170, 21, 7, 15)]
  [ExclusiveTo(typeof (PeriodicForceEffect))]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  internal interface IPeriodicForceEffectFactory
  {
    PeriodicForceEffect CreateInstance(PeriodicForceEffectKind effectKind);
  }
}
