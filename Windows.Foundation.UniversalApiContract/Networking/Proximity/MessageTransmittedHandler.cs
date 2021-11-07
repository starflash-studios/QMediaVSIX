// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Proximity.MessageTransmittedHandler
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.Proximity
{
  /// <summary>Describes the method that will handle the event that's fired when a published message has been transmitted.</summary>
  /// <param name="sender">The proximity device that published the message.</param>
  /// <param name="messageId">The publication ID of the message.</param>
  [Guid(4020898634, 63202, 19837, 133, 108, 120, 252, 142, 252, 2, 30)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public delegate void MessageTransmittedHandler(ProximityDevice sender, long messageId);
}
