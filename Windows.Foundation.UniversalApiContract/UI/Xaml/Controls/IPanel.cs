// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IPanel
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Animation;

namespace Windows.UI.Xaml.Controls
{
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2768915389, 33633, 18076, 144, 218, 233, 164, 12, 116, 116, 223)]
  [ExclusiveTo(typeof (Panel))]
  internal interface IPanel
  {
    UIElementCollection Children { get; }

    Brush Background { get; set; }

    bool IsItemsHost { get; }

    TransitionCollection ChildrenTransitions { get; set; }
  }
}
