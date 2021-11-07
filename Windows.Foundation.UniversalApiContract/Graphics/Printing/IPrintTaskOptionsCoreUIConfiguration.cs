// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Printing.IPrintTaskOptionsCoreUIConfiguration
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Graphics.Printing
{
  /// <summary>An interface that provides access to the core UI configuration functionality that is supported by the print task options.</summary>
  [Guid(1659280931, 39454, 17206, 183, 79, 60, 199, 244, 207, 247, 9)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public interface IPrintTaskOptionsCoreUIConfiguration
  {
    /// <summary>Gets the **DisplayedOptions** option for a print task.</summary>
    /// <returns>The DisplayedOptions option.</returns>
    IVector<string> DisplayedOptions { get; }
  }
}
