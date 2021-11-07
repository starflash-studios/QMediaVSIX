// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IRichTextBlockOverflowStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [ExclusiveTo(typeof (RichTextBlockOverflow))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [Guid(68862711, 20267, 17347, 161, 34, 63, 234, 156, 169, 220, 135)]
  internal interface IRichTextBlockOverflowStatics
  {
    DependencyProperty OverflowContentTargetProperty { get; }

    DependencyProperty PaddingProperty { get; }

    DependencyProperty HasOverflowContentProperty { get; }
  }
}
