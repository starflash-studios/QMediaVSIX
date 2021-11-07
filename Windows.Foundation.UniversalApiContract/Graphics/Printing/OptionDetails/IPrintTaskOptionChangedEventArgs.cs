// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Printing.OptionDetails.IPrintTaskOptionChangedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Graphics.Printing.OptionDetails
{
  [ExclusiveTo(typeof (PrintTaskOptionChangedEventArgs))]
  [Guid(1696169221, 42478, 17159, 148, 7, 154, 202, 209, 71, 103, 156)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IPrintTaskOptionChangedEventArgs
  {
    object OptionId { [return: Variant] get; }
  }
}
