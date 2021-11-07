// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.StyleSimulations
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media
{
  /// <summary>Describes the simulation style of a font.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  public enum StyleSimulations
  {
    /// <summary>No font style simulation.</summary>
    None,
    /// <summary>Bold style simulation.</summary>
    BoldSimulation,
    /// <summary>Italic style simulation.</summary>
    ItalicSimulation,
    /// <summary>Bold and italic style simulation.</summary>
    BoldItalicSimulation,
  }
}
