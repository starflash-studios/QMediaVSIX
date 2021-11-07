// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Documents.IGlyphs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Media;

namespace Windows.UI.Xaml.Documents
{
  [WebHostHidden]
  [ExclusiveTo(typeof (Glyphs))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3497609611, 62129, 17025, 153, 162, 228, 208, 89, 50, 178, 181)]
  internal interface IGlyphs
  {
    string UnicodeString { get; set; }

    string Indices { get; set; }

    Uri FontUri { get; set; }

    StyleSimulations StyleSimulations { get; set; }

    double FontRenderingEmSize { get; set; }

    double OriginX { get; set; }

    double OriginY { get; set; }

    Brush Fill { get; set; }
  }
}
