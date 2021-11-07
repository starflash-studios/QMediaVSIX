// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Holographic.IHolographicSpaceStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Core;

namespace Windows.Graphics.Holographic
{
  [ExclusiveTo(typeof (HolographicSpace))]
  [Guid(911106148, 51442, 15265, 131, 145, 102, 184, 72, 158, 103, 253)]
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  internal interface IHolographicSpaceStatics
  {
    HolographicSpace CreateForCoreWindow(CoreWindow window);
  }
}
