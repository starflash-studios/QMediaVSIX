// Decompiled with JetBrains decompiler
// Type: Windows.UI.Notifications.IShownTileNotification
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Notifications
{
  [ExclusiveTo(typeof (ShownTileNotification))]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Guid(875399560, 23282, 18458, 166, 163, 242, 253, 199, 141, 232, 142)]
  internal interface IShownTileNotification
  {
    string Arguments { get; }
  }
}
