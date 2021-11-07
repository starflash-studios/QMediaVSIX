// Decompiled with JetBrains decompiler
// Type: Windows.Networking.PushNotifications.IRawNotification3
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Networking.PushNotifications
{
  [ContractVersion(typeof (UniversalApiContract), 655360)]
  [Guid(1651736030, 35443, 16972, 171, 68, 86, 53, 244, 10, 150, 229)]
  [ExclusiveTo(typeof (RawNotification))]
  internal interface IRawNotification3
  {
    IBuffer ContentBytes { get; }
  }
}
