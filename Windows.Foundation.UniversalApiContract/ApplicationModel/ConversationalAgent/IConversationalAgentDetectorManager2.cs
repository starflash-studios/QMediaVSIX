// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.ConversationalAgent.IConversationalAgentDetectorManager2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.ConversationalAgent
{
  [ExclusiveTo(typeof (ConversationalAgentDetectorManager))]
  [ContractVersion(typeof (UniversalApiContract), 851968)]
  [Guid(2220953393, 55283, 21246, 147, 17, 201, 235, 78, 62, 179, 10)]
  internal interface IConversationalAgentDetectorManager2
  {
    ActivationSignalDetector GetActivationSignalDetectorFromId(
      string detectorId);

    [RemoteAsync]
    IAsyncOperation<ActivationSignalDetector> GetActivationSignalDetectorFromIdAsync(
      string detectorId);
  }
}
