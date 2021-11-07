// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Printing.OptionDetails.IPrintStapleOptionDetails
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Graphics.Printing.OptionDetails
{
  [Guid(3560011197, 39947, 17632, 132, 246, 206, 235, 206, 101, 56, 0)]
  [ExclusiveTo(typeof (PrintStapleOptionDetails))]
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  internal interface IPrintStapleOptionDetails
  {
    string WarningText { set; get; }

    string Description { set; get; }
  }
}
