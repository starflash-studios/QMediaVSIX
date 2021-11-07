// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.ICompositionVirtualDrawingSurface
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Graphics;

namespace Windows.UI.Composition
{
  [Guid(2848163035, 34624, 20372, 139, 157, 182, 133, 33, 231, 134, 61)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [ExclusiveTo(typeof (CompositionVirtualDrawingSurface))]
  [WebHostHidden]
  internal interface ICompositionVirtualDrawingSurface
  {
    void Trim(RectInt32[] rects);
  }
}
