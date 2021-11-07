// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IBorder2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  [Guid(2716843421, 52107, 22197, 135, 141, 58, 127, 67, 188, 151, 48)]
  [ExclusiveTo(typeof (Border))]
  [WebHostHidden]
  internal interface IBorder2
  {
    BackgroundSizing BackgroundSizing { get; set; }

    BrushTransition BackgroundTransition { get; set; }
  }
}
