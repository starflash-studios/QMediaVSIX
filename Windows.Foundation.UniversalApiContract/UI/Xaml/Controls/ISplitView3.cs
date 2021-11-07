// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.ISplitView3
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [ExclusiveTo(typeof (SplitView))]
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  [WebHostHidden]
  [Guid(245443981, 4465, 16507, 150, 211, 94, 27, 71, 12, 62, 197)]
  internal interface ISplitView3
  {
    event TypedEventHandler<SplitView, object> PaneOpening;

    event TypedEventHandler<SplitView, object> PaneOpened;
  }
}
