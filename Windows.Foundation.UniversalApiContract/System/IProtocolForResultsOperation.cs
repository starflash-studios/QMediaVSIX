// Decompiled with JetBrains decompiler
// Type: Windows.System.IProtocolForResultsOperation
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.System
{
  [ExclusiveTo(typeof (ProtocolForResultsOperation))]
  [Guid(3582011706, 28137, 19752, 147, 120, 248, 103, 130, 225, 130, 187)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IProtocolForResultsOperation
  {
    void ReportCompleted(ValueSet data);
  }
}
