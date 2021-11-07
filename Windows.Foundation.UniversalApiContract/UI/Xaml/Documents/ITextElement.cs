// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Documents.ITextElement
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Text;
using Windows.UI.Xaml.Media;

namespace Windows.UI.Xaml.Documents
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (TextElement))]
  [WebHostHidden]
  [Guid(3896180834, 55158, 20370, 186, 234, 64, 231, 125, 71, 145, 213)]
  internal interface ITextElement
  {
    string Name { get; }

    double FontSize { get; set; }

    FontFamily FontFamily { get; set; }

    FontWeight FontWeight { get; set; }

    FontStyle FontStyle { get; set; }

    FontStretch FontStretch { get; set; }

    int CharacterSpacing { get; set; }

    Brush Foreground { get; set; }

    string Language { get; set; }

    TextPointer ContentStart { get; }

    TextPointer ContentEnd { get; }

    TextPointer ElementStart { get; }

    TextPointer ElementEnd { get; }

    object FindName(string name);
  }
}
