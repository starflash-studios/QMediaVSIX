// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Holographic.IHolographicDisplay3
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Graphics.Holographic
{
  [ExclusiveTo(typeof (HolographicDisplay))]
  [Guid(4232866502, 25728, 20488, 178, 158, 21, 125, 119, 200, 67, 247)]
  [ContractVersion(typeof (UniversalApiContract), 524288)]
  internal interface IHolographicDisplay3
  {
    HolographicViewConfiguration TryGetViewConfiguration(
      HolographicViewConfigurationKind kind);
  }
}
