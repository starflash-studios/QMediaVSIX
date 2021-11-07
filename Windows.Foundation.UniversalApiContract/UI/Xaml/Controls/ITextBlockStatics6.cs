// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.ITextBlockStatics6
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [ExclusiveTo(typeof (TextBlock))]
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  [Guid(1024463785, 63910, 17314, 153, 211, 87, 59, 137, 168, 60, 163)]
  [WebHostHidden]
  internal interface ITextBlockStatics6
  {
    DependencyProperty IsTextTrimmedProperty { get; }

    DependencyProperty HorizontalTextAlignmentProperty { get; }
  }
}
