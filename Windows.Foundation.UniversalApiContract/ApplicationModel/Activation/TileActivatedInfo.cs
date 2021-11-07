// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Activation.TileActivatedInfo
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.UI.Notifications;

namespace Windows.ApplicationModel.Activation
{
  /// <summary>Provides information about the tile that launched your app.</summary>
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class TileActivatedInfo : ITileActivatedInfo
  {
    /// <summary>Gets the notifications that have been shown on the tile that activated your app from most recent to oldest. The first notification represents what was on the tile when the user clicked it. If the tile was blank, the list is empty.</summary>
    /// <returns>The tile notifications that have been shown from most recent to oldest.</returns>
    public extern IVectorView<ShownTileNotification> RecentlyShownNotifications { [MethodImpl] get; }
  }
}
