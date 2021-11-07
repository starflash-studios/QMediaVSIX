// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Printing.IStandardPrintTaskOptionsStatic
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Graphics.Printing
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3024633126, 3536, 19668, 186, 255, 147, 15, 199, 214, 165, 116)]
  [ExclusiveTo(typeof (StandardPrintTaskOptions))]
  internal interface IStandardPrintTaskOptionsStatic
  {
    string MediaSize { get; }

    string MediaType { get; }

    string Orientation { get; }

    string PrintQuality { get; }

    string ColorMode { get; }

    string Duplex { get; }

    string Collation { get; }

    string Staple { get; }

    string HolePunch { get; }

    string Binding { get; }

    string Copies { get; }

    string NUp { get; }

    string InputBin { get; }
  }
}
