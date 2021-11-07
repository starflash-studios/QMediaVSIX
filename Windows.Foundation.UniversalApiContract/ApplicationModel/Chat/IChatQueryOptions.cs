// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Chat.IChatQueryOptions
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Chat
{
  [ExclusiveTo(typeof (ChatQueryOptions))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(802383014, 48950, 17143, 183, 231, 146, 60, 10, 171, 254, 22)]
  internal interface IChatQueryOptions
  {
    string SearchString { get; set; }
  }
}
