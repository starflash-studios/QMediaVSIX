// Decompiled with JetBrains decompiler
// Type: Windows.Networking.PushNotifications.IRawNotification
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.PushNotifications
{
  [ExclusiveTo(typeof (RawNotification))]
  [Guid(438465153, 15225, 17068, 153, 99, 34, 171, 0, 212, 240, 183)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IRawNotification
  {
    string Content { get; }
  }
}
