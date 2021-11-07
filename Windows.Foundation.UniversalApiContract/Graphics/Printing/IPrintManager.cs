// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Printing.IPrintManager
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Graphics.Printing
{
  [Guid(4280981140, 35993, 17661, 174, 74, 25, 217, 170, 154, 15, 10)]
  [ExclusiveTo(typeof (PrintManager))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IPrintManager
  {
    event TypedEventHandler<PrintManager, PrintTaskRequestedEventArgs> PrintTaskRequested;
  }
}
