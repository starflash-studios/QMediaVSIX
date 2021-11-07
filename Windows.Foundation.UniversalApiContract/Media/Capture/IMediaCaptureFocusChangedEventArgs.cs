// Decompiled with JetBrains decompiler
// Type: Windows.Media.Capture.IMediaCaptureFocusChangedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Media.Devices;

namespace Windows.Media.Capture
{
  [ExclusiveTo(typeof (MediaCaptureFocusChangedEventArgs))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2179054719, 8823, 18750, 171, 238, 211, 244, 79, 249, 140, 4)]
  internal interface IMediaCaptureFocusChangedEventArgs
  {
    MediaCaptureFocusState FocusState { get; }
  }
}
