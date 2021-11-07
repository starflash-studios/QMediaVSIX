// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Printing.PrintSupport.IPrintSupportExtensionTriggerDetails
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Graphics.Printing.PrintSupport
{
  [ExclusiveTo(typeof (PrintSupportExtensionTriggerDetails))]
  [Guid(2919773969, 39689, 21969, 160, 174, 42, 20, 197, 248, 61, 106)]
  [ContractVersion(typeof (UniversalApiContract), 851968)]
  internal interface IPrintSupportExtensionTriggerDetails
  {
    PrintSupportExtensionSession Session { get; }
  }
}
