// Decompiled with JetBrains decompiler
// Type: Windows.Foundation.Diagnostics.IErrorDetailsStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation.Metadata;

namespace Windows.Foundation.Diagnostics
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (ErrorDetails))]
  [Guid(3077584720, 2845, 18120, 170, 14, 75, 129, 120, 228, 252, 233)]
  internal interface IErrorDetailsStatics
  {
    [RemoteAsync]
    IAsyncOperation<ErrorDetails> CreateFromHResultAsync(int errorCode);
  }
}
