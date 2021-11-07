// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Holographic.IHolographicCamera6
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Graphics.Holographic
{
  [ContractVersion(typeof (UniversalApiContract), 524288)]
  [ExclusiveTo(typeof (HolographicCamera))]
  [Guid(34150735, 25389, 20820, 171, 82, 11, 93, 21, 177, 37, 5)]
  internal interface IHolographicCamera6
  {
    HolographicViewConfiguration ViewConfiguration { get; }
  }
}
