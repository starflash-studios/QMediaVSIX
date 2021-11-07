// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Proximity.MessageReceivedHandler
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.Proximity
{
  /// <summary>Describes the method that will handle the event that's fired when a message that has been subscribed to has been received.</summary>
  /// <param name="sender">The proximity device that received the message.</param>
  /// <param name="message">The message and related data that were passed to the event handler.</param>
  [Guid(4020963202, 63202, 18037, 160, 69, 216, 227, 32, 194, 72, 8)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public delegate void MessageReceivedHandler(ProximityDevice sender, ProximityMessage message);
}
