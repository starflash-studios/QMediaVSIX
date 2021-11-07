// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IBorderStatics2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [ExclusiveTo(typeof (Border))]
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  [Guid(2725069942, 32831, 20544, 160, 243, 230, 109, 179, 115, 49, 102)]
  [WebHostHidden]
  internal interface IBorderStatics2
  {
    DependencyProperty BackgroundSizingProperty { get; }
  }
}
