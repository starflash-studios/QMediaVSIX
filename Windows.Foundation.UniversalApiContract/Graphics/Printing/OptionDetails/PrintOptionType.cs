// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Printing.OptionDetails.PrintOptionType
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Graphics.Printing.OptionDetails
{
  /// <summary>Specifies the print task option types.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum PrintOptionType
  {
    /// <summary>Unknown option type.</summary>
    Unknown,
    /// <summary>A type of option that is numerical.</summary>
    Number,
    /// <summary>A type of option that is a string or some text.</summary>
    Text,
    /// <summary>A type of option that is a list of items.</summary>
    ItemList,
    /// <summary>A type of option that is a toggle.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 393216)] Toggle,
  }
}
