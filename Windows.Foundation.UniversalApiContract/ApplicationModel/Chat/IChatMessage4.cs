// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Chat.IChatMessage4
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Chat
{
  [Guid(756304655, 53951, 17932, 170, 104, 109, 63, 132, 131, 201, 191)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [ExclusiveTo(typeof (ChatMessage))]
  internal interface IChatMessage4 : IChatMessage
  {
    string SyncId { get; set; }
  }
}
