// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Chat.IRcsManagerStatics2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Chat
{
  [ExclusiveTo(typeof (RcsManager))]
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  [Guid(3444157720, 44426, 17066, 142, 235, 167, 152, 168, 128, 137, 89)]
  internal interface IRcsManagerStatics2
  {
    event EventHandler<object> TransportListChanged;
  }
}
