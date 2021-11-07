// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IVirtualizingPanelProtected
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [ExclusiveTo(typeof (VirtualizingPanel))]
  [Guid(3385436994, 49714, 18333, 167, 201, 94, 118, 17, 25, 106, 69)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IVirtualizingPanelProtected
  {
    void AddInternalChild(UIElement child);

    void InsertInternalChild(int index, UIElement child);

    void RemoveInternalChildRange(int index, int range);
  }
}
