// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Chat.IRcsServiceKindSupportedChangedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Chat
{
  [ExclusiveTo(typeof (RcsServiceKindSupportedChangedEventArgs))]
  [Guid(4101939780, 59267, 18534, 179, 167, 78, 92, 207, 2, 48, 112)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IRcsServiceKindSupportedChangedEventArgs
  {
    RcsServiceKind ServiceKind { get; }
  }
}
