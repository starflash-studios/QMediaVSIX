// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Printing.OptionDetails.IPrintDuplexOptionDetails
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Graphics.Printing.OptionDetails
{
  [ExclusiveTo(typeof (PrintDuplexOptionDetails))]
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  [Guid(4242097553, 54436, 17658, 179, 254, 66, 224, 186, 40, 213, 173)]
  internal interface IPrintDuplexOptionDetails
  {
    string WarningText { set; get; }

    string Description { set; get; }
  }
}
