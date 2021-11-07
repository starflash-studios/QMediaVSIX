// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IToolTip2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [ExclusiveTo(typeof (ToolTip))]
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  [WebHostHidden]
  [Guid(723181094, 10650, 23892, 128, 11, 59, 234, 18, 59, 76, 32)]
  internal interface IToolTip2
  {
    IReference<Rect> PlacementRect { get; set; }
  }
}
