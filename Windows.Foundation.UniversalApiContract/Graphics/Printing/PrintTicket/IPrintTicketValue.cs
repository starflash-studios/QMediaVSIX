// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Printing.PrintTicket.IPrintTicketValue
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Graphics.Printing.PrintTicket
{
  [Guid(1723009586, 9293, 20002, 169, 139, 187, 60, 241, 242, 221, 145)]
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  [ExclusiveTo(typeof (PrintTicketValue))]
  internal interface IPrintTicketValue
  {
    PrintTicketValueType Type { get; }

    int GetValueAsInteger();

    string GetValueAsString();
  }
}
