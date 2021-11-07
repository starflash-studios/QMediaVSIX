// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Printing.OptionDetails.IPrintItemListOptionDetails
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Graphics.Printing.OptionDetails
{
  /// <summary>Represents objects that list print task option items.</summary>
  [Guid(2585941951, 65121, 17368, 162, 79, 163, 246, 171, 115, 32, 231)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public interface IPrintItemListOptionDetails : IPrintOptionDetails
  {
    /// <summary>Gets a list of the print task option items.</summary>
    /// <returns>A pointer to the list of the print task option items.</returns>
    IVectorView<object> Items { [return: HasVariant] get; }
  }
}
