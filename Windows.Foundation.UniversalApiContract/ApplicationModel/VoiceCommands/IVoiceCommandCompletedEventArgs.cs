// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.VoiceCommands.IVoiceCommandCompletedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.VoiceCommands
{
  [ExclusiveTo(typeof (VoiceCommandCompletedEventArgs))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3361630045, 65090, 17196, 153, 7, 9, 223, 159, 207, 100, 232)]
  internal interface IVoiceCommandCompletedEventArgs
  {
    VoiceCommandCompletionReason Reason { get; }
  }
}
