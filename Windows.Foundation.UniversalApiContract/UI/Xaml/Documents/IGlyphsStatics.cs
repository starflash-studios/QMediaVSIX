// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Documents.IGlyphsStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Documents
{
  [Guid(576517317, 65009, 17389, 149, 143, 65, 78, 134, 241, 3, 242)]
  [WebHostHidden]
  [ExclusiveTo(typeof (Glyphs))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IGlyphsStatics
  {
    DependencyProperty UnicodeStringProperty { get; }

    DependencyProperty IndicesProperty { get; }

    DependencyProperty FontUriProperty { get; }

    DependencyProperty StyleSimulationsProperty { get; }

    DependencyProperty FontRenderingEmSizeProperty { get; }

    DependencyProperty OriginXProperty { get; }

    DependencyProperty OriginYProperty { get; }

    DependencyProperty FillProperty { get; }
  }
}
