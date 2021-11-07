// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IPivot2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [ExclusiveTo(typeof (Pivot))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2341111392, 6741, 16668, 168, 45, 24, 153, 28, 63, 13, 111)]
  [WebHostHidden]
  internal interface IPivot2
  {
    object LeftHeader { get; set; }

    DataTemplate LeftHeaderTemplate { get; set; }

    object RightHeader { get; set; }

    DataTemplate RightHeaderTemplate { get; set; }
  }
}
