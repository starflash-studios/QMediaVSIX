// Decompiled with JetBrains decompiler
// Type: Windows.Gaming.Input.ForceFeedback.IConditionForceEffectFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Gaming.Input.ForceFeedback
{
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [ExclusiveTo(typeof (ConditionForceEffect))]
  [Guid(2443809380, 6160, 20150, 167, 115, 191, 211, 184, 205, 219, 171)]
  internal interface IConditionForceEffectFactory
  {
    ConditionForceEffect CreateInstance(ConditionForceEffectKind effectKind);
  }
}
