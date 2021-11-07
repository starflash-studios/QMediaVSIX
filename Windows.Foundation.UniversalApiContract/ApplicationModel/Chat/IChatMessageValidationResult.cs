// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Chat.IChatMessageValidationResult
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Chat
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(636041731, 10476, 22665, 86, 155, 126, 72, 107, 18, 111, 24)]
  [ExclusiveTo(typeof (ChatMessageValidationResult))]
  internal interface IChatMessageValidationResult
  {
    IReference<uint> MaxPartCount { get; }

    IReference<uint> PartCount { get; }

    IReference<uint> RemainingCharacterCountInPart { get; }

    ChatMessageValidationStatus Status { get; }
  }
}
