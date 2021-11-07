// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Printing.IPrintTaskSourceRequestedArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Graphics.Printing
{
  [Guid(4193281982, 62550, 16880, 156, 152, 92, 231, 62, 133, 20, 16)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (PrintTaskSourceRequestedArgs))]
  internal interface IPrintTaskSourceRequestedArgs
  {
    DateTime Deadline { get; }

    void SetSource(IPrintDocumentSource source);

    PrintTaskSourceRequestedDeferral GetDeferral();
  }
}
