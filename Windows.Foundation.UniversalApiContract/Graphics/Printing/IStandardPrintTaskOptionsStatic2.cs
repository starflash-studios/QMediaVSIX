// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Printing.IStandardPrintTaskOptionsStatic2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Graphics.Printing
{
  [ExclusiveTo(typeof (StandardPrintTaskOptions))]
  [Guid(1004768244, 31300, 17001, 154, 82, 129, 38, 30, 40, 158, 233)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  internal interface IStandardPrintTaskOptionsStatic2
  {
    string Bordering { get; }
  }
}
