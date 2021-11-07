// Decompiled with JetBrains decompiler
// Type: Windows.UI.Notifications.ShownTileNotification
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Notifications
{
  /// <summary>Provides info about a tile notification that was displayed in the **Start** menu.</summary>
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class ShownTileNotification : IShownTileNotification
  {
    /// <summary>Gets the arguments from the notification’s XML payload for the tile size that was displayed, or an empty string if there were no arguments provided for that size.</summary>
    /// <returns>The arguments from the notification’s XML payload for the tile size that was displayed, or an empty string if there were no arguments provided for that size.</returns>
    public extern string Arguments { [MethodImpl] get; }
  }
}
