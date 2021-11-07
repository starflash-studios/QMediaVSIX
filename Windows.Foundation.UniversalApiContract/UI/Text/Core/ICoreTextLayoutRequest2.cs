// Decompiled with JetBrains decompiler
// Type: Windows.UI.Text.Core.ICoreTextLayoutRequest2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Text.Core
{
  [ExclusiveTo(typeof (CoreTextLayoutRequest))]
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  [Guid(1735255588, 52541, 19405, 191, 1, 127, 113, 16, 149, 69, 17)]
  internal interface ICoreTextLayoutRequest2
  {
    CoreTextLayoutBounds LayoutBoundsVisualPixels { get; }
  }
}
