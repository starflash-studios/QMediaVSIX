// Decompiled with JetBrains decompiler
// Type: Windows.Media.Capture.RecordLimitationExceededEventHandler
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Capture
{
  /// <summary>Represents the method that will handle RecordLimitationExceeded and related events.</summary>
  /// <param name="sender">The object where the event handler is attached.</param>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1068404526, 20449, 20477, 170, 186, 225, 241, 51, 125, 78, 83)]
  public delegate void RecordLimitationExceededEventHandler(MediaCapture sender);
}
