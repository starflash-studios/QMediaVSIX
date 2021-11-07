// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.DataTransfer.IOperationCompletedEventArgs2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.DataTransfer
{
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  [ExclusiveTo(typeof (OperationCompletedEventArgs))]
  [Guid(2240782451, 7705, 16645, 178, 247, 200, 71, 136, 8, 213, 98)]
  internal interface IOperationCompletedEventArgs2
  {
    string AcceptedFormatId { get; }
  }
}
