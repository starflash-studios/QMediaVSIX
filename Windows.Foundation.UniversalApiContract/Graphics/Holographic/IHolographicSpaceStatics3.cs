// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Holographic.IHolographicSpaceStatics3
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Graphics.Holographic
{
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  [Guid(989912637, 45475, 19966, 142, 121, 254, 197, 144, 158, 109, 248)]
  [ExclusiveTo(typeof (HolographicSpace))]
  internal interface IHolographicSpaceStatics3
  {
    bool IsConfigured { get; }
  }
}
