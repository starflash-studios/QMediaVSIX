// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.ISwipeControl
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  [ExclusiveTo(typeof (SwipeControl))]
  [Guid(2665732463, 26372, 18467, 170, 21, 28, 20, 59, 197, 60, 247)]
  internal interface ISwipeControl
  {
    SwipeItems LeftItems { get; set; }

    SwipeItems RightItems { get; set; }

    SwipeItems TopItems { get; set; }

    SwipeItems BottomItems { get; set; }

    void Close();
  }
}
