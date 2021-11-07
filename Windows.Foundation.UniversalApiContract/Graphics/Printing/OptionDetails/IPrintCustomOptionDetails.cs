// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Printing.OptionDetails.IPrintCustomOptionDetails
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Graphics.Printing.OptionDetails
{
  /// <summary>Represents the base class for all CustomPrintTaskOptionXxx objects.</summary>
  [Guid(3811302940, 10415, 19344, 149, 218, 163, 172, 243, 32, 185, 41)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public interface IPrintCustomOptionDetails : IPrintOptionDetails
  {
    /// <summary>Gets or sets the display name of the custom print task option.</summary>
    /// <returns>The display name of the custom print task option.</returns>
    string DisplayName { set; get; }
  }
}
