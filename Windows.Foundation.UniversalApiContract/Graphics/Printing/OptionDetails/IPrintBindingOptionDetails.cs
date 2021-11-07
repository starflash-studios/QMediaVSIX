// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Printing.OptionDetails.IPrintBindingOptionDetails
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Graphics.Printing.OptionDetails
{
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  [ExclusiveTo(typeof (PrintBindingOptionDetails))]
  [Guid(3287600280, 38244, 20246, 160, 85, 169, 139, 154, 73, 233, 211)]
  internal interface IPrintBindingOptionDetails
  {
    string WarningText { set; get; }

    string Description { set; get; }
  }
}
