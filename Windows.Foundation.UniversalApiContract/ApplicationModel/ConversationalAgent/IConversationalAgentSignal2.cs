// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.ConversationalAgent.IConversationalAgentSignal2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.ConversationalAgent
{
  [ContractVersion(typeof (UniversalApiContract), 851968)]
  [Guid(3503061929, 39547, 23604, 136, 14, 182, 20, 108, 144, 78, 203)]
  [ExclusiveTo(typeof (ConversationalAgentSignal))]
  internal interface IConversationalAgentSignal2
  {
    string DetectorId { get; }

    ActivationSignalDetectorKind DetectorKind { get; }
  }
}
