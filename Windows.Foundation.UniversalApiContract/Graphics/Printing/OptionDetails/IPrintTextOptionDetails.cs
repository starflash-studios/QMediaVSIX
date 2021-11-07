// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Printing.OptionDetails.IPrintTextOptionDetails
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Graphics.Printing.OptionDetails
{
  /// <summary>Represents objects that describe the text of a print task option.</summary>
  [Guid(2910184803, 23780, 18108, 153, 24, 171, 159, 173, 20, 76, 91)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public interface IPrintTextOptionDetails : IPrintOptionDetails
  {
    /// <summary>Gets the maximum allowed number of characters for the text of a print task option.</summary>
    /// <returns>The maximum allowed number of characters for the text of a print task option.</returns>
    uint MaxCharacters { get; }
  }
}
