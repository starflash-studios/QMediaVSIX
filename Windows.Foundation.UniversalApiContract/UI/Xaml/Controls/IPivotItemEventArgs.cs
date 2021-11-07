// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IPivotItemEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [WebHostHidden]
  [ExclusiveTo(typeof (PivotItemEventArgs))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(443511380, 7893, 19397, 160, 96, 101, 85, 48, 188, 166, 186)]
  internal interface IPivotItemEventArgs
  {
    PivotItem Item { get; set; }
  }
}
