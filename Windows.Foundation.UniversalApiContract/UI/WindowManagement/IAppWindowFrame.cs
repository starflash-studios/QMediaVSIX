// Decompiled with JetBrains decompiler
// Type: Windows.UI.WindowManagement.IAppWindowFrame
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.UI.Composition;

namespace Windows.UI.WindowManagement
{
  [Guid(2665620993, 32349, 21167, 132, 107, 1, 220, 108, 41, 101, 103)]
  [WebHostHidden]
  [ExclusiveTo(typeof (AppWindowFrame))]
  [ContractVersion(typeof (UniversalApiContract), 524288)]
  internal interface IAppWindowFrame
  {
    IVector<IVisualElement> DragRegionVisuals { get; }
  }
}
