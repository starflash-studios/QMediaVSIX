// Decompiled with JetBrains decompiler
// Type: Windows.System.IAppExecutionStateChangeResult
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System
{
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  [ExclusiveTo(typeof (AppExecutionStateChangeResult))]
  [Guid(1862507504, 63771, 19960, 174, 119, 48, 51, 204, 182, 145, 20)]
  internal interface IAppExecutionStateChangeResult
  {
    HResult ExtendedError { get; }
  }
}
