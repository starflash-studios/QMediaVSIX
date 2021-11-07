// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Documents.ITextElementStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Documents
{
  [WebHostHidden]
  [ExclusiveTo(typeof (TextElement))]
  [Guid(170892184, 27651, 17520, 167, 155, 50, 152, 161, 4, 130, 206)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface ITextElementStatics
  {
    DependencyProperty FontSizeProperty { get; }

    DependencyProperty FontFamilyProperty { get; }

    DependencyProperty FontWeightProperty { get; }

    DependencyProperty FontStyleProperty { get; }

    DependencyProperty FontStretchProperty { get; }

    DependencyProperty CharacterSpacingProperty { get; }

    DependencyProperty ForegroundProperty { get; }

    DependencyProperty LanguageProperty { get; }
  }
}
