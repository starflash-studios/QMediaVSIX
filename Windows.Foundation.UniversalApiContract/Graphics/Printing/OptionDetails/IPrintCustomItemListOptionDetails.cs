// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Printing.OptionDetails.IPrintCustomItemListOptionDetails
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Graphics.Printing.OptionDetails
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (PrintCustomItemListOptionDetails))]
  [Guid(2784689544, 22770, 20157, 185, 15, 81, 228, 242, 148, 76, 93)]
  internal interface IPrintCustomItemListOptionDetails : 
    IPrintItemListOptionDetails,
    IPrintOptionDetails,
    IPrintCustomOptionDetails
  {
    void AddItem(string itemId, string displayName);
  }
}
